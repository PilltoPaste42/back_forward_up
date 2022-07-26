namespace BackForwardUp
{
    using System;
    using System.IO;

    using CommandLine;

    using Newtonsoft.Json;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var parameters = Parser.Default
                .ParseArguments<CommandLineOptions>(args).Value;

            var json = File.ReadAllText(parameters.ConfigPath);
            var config = JsonConvert.DeserializeObject<BackupParameters>(json);

            Console.WriteLine(config.Hello);
        }
    }
}