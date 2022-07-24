using System;

namespace BackForwardUp
{
    using CommandLine;

    internal class Program
    {
        static void Main(string[] args)
        {
            var parameters = Parser.Default
                .ParseArguments<CommandLineOptions>(args).Value;

            Console.WriteLine(parameters.Alpha);
            Console.WriteLine(parameters.Beta);
        }
    }
}
