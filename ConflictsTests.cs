using System;

namespace GitTests {
	
	public class MyClass {
		
		public static void Sum(int[] numbers) {
			Console.WriteLine("Summing with {0} number(s).", numbers.Count);
			Console.WriteLine("Called from within MyClass.");
			
			int result = 0;
			foreach (int number in numbers) {
				result += number;
			}
			return result;
		}
		
	}
}