using LinqSamples.Models;
using System.Collections.Generic;

namespace LinqSamples.Data {
	public class People {
		public static List<Person> GetData() {
			var ret = new List<Person> {
				new Person(1, "Liron", 41),
				new Person(2, "Mirit", 36),
				new Person(3, "Gili", 8),
				new Person(4, "Ayala", 3),
				new Person(5, "Daniella", 1),
				
				//new Person(6, "Mor", 36),
				//new Person(7, "Meshulam", 36),
			};
			return ret;
		}
	}
}
