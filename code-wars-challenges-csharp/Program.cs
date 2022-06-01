using IPValidation;
using PyramidSlide;
using CheckPrimeNumber;
using PersistentBuggerChallenge;

class Program
{
    public static void Main(string[] args)
    {
        var ipCheck5 = Kata.is_valid_IP_mine("1.1.1");
        var ipCheck6 = Kata.is_valid_IP_mine("1.1.1..1");
        var ipCheck7 = Kata.is_valid_IP_mine("123.456.789.321");
        var ipCheck8 = Kata.is_valid_IP_mine("abc.456.789.321");
        var ipCheck9 = Kata.is_valid_IP_mine("123.456.789.abc");

        Console.WriteLine(ipCheck9);



        var oneElement = new[]
        {
            new[] {100}
        };

        var smallPyramid = new[]
        {
            new[]       {3},
            new[]      {7, 4},
            new[]     {2, 4, 6},
            new[]   {8, 5, 9, 3}
        };
        // 9,4,7,3 = 23

        var result = PyramidSlideDown.LongestSlideDown(smallPyramid);
        
        Console.WriteLine(result);

        


        int givenNumber = 2;

        var checkPrime = PrimeNumber.IsPrime(givenNumber);

        Console.WriteLine(checkPrime);



        int persBugger = 35;

        var persistentBugger = Persist.Persistence(persBugger);

        Console.WriteLine(persistentBugger);

    }
}
