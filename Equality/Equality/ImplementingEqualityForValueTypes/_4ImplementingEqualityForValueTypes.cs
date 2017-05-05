using System;

namespace Equality.ImplementingEqualityForValueTypes
{
    class _4ImplementingEqualityForValueTypes
    {
        public static void Run()
        {
            FoodItem banana = new FoodItem("banana", FoodGroup.Fruit);
            FoodItem banana2 = new FoodItem("banana", FoodGroup.Fruit);
            FoodItem chocolate = new FoodItem("chocolate", FoodGroup.Sweets);

            Console.WriteLine(
                "banana    == banana2:   " + (banana == banana2));
            Console.WriteLine(
                "banana2   == chocolate: " + (banana2 == chocolate));
            Console.WriteLine(
                "chocolate == banana:    " + (chocolate == banana));
        }
    }
}
