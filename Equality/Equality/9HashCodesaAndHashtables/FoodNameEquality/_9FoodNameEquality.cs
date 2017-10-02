using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality._9HashCodesaAndHashtables.FoodNameEquality
{
    //FoodNameEquality: Demonstrates an equality comparer that does not check all fields in a type
    public class _9FoodNameEquality
    {
        public static void Run()
        {
            FoodItem beetroot = new FoodItem("beetroot", FoodGroup.Vegetables);
            FoodItem pickledBeetroot = new FoodItem("beetroot", FoodGroup.Sweets);

            var eqComparer = FoodNameEqualityComparer.Instance;
            bool equals = eqComparer.Equals(beetroot, pickledBeetroot);

            Console.WriteLine("Equals? " + equals.ToString());
            Console.WriteLine(eqComparer.GetHashCode(beetroot));
            Console.WriteLine(eqComparer.GetHashCode(pickledBeetroot));
        }
    }
}
