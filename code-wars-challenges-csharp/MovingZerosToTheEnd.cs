/*
https://www.codewars.com/kata/52597aa56021e91c93000cb0

Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.

Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}

Attemp:
- count zeros and move to end?
- add temp array?
- iterate and if != 0 add to new list?

*/

using BenchmarkDotNet.Attributes;

namespace MovingZerosToTheEnd;

[MemoryDiagnoser]
public class MoveZeroClass
{
    [Benchmark]
    [Arguments(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1, 55, 11, 88, 100, 12, 0, 5, 4, 55, 48, 30 })]
    public int[] MoveZeroes(int[] arr)
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

    [Benchmark]
    [Arguments(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1, 55, 11, 88, 100, 12, 0, 5, 4, 55, 48, 30 })]
    public int[] MoveZeroesLinqRemove(int[] arr)
    {
        var list = arr.ToList();

        int zeros = list.RemoveAll(z => z == 0);

        for (int i = 0; i < zeros; i++)
        {
            list.Add(0);
        }


        return list.ToArray();
    }

    [Benchmark]
    [Arguments(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1, 55, 11, 88, 100, 12, 0, 5, 4, 55, 48, 30 })]
    public int[] MoveZeroesIndex(int[] arr)
    {
        int len = arr.Length;

        if (len == 0)
        {
            return arr;
        }

        int pointer = 0;

        for (int index = 0; index < len; index++)
        {
            if (arr[index] != 0)
            {
                arr[pointer] = arr[index];
                pointer++;
            }
        }

        for (int index = pointer; index < len; index++)
        {
            arr[index] = 0;
        }

        return arr;
    }

}
