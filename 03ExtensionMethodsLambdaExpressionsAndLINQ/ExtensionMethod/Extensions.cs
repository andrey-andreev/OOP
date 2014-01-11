using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExtensionMethods
{
    public static class Extensions
    {
        /* 1.
         * Implement an extension method Substring(int index, int length) for the 
         * class StringBuilder that returns new StringBuilder and has the same 
         * functionality as Substring in the class String.
         */

        public static StringBuilder SubString(this StringBuilder strBuilder, int index, int length)
        {
            StringBuilder result = new StringBuilder();
            for (int i = index; i <= length; i++)
            {
                result.Append(strBuilder[i]);
            }

            return result; 
        }
    }
}


