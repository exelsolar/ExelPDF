﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecotiza.PDFBase.Infrastructure.String
{
    public static class StringSpace
    {
        public static string SpaceStr(this string str, int numberCharacter)
        {
            string newStr = "";
            int countLength = 0;
            for (int i = 0; i < str.Length; i++)
            {
                newStr += str[i].ToString();
                countLength++;
                if (countLength == numberCharacter)
                {
                    newStr += "   ";
                    countLength = 0;
                }
            }
            return newStr.ToString();
        }
    }
}
