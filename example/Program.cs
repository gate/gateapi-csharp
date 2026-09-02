using System;
using CommandLine;

namespace GateApiDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Keep demo selection explicit so examples never execute a trading flow by default.
            Parser.Default.ParseArguments<RunConfig>(args).WithParsed(config =>
            {
                switch (config.Demo)
                {
                    case "spot":
                        new SpotDemo(config).Run();
                        break;
                    case "margin":
                        new MarginDemo(config).Run();
                        break;
                    case "futures":
                        new FuturesDemo(config).Run();
                        break;
                    default:
                        Console.Error.WriteLine("incorrect demo provided. Available: spot, margin or futures");
                        break;
                }
            });
        }
    }
}
