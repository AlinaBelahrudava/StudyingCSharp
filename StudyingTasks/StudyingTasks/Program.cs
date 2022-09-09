using System;

class Program
{

    static void Main(string[] args)
    {

        Console.WriteLine("Please enter your string and I will find the longest sequence of unique ones");
        string? Line = Console.ReadLine();
        string Sequence = String.Empty;

        if (!String.IsNullOrEmpty(Line))
        {
            string Subsequence = String.Empty;
            for (int i = 0; i < Line.Length; i++)
            {
                if (!Subsequence.Contains(Line[i]))
                {
                    Subsequence += Line[i];
                    if (Subsequence.Length > Sequence.Length)
                    {
                        Sequence = Subsequence;
                    }
                }
                else
                {
                    //Step back to set repeting symbol Line[i] into new subsequence
                    i--;
                    Subsequence = String.Empty;
                }

            }
            Console.WriteLine("The longest sequence of unique symbols is: \"" + Sequence + "\"");

        }
        else
        {
            Console.WriteLine("String is null or emty");
        }

        Console.ReadKey();
    }

}