/*
https://www.codewars.com/kata/55bf01e5a717a0d57e0000ec

Write a function, persistence, that takes in a positive parameter num and returns its multiplicative persistence, which is the number of times you must multiply the digits in num until you reach a single digit.

For example (Input --> Output):

39 --> 3 (because 3*9 = 27, 2*7 = 14, 1*4 = 4 and 4 has only one digit)
999 --> 4 (because 9*9*9 = 729, 7*2*9 = 126, 1*2*6 = 12, and finally 1*2 = 2)
4 --> 0 (because 4 is already a one-digit number)

Points:
- check digits len
- while?
- convert to list?

*/

using System.Collections.Generic;

namespace PersistentBuggerChallenge;

public class Persist
{
	public static int Persistence(long n)
	{
		var list = GenerateList(n);

		int multiplyCounter = 0;
		int numberOfElements = list.Count;
		int multiplyResult = 1;

		if (list.Count == 1)
        {
			return 0;
        }

		while (numberOfElements != 1)
        {
			for (int index = 0; index < numberOfElements; index++)
			{
				multiplyResult *= list[index];
			}
			multiplyCounter++;
				
			list = GenerateList(multiplyResult);
			numberOfElements = list.Count;

			multiplyResult = 1;
		}

		return multiplyCounter;
	}

	private static List<int> GenerateList(long n)
    {
		var asString = n.ToString();
		var listOfDigits = new List<int>();

		for (int index = 0; index < asString.Length; index++)
		{
			int digit = int.Parse(asString[index].ToString());
			listOfDigits.Add(digit);
		}

		return listOfDigits;
	}
}
