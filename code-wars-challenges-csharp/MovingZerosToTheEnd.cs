/*
https://www.codewars.com/kata/52597aa56021e91c93000cb0

Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.

Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}

Attemp:
- count zeros and move to end?
- add temp array?
- iterate and if != 0 add to new list?

*/

using System.Collections.Generic;

namespace MovingZerosToTheEnd;

public class Kata
{
    public static int[] MoveZeroes(int[] arr)
    {
        if (arr.Length == 0)
        {
            return arr;
        }

        List<int> tmp = new List<int>();

        int countZero = 0;

        foreach (int number in arr)
        {
            if (number != 0)
            {
                tmp.Add(number);
            }

            if (number == 0)
            {
                countZero++;
            }
        }

        while (countZero != 0)
        {
            tmp.Add(0);
            countZero--;
        }

        return tmp.ToArray();
    }

    public static int[] MoveZeroesIndex(int[] arr)
    {
        if (arr.Length == 0)
        {
            return arr;
        }

        int flag = 0;

        for (int index = 0; index < arr.Length; index++)
        {
            if (arr[index] != 0)
            {
                arr[flag] = arr[index];
                flag++;
            }
        }

        while (flag < arr.Length)
        {
            arr[flag] = 0;
            flag++;
        }

        return arr;
    }
}
