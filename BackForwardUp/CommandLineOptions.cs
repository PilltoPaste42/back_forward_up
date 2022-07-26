namespace BackForwardUp
{
    using CommandLine;

    public class CommandLineOptions
    {
        [Option('c', "config",
            Required = false,
            Default = "./backup_config.json",
            HelpText = "Путь к файлу конфигурации")]
        public string ConfigPath { get; set; }
    }
}