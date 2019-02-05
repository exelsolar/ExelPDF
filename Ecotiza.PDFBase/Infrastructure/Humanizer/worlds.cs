using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
namespace Ecotiza.PDFBase.Infrastructure.Humanizer
{
    public static class worlds
    {

        public static string numbertoWords(double amount)
        {
            string quantityStr = amount.ToString();
            string[] array = quantityStr.Split('.');
            int enteroQuantity = 0;
            int centavoQuatity = 0;
            var quantityText = "";
            /**
             * Cantidad a string y divicion entre el entero y los decimales
             **/
            if (array.ToList().Count() > 0)
            {
                if (array.ToList().Count() == 2)
                {
                    enteroQuantity =Convert.ToInt32(array[0]);
                    centavoQuatity = Convert.ToInt32(array[1]);
                    quantityText = enteroQuantity.ToWords() + " pesos con "+ centavoQuatity.ToWords() +" centavos";

                }
                else
                {
                    enteroQuantity = Convert.ToInt32(array[0]);
                    centavoQuatity = 0;
                    quantityText = enteroQuantity.ToWords()+" pesos";
                }
            }
            return quantityText;

        }
        public static string numbertowordsFloor(double amount,bool round=false)
        {
            int quantity =(int)Math.Floor(amount);
            if (round == true)
                quantity = quantity + 1;
            var text = quantity.ToWords();
            return text;
        }
        public static string numbertowordsCeiling(double amount)
        {
            int quantity = (int)Math.Ceiling(amount);
            var text = quantity.ToWords();
            return text;
        }


        public static string numbertoWords(int amount)
        {
            string quantityStr = amount.ToWords();
                       
            return quantityStr.ToUpper();

        }
    }
}
