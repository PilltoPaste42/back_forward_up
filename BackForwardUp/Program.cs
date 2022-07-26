namespace BackForwardUp
{
    using System.IO;

    using CommandLine;

    using Newtonsoft.Json;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var consoleOptions = Parser.Default
                .ParseArguments<AppOptions>(args).Value;

            var json = File.ReadAllText(consoleOptions.ConfigPath);
            var configOptions = JsonConvert.DeserializeObject<AppOptions>(json);

            var appOptions = new AppOptions(consoleOptions, configOptions);
        }
    }
}