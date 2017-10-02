using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality._9HashCodesaAndHashtables.ValueTypeEquality
{
    //ValueTypeEquality: Copy of the project of the same name from module 4 - included here to illustrate a implementation of GetHashCode()
    public class _9ValueTypeEquality
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
