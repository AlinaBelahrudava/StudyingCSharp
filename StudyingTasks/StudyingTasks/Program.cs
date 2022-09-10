using Parts;
using Builder;
using Entity;
using StudyingTasks;

class Program
{

    static void Main()
    {
        AutoParkInit.Init().ForEach(t => Console.WriteLine(t.ToString()));

   
        Console.ReadKey();
    }

}