using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality._8ComparersAndEqualityComparers.SortItems
{
    //SortItems: Demonstrates using a comparer to change how Food instances are sorted
    public class _8SortItems
    {
        public static void Run()
        {
            Food[] list = {
                new Food("orange", FoodGroup.Fruit),
                new Food("banana", FoodGroup.Fruit),
                new Food("pear", FoodGroup.Fruit),
                new Food("apple", FoodGroup.Fruit) };

            Array.Sort(list, FoodNameComparer.Instance);

            foreach (var item in list)
                Console.WriteLine(item);
        }
    }
}
