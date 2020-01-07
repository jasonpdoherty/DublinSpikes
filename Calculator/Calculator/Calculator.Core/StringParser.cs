using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator.Core
{
    public static class StringParser
    {
        public static IEnumerable<string> HandleBrackets(string userInputs)
        {
            List<string> result = new List<string>();

            string section = "";
            
            foreach (var item in userInputs.Reverse())
            {
                if (item == char.Parse(")"))
                {
                    result.Add(section.Reverse().ToString());
                    section = string.Empty;

                }

                section += item;
            }

            result.Add(Reverse(section)); // last section
            return result;    
        }

        private static string Reverse(string text)
        {
            if (text == null) return null;

            // this was posted by petebob as well 
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }
    }    
}
