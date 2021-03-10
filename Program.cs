using System;
using System.Collections.Generic;
using LinqSamples.MyExts;
using System.Linq;

namespace LinqSamples {
	class Program {
		static void Main(string[] args) {
			// Note: Exts Samples
			Console.WriteLine("".IsEmpty()); // true
			Console.WriteLine("Liron".IsEmpty()); // false
			Console.WriteLine("   ".IsEmpty()); // true

			// Note: Delegate Samples
			Func<int, int> square = x => x * x;
			Func<int, int, int> add = (x, y) => x + y;
			Action<int> log = x => Console.WriteLine(x);
			log(square(5));
			log(add(4, 5));

			// Anonymouse object sample
			var product = new {
				ID = 1,
				Name = "Mouse",
				Price = 50.0
			};
			Console.WriteLine(product.ToString());

			// Note: Yield Samples
			Yield.Run();

			// Note: Linq Samples and Deferred demonstrations
			Deferred.Run();

			// Note: Play with Linq
			Play.Run();
		}
	}
}
