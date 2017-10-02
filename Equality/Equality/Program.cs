using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Equality.ImplementingEqualityforReferenceTypes;
using Equality.ImplementingEqualityForValueTypes;
using Equality._10StructuralEqualityAndComparisons.StructuralEquality;
using Equality._6Comparisons;
using Equality._7Strings;
using Equality._8ComparersAndEqualityComparers.EqualityComparerDemo;
using Equality._8ComparersAndEqualityComparers.InconsistentSorting;
using Equality._8ComparersAndEqualityComparers.SortItems;
using Equality._8ComparersAndEqualityComparers.StringComparers;
using Equality._9HashCodesaAndHashtables.EqualityComparerDemo;
using Equality._9HashCodesaAndHashtables.FoodNameEquality;
using Equality._9HashCodesaAndHashtables.ValueTypeEquality;


namespace Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            //_1General.Run();
            //_2EqualityInDotNet.Run();
            //_3TheCSharpEqualityOperator.Run();
            //_4ImplementingEqualityForValueTypes.Run();
            //_5Implementing_Equality_for_Reference_Types.Run();
            //_6StringIntCompare.Run();
            //_6CalorieCountCompareImplmentingComparisonsForValueType.Run();
            //_7CompareStringsDemo.Run();
            //_7OrdinalCompareStrings.Run();
            //_7StringEquality.Run();
            //_7Pooling.Run();
            //_8SortItems.Run();
            _8InconsistentSorting.Run();
            //_8EqualityComparerDemo.Run();
            //_8StringComparers.Run();
            //_9ValueTypeEquality.Run();
            //_9FoodNameEquality.Run();
            //_9EqualityComparerDemo.Run();
            //_10StructuralEquality.Run();

            Console.ReadLine();
        }

        //public static unsafe string getAddr()
        //{

        //    int y = 10; // определяем переменную
        //    // получим адрес переменной y
        //    uint addr = (uint)&y;
        //    Console.WriteLine("y address: {0}", addr);
        //    return addr.ToString();
        //}
    }
}
