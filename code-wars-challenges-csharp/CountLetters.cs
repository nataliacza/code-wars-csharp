/*
https://www.codewars.com/kata/5b358a1e228d316283001892/train/csharp

You receive the name of a city as a string, and you need to return a string that shows how many times each letter shows up in the string by using asterisks (*).

For example:

"Chicago"  -->  "c:**,h:*,i:*,a:*,g:*,o:*"
As you can see, the letter c is shown only once, but with 2 asterisks.

The return string should include only the letters (not the dashes, spaces, apostrophes, etc). There should be no spaces in the output, and the different letters are separated by a comma (,) as seen in the example above.

Note that the return string must list the letters in order of their first appearance in the original string.

More examples:

"Bangkok"    -->  "b:*,a:*,n:*,g:*,k:**,o:*"
"Las Vegas"  -->  "l:*,a:**,s:**,v:*,e:*,g:*"

*/

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;


namespace CountLettersChallenge;

public class CountLetters
{
    public static string GetStrings(string city)
    {
        var dict = new Dictionary<char, string>();

        string cleaned = city.ToLower().Trim().Replace(" ", "");

        foreach (char c in cleaned)
        {
            if (!dict.ContainsKey(c))
            {
                dict.Add(c, "*");
            }
            else
            {
                dict[c] += "*";
            }
        }

        StringBuilder sb = new StringBuilder();

        foreach (KeyValuePair<char, string> entry in dict)
        {
            sb.Append(entry.Key);
            sb.Append(":");
            sb.Append(entry.Value);
            sb.Append(",");
        }

        return sb.ToString().TrimEnd(',');
    }
}
