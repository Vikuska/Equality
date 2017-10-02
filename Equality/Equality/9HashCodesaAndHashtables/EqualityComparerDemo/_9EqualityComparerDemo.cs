using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality._9HashCodesaAndHashtables.EqualityComparerDemo
{
    //EqualityComparerDemo: Extension of the project of the same name from module 8 - extended to show using MS StringComparer to supply hash codes
    public class _9EqualityComparerDemo
    {
        public static void Run()
        {
            var foodItems = new HashSet<FoodItem>(FoodItemEqualityComparer.Instance);
            foodItems.Add(new FoodItem("apple", FoodGroup.Fruit));
            foodItems.Add(new FoodItem("pear", FoodGroup.Fruit));
            foodItems.Add(new FoodItem("pineapple", FoodGroup.Fruit));
            foodItems.Add(new FoodItem("Apple", FoodGroup.Fruit));

            foreach (var foodItem in foodItems)
                Console.WriteLine(foodItem);
        }
    }
}
