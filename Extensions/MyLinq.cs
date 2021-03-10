using System;
using System.Collections.Generic;

namespace LinqSamples.MyLinq {
	public static class MyLinq {
		/// <summary> Simple implementation of Linq's 'Where' method </summary>
		public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Func<T, bool> predicate) {
			var ret = new List<T>();
			foreach(var item in source) {
				if(predicate(item))
					ret.Add(item);
			}
			return ret;
		}

		/// <summary> Deferred implementation of Linq's 'Where' method </summary>
		public static IEnumerable<T> FilterDeferred<T>(this IEnumerable<T> source, Func<T, bool> predicate) {
			foreach(var item in source) {
				if(predicate(item))
					yield return item;
			}
		}
	}
}
