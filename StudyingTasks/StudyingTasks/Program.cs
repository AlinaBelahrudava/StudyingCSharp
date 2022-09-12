

using StudyingTasks;

class Program
{

    static void Main()
    {
        Coordinate A = new() { X = 0, Y = 0, Z = 0 };
        Coordinate B = new() { X = 700, Y = 0, Z = 0 };

        Bird bird = new(A);
        bird.FlyTo(B);
        Console.WriteLine("Bird flying time: {0} hours", String.Format("{0:0.##}", bird.GetFlyTime(B)));

        Plane plane = new(A);
        plane.FlyTo(B);
        Console.WriteLine("Plane flying time: {0} hours", String.Format("{0:0.##}", plane.GetFlyTime(B)));


        Drone drone = new(A);
        drone.FlyTo(B);
        Console.WriteLine("Drone flying time: {0} hours", String.Format("{0:0.##}", drone.GetFlyTime(B)));

        Console.ReadKey();
    }

}