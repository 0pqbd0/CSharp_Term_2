using NetworkBuilder;

public class Program
{
    public static int Main(string[] args)
    {
        if (args[0] == "-help")
        {
            Console.WriteLine("""
        This program is for generating the optimal configuration of routers for a given network topology.

        How to use:
        - - - - - - - - - - - - - - - - - - - - - - - - 
        dotnet run [input file path] [output file path]
        (If the path contains spaces -> enclose it in quotes)
        - - - - - - - - - - - - - - - - - - - - - - - - 

        Input file format:
        - - - - - - - - - - - - - - - - - - - - - - - - 
        routerNumber: linkedRouterNumber (throughput), etc....
        - - - - - - - - - - - - - - - - - - - - - - - - 

        """);
            return 0;
        }

        if (args.Length < 2)
        {
            Console.WriteLine("Two arguments are needed.");
            Console.WriteLine("For help, use the command: dotnet run -help");
            return 0;
        }

        if (!File.Exists(args[0]) || !File.Exists(args[1]))
        {
            Console.WriteLine("You entered not existing file.");
            Console.WriteLine("For help, use the command: dotnet run -help");
            return 0;
        }

        var topology = File.ReadAllText(args[0]);

        try
        {
            var configuration = Configuration.BuildClearlyTopology(topology);
            File.WriteAllText(args[1], configuration);
            Console.WriteLine("Done");
            return 0;
        }
        catch (TopologyIsNotConnectedException ex)
        {
            Console.Error.WriteLine(ex.Message);
            Console.WriteLine("For help, use the command: dotnet run -help");
            return 1;
        }
        catch (Exception ex) when (ex is FormatException ||
                                   ex is ArgumentException)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("For help, use the command: dotnet run -help");
            return 1;
        }
    }
}

