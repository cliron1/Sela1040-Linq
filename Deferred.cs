using LinqSamples.Models;
using LinqSamples.MyLinq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqSamples {
	public class Deferred {
		public static void Run() {
			var data = Data.People.GetData();

			#region Try-Catch
			/*
				var filtered = Enumerable.Empty<Person>();
				try {
					filtered = data.Where(p => p.Age > 18)
						.ToList();
				} catch(Exception ex) {
					Console.WriteLine(ex.Message);
				}
				*/
			#endregion

			#region Non Streaming Linq Methods
			//var filtered = data.Where(p => p.Age > 18)
			//		.OrderByDescending(p => p.Name);
			#endregion

			var filtered = data.Where(p => p.Age > 18);
			//var filtered = data.Filter(p => p.Age > 18);
			//var filtered = data.FilterDiferred(p => p.Age > 18);

			//var filtered = from person in data
			//			   where person.Age > 18
			//			   orderby person.Name descending
			//			   select person;

			//Console.WriteLine("*****************");
			//Console.WriteLine($"No. of Adults: {filtered.Count()}");

			Console.WriteLine("*****************");
			foreach(var p in filtered)
				Console.WriteLine($"=> {p.Name}");

			//var enumerator = filtered.GetEnumerator();
			//while(enumerator.MoveNext()) {
			//	Console.WriteLine($" ==> {enumerator.Current.Name}");
			//}

		}
	}
}
