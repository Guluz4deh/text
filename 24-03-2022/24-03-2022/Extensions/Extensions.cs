using System;
using System.Collections.Generic;
using System.Text;

namespace _24_03_2022.Extensions
{
    public static class Extensions
    {
        public static string CapitalizeString(this string text)
        {
            char firstLetter = Char.ToUpper(text[0]);
            StringBuilder stringBuilder = new StringBuilder(text);
            stringBuilder[0] = firstLetter;
            text = stringBuilder.ToString();
            return text;
        }


    }
}
