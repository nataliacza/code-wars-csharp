using BenchmarkDotNet.Running;
using MovingZerosToTheEnd;

namespace MainProgram;

class Program
{
    public static void Main(string[] args)
    {
        var results = BenchmarkRunner.Run<MoveZeroClass>();
    }
}
