using System;
using System.Collections.Generic;

namespace LinqSamples.Helpers {
	public static class MyRandom {
		/// <summary> Return IEnumerable of random numbers </summary>
		/// <param name="cnt"> The number of numbers to return. Max 1000</param>
		/// <returns> Generated int numbers </returns>
		public static IEnumerable<int> Generate(int cnt = 0) {
			var random = new Random();
			for(int i = 0; i < (cnt != 0 ? cnt : 1000); i++)
				yield return random.Next();
		}
	}
}
