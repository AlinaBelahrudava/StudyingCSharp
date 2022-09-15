using StudyingTasks.StringAnalysys;


public class Program
{

    public static void Main()
    {

        Console.WriteLine("Please enter your string and I will find the longest sequence of unique ones");
        string? line = Console.ReadLine();
        StringAnalyzer stringAnalizer = new();
        stringAnalizer.GetMaxUniqueSequence(line);
        Console.Write("Max sequence of the same letters: ");
        Console.WriteLine(stringAnalizer.GetMaxSameLettersSequence(line));
        Console.Write("Max sequence of the same digits: ");
        Console.WriteLine(stringAnalizer.GetMaxSameDigitsSequence(line));




        Console.ReadKey();
    }

}