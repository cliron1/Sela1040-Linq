using System;

namespace LinqSamples.Models {
	public class Person {
		public Person() {
		}
		public Person(int id, string name, int age) {
			ID = id;
			Name = name;
			Age = age;
		}

		public int ID { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }

		//private int? _age;
		//public int? Age {
		//	get {
		//		Console.WriteLine($"Get Age ({_age}) of {Name}");
		//		return _age;
		//	}
		//	set {
		//		_age = value;
		//	}
		//}
	}
}
