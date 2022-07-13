using BenchmarkDotNet.Running;
using CountLettersChallenge;
using MovingZerosToTheEnd;

namespace MainProgram;

class Program
{
    public static void Main(string[] args)
    {
        //var results = BenchmarkRunner.Run<MoveZeroClass>();

        var checkLetters = CountLetters.GetStrings("Las Vegas");
        Console.WriteLine(checkLetters);
    }
}
