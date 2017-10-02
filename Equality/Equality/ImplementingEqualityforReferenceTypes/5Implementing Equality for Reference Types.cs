using System;

namespace Equality.ImplementingEqualityforReferenceTypes
{
    public class _5Implementing_Equality_for_Reference_Types
    {
        public static void Run()
        {
            Food apple = new Food("apple", FoodGroup.Fruit);
            CookedFood stewedApple = new CookedFood("stewed", "apple", FoodGroup.Fruit);
            CookedFood bakedApple = new CookedFood("baked", "apple", FoodGroup.Fruit);
            CookedFood stewedApple2 = new CookedFood("stewed", "apple", FoodGroup.Fruit);
            Food apple2 = new Food("apple", FoodGroup.Fruit);

            ////will work if == operator in base class: return x._name == y._name && x._group == y._group; //WROOOONGGG!!!!!!
            //if (bakedApple == stewedApple)
            //{
            //    System.Console.WriteLine("CHECK OP: bakedApple == stewedApple");
            //}
            //else
            //{
            //    System.Console.WriteLine("CHECK OP: bakedApple != stewedApple");
            //}

            DisplayWhetherEqual(apple, stewedApple); //if (obj.GetType() != this.GetType())
            DisplayWhetherEqual(stewedApple, bakedApple);
            DisplayWhetherEqual(stewedApple, stewedApple2);
            DisplayWhetherEqual(apple, apple2);
            DisplayWhetherEqual(apple, apple);
        }

        static void DisplayWhetherEqual(Food food1, Food food2) //compilor does not know type ==> works wrong if == operator in base class: return x._name == y._name && x._group == y._group; //WROOOONGGG!!!!!!
        {
            if (food1 == food2)
                Console.WriteLine(string.Format("{0,12} == {1}", food1, food2));
            else
                Console.WriteLine(string.Format("{0,12} != {1}", food1, food2));
        }


        ////WILL DO REFERENCE EQUALITY, NOT VALUE EQUALITY - because == operator is not virtual - does ref equality for objects ALWAYS
        //static void DisplayWhetherEqual(object food1, object food2) //not offering any type safity
        //{
        //    if (food1 == food2)
        //        Console.WriteLine(string.Format("{0,12} == {1}", food1, food2));
        //    else
        //        Console.WriteLine(string.Format("{0,12} != {1}", food1, food2));
        //}
    }
}
