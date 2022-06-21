using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using System.Text;

namespace Benchmark
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var results = BenchmarkRunner.Run<Demo>();
        }
    }

    [MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net50)]
    [SimpleJob(RuntimeMoniker.Net60)]
    public class Demo
    {
        [Benchmark]
        public string Creating1000strings()
        {
            string result = "";

            for (int i = 0; i < 1000; i++)
            {
                result += i;
            }

            return result;
        }

        [Benchmark(Baseline = true)]
        public string Creating1000StringBuilder()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 1000; i++)
            {
                sb.Append(i);
            }

            return sb.ToString();
        }
    }
}
