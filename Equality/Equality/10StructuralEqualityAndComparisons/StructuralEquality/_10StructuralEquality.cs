﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality._10StructuralEqualityAndComparisons.StructuralEquality
{
    //StructuralEquality: Demonstrates structural equality and comparisons on an array
    public class _10StructuralEquality
    {
        public static void Run()
        {
            string[] arr1 = { "apple", "orange", "pineapple" };
            string[] arr2 = { "apple", "orange", "Pineapple" };

            // reference equality
            Console.WriteLine(arr1 == arr2);
            Console.WriteLine(arr1.Equals(arr2));

            // structural equality
            var arrayEq = (IStructuralEquatable)arr1;
            bool structEqual = arrayEq.Equals(arr2, StringComparer.OrdinalIgnoreCase);
            Console.WriteLine(structEqual);

            // structural comparison
            var arrayComp = (IStructuralComparable)arr1;
            int structComp = arrayComp.CompareTo(arr2, StringComparer.OrdinalIgnoreCase);
            Console.WriteLine(structComp);
        }
    }
}
