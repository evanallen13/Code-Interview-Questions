using System;
using LeetCode.DataStuctures;
using LeetCode.SortingAlgos;
using System.Linq;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter file = new StreamWriter("WriteLines2.txt", append: true);
            for (int i = 0; i < 5; i += 5)
            {
                for (int e = 0; e < 5; e++)
                {
                    var watch = new Stopwatch();
                    watch.Start();
                    FizzBuzz.fizzBuzz(i);
                    watch.Stop();
                    var fb1 = watch.ElapsedMilliseconds;

                    var watch2 = new Stopwatch();
                    watch2.Start();
                    FizzBuzz.fizzBuzz2(i);
                    watch2.Stop();
                    var fb2 = watch2.ElapsedMilliseconds;

                    file.WriteLine($"{i},{fb1},{fb2}");
                }
            }

            file.Close();
        }
    }
}
