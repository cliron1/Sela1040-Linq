namespace LinqSamples.MyExts {
	public static class MyExts {

		/// <summary> Extension wrapper for string.IsNullOrWhiteSpace </summary>
		/// <param name="str"></param>
		/// <returns> True if the string is empty </returns>
		public static bool IsEmpty(this string str) =>
			string.IsNullOrWhiteSpace(str);

		/// <summary> Converts a string to int </summary>
		/// <param name="str"></param>
		/// <returns> An Int or 0 if the string is null/empty </returns>
		public static int ToInt(this string str) =>
			str.IsEmpty() ? 0 : int.Parse(str);

	}
}
