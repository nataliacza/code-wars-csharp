using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Text;

namespace BenchmarkStringBuilder
{
    class Program
    {
        public static void Main(string[] args)
        {
            //var results = BenchmarkRunner.Run<Demo>;
        }

    }

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

        [Benchmark]
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
