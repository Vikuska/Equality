using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equality
{
    public class _3TheCSharpEqualityOperator
    {
        public static void Run()
        {
            //EqualityInt: Demonstrates == and Equals() for integers
            Console.WriteLine("----------------------<<<EqualityInt>>>------------------------------");
            Console.WriteLine("Operator: " + AreIntsEqualOp(3, 3)); //true
            Console.WriteLine("Method:   " + AreIntsEqualMethod(3, 3)); //true

            //EqualButtons: Demonstrates == and Equals() for buttons
            Console.WriteLine("-----------------------------------------------------------------\r\n\r\n\r\n");
            Console.WriteLine("----------------------<<<EqualButtons>>>------------------------------");
            Button button1 = new Button();
            button1.Text = "Click me now!";

            Button button2 = new Button();
            button2.Text = "Click me now!";

            Console.WriteLine("Operator: " + AreButtonsEqualOp(button1, button2)); //false
            Console.WriteLine("Method:   " + AreButtonsEqualMethod(button1, button2)); //false

            //EqualStrings: Demonstrates == and Equals() for strings
            Console.WriteLine("-----------------------------------------------------------------\r\n\r\n\r\n");
            Console.WriteLine("----------------------<<<EqualStrings>>>------------------------------");
            string str1 = "Click me now!";
            string str2 = string.Copy(str1);

            Console.WriteLine("Reference: " + ReferenceEquals(str1, str2)); //false
            Console.WriteLine("Operator:  " + AreStringsEqualOp(str1, str2)); //true - overloaded
            Console.WriteLine("Method:    " + AreStringsEqualMethod(str1, str2)); //true - overloaded


            //EqualValueTypes: Demonstrates == doesn't work for nonprimitive value types out of the box
            Console.WriteLine("-----------------------------------------------------------------\r\n\r\n\r\n");
            Console.WriteLine("----------------------<<<EqualValueTypes>>>------------------------------");
            Food banana = new Food("banana");
            Food banana2 = new Food("banana");
            Food chocolate = new Food("chocolate");

            Console.WriteLine(banana.Equals(chocolate)); //false
            Console.WriteLine(banana.Equals(banana2)); //false

            // this line won't compile because no == overload has been provide for Food, and Food is a valuetype
            Console.WriteLine(banana == chocolate); //false


            //EqualTuples: Demonstrates that == and object.Equals() are inconsistent for tuples
            Console.WriteLine("-----------------------------------------------------------------\r\n\r\n\r\n");
            Console.WriteLine("----------------------<<<EqualTuples>>>------------------------------");
            Tuple<int, int> tuple1 = Tuple.Create(1, 3); // the same Tuple<int, int> tuple3 = new Tuple<int, int>(1,3);
            Tuple<int, int> tuple2 = Tuple.Create(1, 3);

            Console.WriteLine("Reference: " + ReferenceEquals(tuple1, tuple2));//false
            Console.WriteLine("Method:    " + tuple1.Equals(tuple2));//true
            Console.WriteLine("Operator:  " + (tuple1 == tuple2));//false - not overloaded

            //Inheritance: Demonstrates that == doesn't work well with inheritance
            Console.WriteLine("-----------------------------------------------------------------\r\n\r\n\r\n");
            Console.WriteLine("----------------------<<<Inheritance>>>------------------------------");
            object str1Inh = "apple";
            object str2Inh = string.Copy((string)str1); //string.Copy(str1) - the same

            // The == operator will give the wrong result because it is not virtual
            // Equals() methods will work OK
            Console.WriteLine("Reference : " + ReferenceEquals(str1Inh, str2Inh)); //false
            Console.WriteLine("Method    : " + str1.Equals(str2Inh)); //true
            Console.WriteLine("Operator  : " + (str1 == str2Inh)); //false
            Console.WriteLine("Static    : " + object.Equals(str1Inh, str2Inh)); //false

            Console.WriteLine("mine    : " + string.Equals(str1Inh, str2Inh)); //false == object.Equals(str1Inh, str2Inh)) will call

            //Generics: Demonstrates that you need to use object.Equals() with generics
            Console.WriteLine("-----------------------------------------------------------------\r\n\r\n\r\n");
            Console.WriteLine("----------------------<<<Generics>>>------------------------------");
            string str1Gen = "apple";
            string str2Gen = string.Copy(str1Gen);
            DisplayWhetherArgsEqual(str1Gen, str2Gen);
        }

        static void DisplayWhetherArgsEqual<T>(T x, T y)
        {
            Console.WriteLine("Equal? " + object.Equals(x, y));

            // this line will not build - you can't in general use == with generic types
            // Console.WriteLine("Equal? " + (x == y));
        }

        static bool AreIntsEqualOp(int x, int y)
        {
            return x == y;
        }

        static bool AreIntsEqualMethod(int x, int y)
        {
            return x.Equals(y);
        }

        static bool AreButtonsEqualOp(Button x, Button y)
        {
            return x == y;
        }

        static bool AreButtonsEqualMethod(Button x, Button y)
        {
            return x.Equals(y);
        }

        static bool AreStringsEqualOp(string x, string y)
        {
            return x == y;
        }

        static bool AreStringsEqualMethod(string x, string y)
        {
            return x.Equals(y);
        }

    }
}
