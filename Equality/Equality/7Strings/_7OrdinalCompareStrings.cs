using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality._7Strings
{
    //OrdinalCompareStrings: Demonstrates string ordinal comparisons
    public class _7OrdinalCompareStrings
    {
        public static void Run()
        {
            int result = string.Compare("lemon", "LEMON", StringComparison.Ordinal);
            Console.WriteLine("Compare result is " + result);
        }
    }
}
