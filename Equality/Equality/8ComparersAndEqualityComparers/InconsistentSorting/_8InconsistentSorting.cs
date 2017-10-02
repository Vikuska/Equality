using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality._8ComparersAndEqualityComparers.InconsistentSorting
{
    //InconsistentSorting: Demonstrates how sort order can be inconsistent if you don't check all fields when comparing
    public class _8InconsistentSorting
    {
        public static void Run()
        {
            // lists will be sorted differently because the comparer is unable to distinguish 
            // apple and baked apple
            Food[] list = {
                new Food("apple", FoodGroup.Fruit),
                new Food("pear", FoodGroup.Fruit),
                new CookedFood("baked", "apple", FoodGroup.Fruit),
             };
            SortAndShowList(list);

            Food[] list2 = {
                new CookedFood("baked", "apple", FoodGroup.Fruit),
                new Food("pear", FoodGroup.Fruit),
                new Food("apple", FoodGroup.Fruit),
             };
            Console.WriteLine();
            SortAndShowList(list2);
        }
        static void SortAndShowList(Food[] list)
        {
            Array.Sort(list, FoodNameComparer.Instance);

            foreach (var item in list)
                Console.WriteLine(item);
        }
    }
}
