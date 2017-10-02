using System;
using System.Collections.Generic;

namespace Equality._8ComparersAndEqualityComparers.SortItems
{
	class FoodNameComparer : Comparer<Food>
	{
		private static FoodNameComparer _instance = new FoodNameComparer();

		public static FoodNameComparer Instance { get { return _instance; } }

		private FoodNameComparer() { }

		public override int Compare(Food x, Food y)
		{
			if (x == null && y == null)
				return 0;
			if (x == null)
				return -1;
			if (y == null)
				return 1;
			return string.Compare(x.Name, y.Name, StringComparison.CurrentCulture);
		}
	}
}
