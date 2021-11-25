using System;
using System.Threading;
using TestGenerator;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new NUnitTestGenerator(10, 10, 10);
            generator.GenerateTestsAsync(@"C:\Users\yug77_bd0zewu\Documents\GitHub\Spp-4\ConsoleApp\input",
                @"C:\Users\yug77_bd0zewu\Documents\GitHub\Spp-4\ConsoleApp\output").Wait();
        }
    }
}