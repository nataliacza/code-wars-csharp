using System;

/*
link: https://www.codewars.com/kata/551f23362ff852e2ab000037/csharp

set counter?
count nr of lists? hight?
if max in each list is selected, it will not be nearest to previous number
set variable for index and than +-1?
binary tree?
start from end?

          10
         1  50
       1  10  20
    1000  1  1  1   

*/

namespace PyramidSlide;

public class PyramidSlideDown
{
    public static int LongestSlideDown(int[][] pyramid)
    {
        int pyramidLength = pyramid.Length;

        if (pyramid.Length == 0)
        {
            return 0;
        }

        if (pyramid.Length == 1)
        {
            return pyramid[0][0];
        }

        int oneAbove = pyramidLength - 2;

        for (int row = oneAbove; row >= 0; row--)
        {
            for (int index = 0; index < pyramid[row].Length; index++)
            {
                int left = pyramid[row + 1][index];
                int right = pyramid[row + 1][index + 1];
                int currentCheck = pyramid[row][index];

                if (left > right)
                {
                    currentCheck += left;
                    pyramid[row][index] = currentCheck;
                }
                else
                {
                    currentCheck += right;
                    pyramid[row][index] = currentCheck;
                }
            }
        }
     
        return pyramid[0][0];
    }

}
