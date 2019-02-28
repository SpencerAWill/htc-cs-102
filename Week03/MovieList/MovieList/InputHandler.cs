using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieList
{
    static class InputHandler
    {
        public static bool CheckType(object src, Type T)
        {
            return src.GetType() == T;
        }

        public static string SanitizeString(string userInput, char[] unsafeCharacters)
        {
            userInput.Trim();
            userInput.Trim(unsafeCharacters);
            return userInput;
        }

        //public static string 
    }
}
