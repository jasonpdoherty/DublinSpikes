using System;

namespace Calculator.Core
{
    public static class StringParser
    {
        public static long ParseNumber(string userInput)
        {
            return 0;
        }

        private static string Reverse(string text)
        {
            if (text == null) return null;

            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }
    }    
}
