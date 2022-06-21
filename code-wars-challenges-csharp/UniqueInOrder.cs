/*
https://www.codewars.com/kata/54e6533c92449cc251001667
Implement the function unique_in_order which takes as argument a sequence and returns a list of items 
without any elements with the same value next to each other and preserving the original order of elements.

For example:

uniqueInOrder("AAAABBBCCDAABBB") == {'A', 'B', 'C', 'D', 'A', 'B'}
uniqueInOrder("ABBCcAD")         == {'A', 'B', 'C', 'c', 'A', 'D'}
uniqueInOrder([1,2,2,3,3])       == {1,2,3}
*/

namespace UniqueInOrderChallenge;

public class UniqueOrder
{
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {
        var list = iterable.ToArray();
        var result = new List<T>();

        for (int i = 0; i < list.Length; i++)
        {
            if (!result.Contains(list[i]))
            {
                result.Add(list[i]);
            }
            if (!list[i].Equals(result.Last()))
            {
                result.Add(list[i]);
            }
        }

        return result;
    }

    public static IEnumerable<T> UniqueInOrder2<T>(IEnumerable<T> iterable)
    {
        var result = new List<T>();

        foreach (var item in iterable)
        {
            if (!item.Equals(result.LastOrDefault()))
            {
                result.Add(item);
            }
        }

        return result;
    }
}
