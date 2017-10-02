using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality._7Strings
{
    //Pooling: Demonstrates string pooling
    public class _7Pooling
    {
        public static void Run()
        {
            string apple1 = "Apple";
            string apple2 = "Ap" + "ple";

            Console.WriteLine(string.Format("strings are {0} and {1}", apple1, apple2));

            Console.WriteLine(apple1 == apple2);
            // will return true because apple1 and apple2 have been pooled into one instance
            Console.WriteLine(ReferenceEquals(apple1, apple2));
        }
    }
}
