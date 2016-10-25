using System;

namespace GitTests {
	
	public class MyClass {
		
		public static void Sum(int[] numbers)
		{
			LogMessages();

			int result = 0;
			foreach (int number in numbers) {
				result += number;
			}
			return result;
		}


		private static void LogMessages()
		{
			Console.WriteLine("Summing with {0} numbers.", numbers.Count);
			Console.WriteLine("Called from within MyClass.");
		}
	}
}