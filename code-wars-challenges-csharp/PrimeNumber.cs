
/*
https://www.codewars.com/kata/5262119038c0985a5b00029f/train/csharp

Define a function that takes an integer argument and returns a logical value true or false depending on if the integer is a prime.

Per Wikipedia, a prime number ( or a prime ) is a natural number greater than 1 that has no positive divisors other than 1 and itself.

Requirements
You can assume you will be given an integer input.
You can not assume that the integer will be only positive. You may be given negative numbers as well ( or 0 ).
NOTE on performance: There are no fancy optimizations required, but still the most trivial solutions might time out. Numbers go up to 2^31 ( or similar, depending on language ). Looping all the way up to n, or n/2, will be too slow.
Example
is_prime(1)  / false /
is_prime(2)  / true  /
is_prime(-1) / false /

Preparation:
- natural numbers: positive and is integer only
- prime had EXACTLY 2 dividers: 1 and itself (return true) => counter?
- if given int is positive
- what numbers I can have? 2, 50, 10000000
- modulo?

*/


namespace CheckPrimeNumber;

public class PrimeNumber
{
    public static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        if (number == 2)
        {
            return true;
        }

        if (number % 2 == 0)
        {
            return false;
        }

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
