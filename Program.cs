using System;
using System.Linq;
using System.Collections.Generic;

namespace ArrayManipulator
{
	public class MainClass
	{
		public static void Main()
		{
			List<int> numbers = Console.ReadLine()
			                     .Split()
			                     .Select(int.Parse)
			                     .ToList();

			var bombSpec = Console.ReadLine()
								  .Split();

			int bomb = int.Parse(bombSpec[0]);
			int power = int.Parse(bombSpec[1]);

			for (var i = 0; i < numbers.Count; i++)
			{
				if (numbers[i] == bomb)
				{
					var left = Math.Max(i - power, 0);
					var right = Math.Min(i + power, numbers.Count - 1);

					var lenght = right - left + 1;

					numbers.RemoveRange(left, lenght);

					i = 0;
				}
			}

			Console.WriteLine(numbers.Sum());
		}
	}
}
