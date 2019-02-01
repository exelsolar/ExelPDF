using System;
using System.Linq;
using Ecotiza.PDFBase.Infrastructure.Strings;

namespace Ecotiza.PDFBase.Infrastructure.Infrastructure
{
    /// <summary>
    /// Generator of passwords
    /// </summary>
    public class PasswordGenerator : IPasswordGenerator
    {
        private int MinimumLengthPassword;
        private int MaximumLengthPassword;
        private int MinimumLowerCaseChars;
        private int MinimumUpperCaseChars;
        private int MinimumNumericChars;
        private int MinimumSpecialChars;
        /// <summary>
        /// 
        /// </summary>
        private int _minimumNumberOfChars
        {
            get
            {
                return MinimumLowerCaseChars + MinimumUpperCaseChars +
                    MinimumNumericChars + MinimumSpecialChars;
            }
        }
        /// <summary>
        /// LowerCase chars allowed
        /// </summary>
        private string AllLowerCaseChars;
        /// <summary>
        /// UpperCase chars allowed
        /// </summary>
        private string AllUpperCaseChars;
        /// <summary>
        /// Numeric chars allowed
        /// </summary>
        private string AllNumericChars;
        /// <summary>
        /// Special chars allowed
        /// </summary>
        private string AllSpecialChars;
        /// <summary>
        /// Chars allowed
        /// </summary>
        private string _allAvailableChars
        {
            get
            {
                return OnlyIfOneCharIsRequired(MinimumLowerCaseChars, AllLowerCaseChars) +
                OnlyIfOneCharIsRequired(MinimumUpperCaseChars, AllUpperCaseChars) +
                OnlyIfOneCharIsRequired(MinimumNumericChars, AllNumericChars) +
                OnlyIfOneCharIsRequired(MinimumSpecialChars, AllSpecialChars);
            }
        }

        /// <summary>
        /// Generator of random Seed
        /// </summary>
        private readonly RandomSecure _randomSecure = new RandomSecure();

        public PasswordGenerator()
        {
            initializeAllowedChars();
        }

        public PasswordGenerator(
            int minimumLengthPassword = 8,
            int maximumLengthPassword = 15,
            int minimumLowerCaseChars = 1,
            int minimumUpperCaseChars = 1,
            int minimumNumericChars = 1,
            int minimumSpecialChars = 1)
        {
            if (minimumLengthPassword < 1)
            {
                throw new ArgumentException("The minimumlength is smaller than 1.",
                    "minimumLengthPassword");
            }

            if (minimumLengthPassword > maximumLengthPassword)
            {
                throw new ArgumentException("The minimumLength is bigger than the maximum length.",
                    "minimumLengthPassword");
            }

            if (minimumLowerCaseChars < 0)
            {
                throw new ArgumentException("The minimumLowerCase is smaller than 0.",
                    "minimumLowerCaseChars");
            }

            if (minimumUpperCaseChars < 0)
            {
                throw new ArgumentException("The minimumUpperCase is smaller than 0.",
                    "minimumUpperCaseChars");
            }

            if (minimumNumericChars < 0)
            {
                throw new ArgumentException("The minimumNumeric is smaller than 0.",
                    "minimumNumericChars");
            }

            if (minimumSpecialChars < 0)
            {
                throw new ArgumentException("The minimumSpecial is smaller than 0.",
                    "minimumSpecialChars");
            }

            if (minimumLengthPassword < _minimumNumberOfChars)
            {
                throw new ArgumentException(
                    "The minimum length ot the password is smaller than the sum " +
                    "of the minimum characters of all categories.",
                    "maximumLengthPassword");
            }

            MinimumLengthPassword = minimumLengthPassword;
            MaximumLengthPassword = maximumLengthPassword;

            MinimumLowerCaseChars = minimumLowerCaseChars;
            MinimumUpperCaseChars = minimumUpperCaseChars;
            MinimumNumericChars = minimumNumericChars;
            MinimumSpecialChars = minimumSpecialChars;

            initializeAllowedChars();
        }

        private void initializeAllowedChars()
        {
            // Ranges not using confusing characters
            AllLowerCaseChars = GetCharRange('a', 'z', exclusiveChars: "ilo");
            AllUpperCaseChars = GetCharRange('A', 'Z', exclusiveChars: "IO");
            AllNumericChars = GetCharRange('2', '9');
            AllSpecialChars = "!@#%*()$?+-=";
        }

        private string OnlyIfOneCharIsRequired(int minimum, string allChars)
        {
            return minimum > 0 || _minimumNumberOfChars == 0 ? allChars : string.Empty;
        }

        public string Generate()
        {
            var lengthOfPassword = _randomSecure.Next(MinimumLengthPassword, MaximumLengthPassword);

            // Get the required number of characters of each catagory and 
            // add random characters of all categories
            var minimumChars = GetRandomString(AllLowerCaseChars, MinimumLowerCaseChars) +
                            GetRandomString(AllUpperCaseChars, MinimumUpperCaseChars) +
                            GetRandomString(AllNumericChars, MinimumNumericChars) +
                            GetRandomString(AllSpecialChars, MinimumSpecialChars);
            var rest = GetRandomString(_allAvailableChars, lengthOfPassword - minimumChars.Length);
            var unshuffeledResult = minimumChars + rest;

            // Shuffle the result so the order of the characters are unpredictable
            var result = unshuffeledResult.ShuffleText();
            return result;
        }

        private string GetRandomString(string possibleChars, int lenght)
        {
            if (lenght == 0)
                return string.Empty;

            var result = string.Empty;
            for (var position = 0; position < lenght; position++)
            {
                var index = _randomSecure.Next(possibleChars.Length);
                result += possibleChars[index];
            }
            return result;
        }

        private string GetCharRange(char minimum, char maximum, string exclusiveChars = "")
        {
            var result = string.Empty;
            for (char value = minimum; value <= maximum; value++)
            {
                result += value;
            }
            if (!string.IsNullOrEmpty(exclusiveChars))
            {
                var inclusiveChars = result.Except(exclusiveChars).ToArray();
                result = new string(inclusiveChars);
            }
            return result;
        }
    }
}
