using LinqSamples.Data;
using LinqSamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LinqSamples {
	public class Play {
		public static void Run() {
			// Note: Sample Data that will helps us play with Linq
			var data = People.GetData();

			var filtered = data
				.Where(x => x.Age > 18)			// Note: Filtering. The Where method is deferred & streaming
				.OrderBy(x => x.Age)			// Note: Sorting. The OrderBy method is non-deferred & non-streaming
				.Select(person=> person.Name)   // Note: Projection (turning one object to another). Cannot be reversed!
				
				//.Select((person, index) => new { Index = index, ID = person.ID, Name = person.Name }) // Note: Another projection sample, using anonymouse object

				.ToList(); // Note: Execution method


			// Note: Any / All method are execution method
			if(data.Any(x => x.Age > 40))
				Console.WriteLine($"At least 1 person is mopre than 40 YO");
			if(data.All(x => x.Age < 50))
				Console.WriteLine($"All the people are younger then 50 YO");

			// Note: First / FirstOrDefault / Single / SingleOrDefault (and "Last" match) are all execution method
			var theFirstAdult = data
				.First(x => x.Age > 18);

			// Note: Fluent invocation (combining the methods)
			var youngestPerson = data
				.OrderBy(x => x.Age)
				.Select(x => new { Name = x.Name, Age = x.Age })
				.First();
			Console.WriteLine($"Youngest Person's Name: {youngestPerson.Name} (Age: {youngestPerson.Age} YO)");

			// Note: Another example of Fluent invocation
			var oldestPerson = data
				.OrderBy(x => x.Age)
				.Select(x => new { Name = x.Name, Age = x.Age })
				.Last();
			Console.WriteLine($"Oldest Person's Name: {oldestPerson.Name} (Age: {oldestPerson.Age} YO)");

			// Aggregations Smaples (Taking data and reducing it into smaller data) (statistics)
			var totalYears = data.Sum(x => x.Age);
			var MinAge = data.Min(x => x.Age);
			var MaxAge = data.Max(x => x.Age);
			var AvgAge = data.Average(x => x.Age);
			var NoOfPeople = data.Count();
			Console.WriteLine(new { totalYears, MinAge, MaxAge, AvgAge, NoOfPeople });

			// Note: (Not linq related) this is a trick to concatenate (לשרשר) list of string with a given seperator
			var allNames = data.Select(x => x.Name);
			var allNamesStr = string.Join(", ", allNames);
			Console.WriteLine(allNames);

			// Note: Json Serialization sample (part of the System.Text.Json namesapce) (not related to linq)
			filtered
				.ForEach(x => {
					string json = JsonSerializer.Serialize(x);
					Console.WriteLine(json);
				});


			// Note: Dictionary sample (part of the System.Collections.Generic namesapce) (not related to linq)
			var openWith = new Dictionary<string, string>();
			openWith.Add("txt", "notepad.exe");
			openWith.Add("bmp", "paint.exe");
			openWith.Add("dib", "paint.exe");
			openWith.Add("rtf", "wordpad.exe");
			Console.WriteLine($"Txt file should open with {openWith["txt"]}");

			//var dic = new Dictionary<int, Person>();
			//foreach(var item in data)
			//	dic.Add(item.ID, item);
			var dic = data.ToDictionary(x => x.ID);

			// Note: Linq's Query syntax
			var queryFilter = from person in data
							  where person.Age > 18
							  orderby person.Name descending
							  select person;

		}
	}
}
