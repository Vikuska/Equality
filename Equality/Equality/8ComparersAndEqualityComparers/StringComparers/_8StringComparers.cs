using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality._8ComparersAndEqualityComparers.StringComparers
{
    //StringComparers: Demonstrates using an MS string comparer to change how a collection sorts strings
    public class _8StringComparers
    {
        public static void Run()
        {
            var names = new HashSet<string>(StringComparer.CurrentCultureIgnoreCase);
            names.Add("apple");
            names.Add("pear");
            names.Add("pineapple");
            names.Add("Apple");

            foreach (string name in names)
                Console.WriteLine(name);
        }
    }
}
