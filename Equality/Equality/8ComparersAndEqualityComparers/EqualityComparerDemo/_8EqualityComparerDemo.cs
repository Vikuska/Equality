using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality._8ComparersAndEqualityComparers.EqualityComparerDemo
{
    //EqualityComparerDemo: Demonstrates implementing an equality comparer for the FoodItem struct
    public class _8EqualityComparerDemo
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
