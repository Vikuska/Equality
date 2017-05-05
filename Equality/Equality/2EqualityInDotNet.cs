using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equality
{
    public class _2EqualityInDotNet
    {
        public static void Run()
        {
            //FoodEquals: Demonstrates Equals() giving reference equality for food - turns to value equality if Food is a struct
            Console.WriteLine("----------------------<<<FoodEquals>>>------------------------------");
            Food banana = new Food("banana");
            Food banana2 = new Food("banana");
            Food chocolate = new Food("chocolate");

            // behaviour for non-null
            Console.WriteLine(banana.Equals(chocolate));  //false
            Console.WriteLine(banana.Equals(banana2));  ///////TRUE IF STRUCT, FALSE FORT CLASS

            // behaviour for nulls
            Console.WriteLine(banana.Equals(null)); //false
            Console.WriteLine(object.Equals(banana, null)); //false
            Console.WriteLine(object.Equals(null, banana)); //false
            Console.WriteLine(object.Equals(null, null)); //true


            StringRun();

            //EquatableInt: Demonstrates calling Equals() for ints
            Console.WriteLine("-----------------------------------------------------------------\r\n\r\n\r\n");
            Console.WriteLine("----------------------<<<EquatableInt>>>------------------------------");
            int three = 3;
            int threeAgain = 3;
            int four = 4;

            Console.WriteLine(three.Equals(threeAgain)); //true
            Console.WriteLine(three.Equals(four)); //false


            //FoodEqualsButton: Demonstrates the lack of type safety in object.Equals()
            Console.WriteLine("-----------------------------------------------------------------\r\n\r\n\r\n");
            Console.WriteLine("----------------------<<<FoodEqualsButton>>>------------------------------");
            Food food = new Food("chocolate");
            Button button = new Button();
            button.Text = "I'm a chocolate button - click me!";

            Console.WriteLine(food.Equals(button)); //false
        }

        public static void StringRun()
        {
            //StringEquals : Demonstrates Equals() giving value equality for strings
            Console.WriteLine("-----------------------------------------------------------------\r\n\r\n\r\n");
            Console.WriteLine("----------------------<<<StringEquals>>>------------------------------");
            string banana = "banana";
            string banana2 = string.Copy(banana);

            Console.WriteLine(banana);
            Console.WriteLine(banana2);
            Console.WriteLine(ReferenceEquals(banana, banana2)); //false
            Console.WriteLine(banana.Equals((object)banana2)); //true

            Console.WriteLine(banana.Equals((string)banana2)); //true
            Console.WriteLine(object.Equals(banana, banana2)); //true
            Console.WriteLine(string.Equals(banana, banana2)); //true
            Console.WriteLine(banana == banana2); //true
        }


    }

    // change this to a struct to see value equality for structs

    public class Food
    {
        private string _name;
        public string Name { get { return _name; } }

        public Food(string name)
        {
            this._name = name;
        }

        public override string ToString()
        {
            return _name;
        }

    }
}
