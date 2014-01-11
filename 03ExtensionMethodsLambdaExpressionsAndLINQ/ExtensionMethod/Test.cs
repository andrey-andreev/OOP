using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExtensionMethods
{
    class Test
    {
        static void Main(string[] args)
        {
            // 1.
            StringBuilder testStrBuilder = new StringBuilder("Retrieves a substring from this instance. The substring starts at a specified character position and has a specified length.");
            // Print examples in two different ways
            StringBuilder testSubstring = testStrBuilder.SubString(5, 16);
            Console.WriteLine(testSubstring);

            testSubstring = Extensions.SubString(testStrBuilder, 3, 21);
            Console.WriteLine(testSubstring);
        }
    }
}
