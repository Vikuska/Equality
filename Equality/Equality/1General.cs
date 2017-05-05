using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equality
{
    public class _1General
    {
        public static void Run()
        {
            //Buttons
            Console.WriteLine("----------------------<<<BUTTONS>>>------------------------------");
            Console.WriteLine("EqualButtons: Demonstrates that == evaluates reference equality for buttons");
            Button button1 = new Button();
            button1.Text = "Click me now!";

            Button button2 = new Button();
            button2.Text = "Click me now!";

            Console.WriteLine(button1 == button2);
            Console.WriteLine(button1.Equals(button2));
            Console.WriteLine(object.Equals(button1, button2));
            Console.WriteLine("-----------------------------------------------------------------\r\n\r\n\r\n");


            //Ints
            Console.WriteLine("-----------------------------<<<INTS>>>-------------------------------");
            Console.WriteLine("Demonstrates that == evaluates value equality for ints, but casting can change this to reference equality");
            int three = 3;
            int threeAgain = 3;
            bool intCmp = (three == threeAgain);
            Console.WriteLine(string.Format("compare ints:       {0}", intCmp));

            bool objCmp = ((object)three == (object)threeAgain);  //casting value types to objects boxes them. then == does reference equality.
            Console.WriteLine(string.Format("compare objects     {0}", objCmp));

            bool itfCmp =
                ((IComparable<int>)three == (IComparable<int>)threeAgain);
            Console.WriteLine(string.Format("compare interfaces: {0}", itfCmp));
            Console.WriteLine("----------------------------------------------------------------------\r\n\r\n\r\n");

            //Strings
            Console.WriteLine("------------------------------<<<STRINGS>>>------------------------------");
            Console.WriteLine("Demonstrates that == evaluates value equality for strings");
            string str1 = "Click me now!";
            string str2 = string.Copy(str1); // new instance => Object.ReferenceEquals(str1, str2) ==> FALSE

            Console.WriteLine("\r\n-------------------string.Copy(str1)-------------------------");
            Console.WriteLine("str1 == " + str1);
            Console.WriteLine("str2 == " + str2);
            Console.WriteLine(str1 == str2);
            Console.WriteLine(Object.ReferenceEquals(str1, str2)); //false
            Console.WriteLine(Object.Equals(str1, str2));
            Console.WriteLine(String.Equals(str1, str2));
            Console.WriteLine("-----------------------------------------------------------\r\n");

            string str3 = str1; // Object.ReferenceEquals(str1, str2) ==> TRUE

            Console.WriteLine("----------------------str3 = str1)-------------------------");
            Console.WriteLine("str1 == " + str1);
            Console.WriteLine("str2 == " + str3);
            Console.WriteLine(str1 == str3);
            Console.WriteLine(Object.ReferenceEquals(str1, str3)); //true
            Console.WriteLine(Object.Equals(str1, str3));
            Console.WriteLine(String.Equals(str1, str3));
            Console.WriteLine("----------------------------------------------------------\r\n");

            Console.WriteLine("str1 == " + str1.GetHashCode());
            Console.WriteLine("str2 == " + str2.GetHashCode());
            Console.WriteLine("str2 == " + str3.GetHashCode());
            Console.WriteLine("-----------------------------------------------------------------\r\n\r\n\r\n");

            //Floats
            Console.WriteLine("------------------------------<<<FLOATS>>>------------------------------");
            Console.WriteLine("Demonstrates that apparently unequal floats can evaluate as equal.");
            float six = 6.0000000f;
            float nearlySix = 6.0000001f;

            Console.WriteLine(six == nearlySix); //true

            Console.WriteLine(6.0000000f == 6.0000001f); //true
            Console.WriteLine("-------------------------------------------------------------------------\r\n\r\n\r\n");

            //FloatArithmetic
            Console.WriteLine("------------------------------<<<FLOAT ARITHMETIC>>>------------------------------");
            Console.WriteLine("Demonstrates that floating point arithmetic can lead to 'wrong' answers for equality");
            float x = 5.05f;
            float y = 0.95f;

            Console.WriteLine(x + y);
            Console.WriteLine("x + y ==6? " + (x + y == 6.0f)); //false

            Console.WriteLine(5.05f + 0.95f == 6.0f); //true
            Console.WriteLine("----------------------------------------------------------------------------------\r\n\r\n\r\n");
        }
    }
}
