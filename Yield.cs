using System;
using System.Collections.Generic;

namespace LinqSamples {
	public class Yield {
		public static void Run() {
			// (1)
			var nums = new List<int> { 1, 2, 3, 4, 5, 6 };
			foreach(var num in nums)
				Console.WriteLine(num);

			// (2)
			foreach(var num in fixedNumbers())
				Console.WriteLine(num);

			// (3)
			foreach(var num in numbers(nums))
				Console.WriteLine(num);

			// (4)
			int cnt = 0;
			foreach(var num in endless()) {
				Console.WriteLine(num);
				if(++cnt > 5)
					break;
			}
		}

		// (2)
		private static IEnumerable<int> fixedNumbers() {
			yield return 1;
			yield return 2;
			yield return 3;
			yield return 4;
			yield return 5;
			yield return 6;
		}

		// (3)
		static IEnumerable<int> numbers(IEnumerable<int> list) {
			foreach(var item in list) {
				yield return item;
			}
		}

		// (4)
		static IEnumerable<int> endless() {
			var i = 1;
			while(true)
				yield return i++;
		}
	}
}
