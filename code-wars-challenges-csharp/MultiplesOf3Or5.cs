/*
https://www.codewars.com/kata/514b92a657cdc65150000006/train/csharp/62b415d4f90eac003e7a9ed3
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in. Additionally, if the number is negative, return 0 (for languages that do have them).

Note: If the number is a multiple of both 3 and 5, only count it once.

Courtesy of projecteuler.net (Problem 1) https://projecteuler.net/problem=1
*/

using System.Collections.Generic;
using System.Linq;

namespace MultiplesOf3Or5Challenge;

public class MultiplesOf3Or5
{
    public static int SolutionList(int value)
    {
        if (value <= 0)
        {
            return 0;
        }

        List<int> toList = new List<int>();

        for (int i = 3; i < value; i += 3)
        {
            toList.Add(i);
        }

        for (int j = 5; j < value; j += 5)
        {
            if (!toList.Contains(j))
            {
                toList.Add(j);
            }
        }

        return toList.Sum();
    }

    public static int SolutionSum(int value)
    {
        if (value <= 0)
        {
            return 0;
        }

        int result = 0;

        for (int i = 3; i < value; i += 3)
        {
            result += i;
        }

        for (int j = 5; j < value; j += 5)
        {
            if (!(j % 3 == 0))
            {
                result += j;
            }
        }

        return result;
    }

    public static int SolutionLinq(int value)
    {
        //some linq ???

        return 0;
    }
}
