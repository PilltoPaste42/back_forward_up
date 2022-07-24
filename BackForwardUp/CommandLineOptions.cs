namespace BackForwardUp
{
    using CommandLine;

    public class CommandLineOptions
    {
        [Option('a', "alpha", Required = false, HelpText = "Alpha")]
        public string Alpha { get; set; }

        [Option('b', "beta", Required = false, HelpText = "Beta")]
        public string Beta { get; set; }

    }
}