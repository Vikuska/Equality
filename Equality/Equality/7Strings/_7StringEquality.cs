﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality._7Strings
{
    //StringEquality: Demonstrates different ways to check strings for equality
    public class _7StringEquality
    {
        public static void Run()
        {
            bool areEqual = string.Equals("Apple", "Pineapple", StringComparison.CurrentCultureIgnoreCase);

            // To do an equals for which there is no Equals() method:
            int cmpResult = string.Compare(
                "Apple", "Pineapple", CultureInfo.GetCultureInfo("fr-FR"), CompareOptions.IgnoreSymbols);
            areEqual = (cmpResult == 0);

            // case-sensitive ordinal:
            areEqual = ("Apple" == "Pineapple");
            areEqual = "Apple".Equals("Pineapple");
        }
    }
}
