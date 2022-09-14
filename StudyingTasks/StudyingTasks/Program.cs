using StudyingTasks;
using StudyingTasks.Commands;
using System.Text.RegularExpressions;

class Program
{
    public const string Add = "add";
    public const string Count = "count";
    public const string Average = "average";

    static void Main()
    {
        Console.Write("Waiting for command...   ");
        string line = Console.ReadLine();
        string[] commands = ParseCommand(line);
        string command = null;
        if (commands.Length > 0) { command = commands[0]; }
        Administrator administrator = new();
        Catalogue catalogue = Catalogue.GetInstance();
        while (command != "exit")
        {
            switch (command)
            {

                case Add:
                    {
                        Console.Write("Enter brand: ");
                        string brand = Console.ReadLine();
                        Console.Write("Enter model: ");
                        string model = Console.ReadLine();
                        Console.Write("Enter count: ");
                        int count = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter price: ");
                        double price = Convert.ToDouble(Console.ReadLine());
                        AddNewCar addCommand = new(catalogue, brand, model, count, price);
                        administrator.SetCommand(addCommand);
                        administrator.Do();
                        break;
                    }
                case Count:
                    {
                        if (commands.Length > 1)
                        {
                            CountCommand countCommand = new(catalogue, commands[1]);
                            administrator.SetCommand(countCommand);
                            administrator.Do();
                        }
                        else
                        {
                            Console.WriteLine(String.Format("Unsupported command '{0}'", line));
                            Console.WriteLine("Use 'count type' or 'count all'");
                        }
                        break;
                    }
                case Average:
                    {
                        if (commands.Length > 1)
                        {
                            AverageCommand averageCommand = new(catalogue, commands);
                            administrator.SetCommand(averageCommand);
                            administrator.Do();
                        }
                        else
                        {
                            Console.WriteLine(String.Format("Unsupported command '{0}'", line));
                            Console.WriteLine("Use 'average price' or 'average price {brand}'");
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine(String.Format("Unsupported command '{0}'", command));
                        Console.WriteLine("List of supported commands: exit, add, count type, count all");
                        break;
                    }
            }
            Console.Write("Waiting for command...   ");
            line = Console.ReadLine();
            commands = ParseCommand(line);
            if (commands.Length > 0) { command = commands[0]; } else { command = null; }
        }

    }

    public static string[] ParseCommand(string line)
    {
        Regex regex = new Regex(@"\w+");
        MatchCollection matches = regex.Matches(line);
        List<string> parameters = new();
        foreach (var m in matches)
        {
            parameters.Add(m.ToString());
        }
        return parameters.ToArray();
    }
}