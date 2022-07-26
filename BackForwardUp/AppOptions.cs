namespace BackForwardUp
{
    using System.Collections.Generic;

    using CommandLine;

    public class AppOptions
    {
        public AppOptions()
        {
        }

        public AppOptions(AppOptions main, AppOptions additional)
        {
            ConfigPath = main.ConfigPath ?? additional.ConfigPath;
            Debug = main.Debug ?? additional.Debug;
            Storage = main.Storage ?? additional.Storage;
            Targets = main.Targets ?? additional.Targets;
        }

        [Option('c', "config",
            Required = false,
            Default = "./backup_config.json",
            HelpText = "Путь к файлу конфигурации")]
        public string ConfigPath { get; set; }

        [Option('d', "debug")]
        public bool? Debug { get; set; }

        [Option('s', "storage")]
        public string Storage { get; set; }

        [Option('t', "targets")]
        public IEnumerable<string> Targets { get; set; }
    }
}