
using System;
using System.Text;

class Program
{
    static Dictionary<double, String> Pair = new Dictionary<double, string>();
    static void Main()

    {
        Pair.Add(10, "A");
        Pair.Add(11, "B");
        Pair.Add(12, "C");
        Pair.Add(13, "D");
        Pair.Add(14, "E");
        Pair.Add(15, "F");
        Pair.Add(16, "G");
        Pair.Add(17, "H");
        Pair.Add(18, "I");
        Pair.Add(19, "J");
        int Number = 0;
        int Base = 0; ;
        string NewRepresentation = String.Empty;

        Console.WriteLine("Welcome to numbers system calculator.");
        EnterDecimalNumber(ref Number);
        EnterBase(ref Base);
        Calculate(Number, Base, ref NewRepresentation);
        Console.WriteLine("Result: " + NewRepresentation);
        Console.WriteLine("Number {0} in decimal system equals to {1} in the number system with base {2}",
            Number, NewRepresentation, Base);
        Console.WriteLine(Environment.NewLine + "Press any key to exit");
        Console.ReadKey();
    }

    static void Calculate(int _number, int _base, ref string _newRepresentation)
    {
        int nextNumber = _number / _base;
        double remainder = _number % _base;
        if (remainder > 9)
        {
            _newRepresentation += Pair.GetValueOrDefault(remainder);
        }
        else
        {
            _newRepresentation += remainder;
        }
        if (0 != nextNumber)
        {
            Calculate(nextNumber, _base, ref _newRepresentation);
        }
        else
        {
            char[] _representationArray = _newRepresentation.ToCharArray();
            _newRepresentation = new String(_representationArray.Reverse().ToArray());

        }
    }

    static void EnterDecimalNumber(ref int number)
    {
        Console.WriteLine("Please enter decimal number for convertation:");
        String? StringNumber = Console.ReadLine();
        try
        {
            number = Convert.ToInt32(StringNumber);
        }
        catch (FormatException exception)
        {
            Console.WriteLine("Invalid data. Decimal number only accepted");
            Console.WriteLine(exception.Message);
            Console.WriteLine("Please try again");
            EnterDecimalNumber(ref number);
        }
        catch (OverflowException exception)
        {
            Console.WriteLine("Invalid data. Number is too big. Int32 only accepted");
            Console.WriteLine(exception.Message);
            Console.WriteLine("Please try again");
            EnterDecimalNumber(ref number);
        }


    }

    static void EnterBase(ref int _base)
    {
        Console.Write("Please enter base from 2 to 20:");
        String? StringBase = Console.ReadLine();
        try
        {
            _base = Convert.ToInt32(StringBase);
            if (2 > _base || 20 < _base)
            {
                Console.WriteLine("Base values 2..20 can be accepted. Please try again");
                EnterBase(ref _base);
            }
        }
        catch (FormatException exception)
        {
            Console.WriteLine("Invalid data. Decimal number only accepted");
            Console.WriteLine(exception.Message);
            Console.WriteLine("Please try again");
            EnterBase(ref _base);
        }

        catch (OverflowException exception)
        {
            Console.WriteLine("Invalid data. Number is too big. Base values 2..20 can be accepted.");
            Console.WriteLine(exception.Message);
            Console.WriteLine("Please try again");
            EnterBase(ref _base);
        }
    }


}
