

namespace StudyingTasks
{
    internal class Drone : FlyingObject
    {
        public const double MovingTime = 10.0 / 60.0;
        public const double HangingTime = 1.0 / 60.0;
        public const int Speed = 60;
        public const int MaxPath = 1000;

        public Drone(Coordinate coordinate) : base(coordinate)
        {
        }

        public override void FlyTo(Coordinate newPoint)
        {// if path exceed max there is no motion
            if (GetPath(newPoint) > MaxPath)
            {
                SetIsFlySuccessful(false);
            }
            else
            {
                SetCurrentSpeed(Speed);
                SetIsFlySuccessful(true);
            }

        }

        public override double GetFlyTime(Coordinate newPoint)
        {
            double path = GetPath(newPoint);
            // if speed is 0 then there is no motion and flying time is equal to 0.
            if (0 == GetCurrentSpeed() || path > MaxPath) { return 0; }
            else
            {
                double flyingTime = path / GetCurrentSpeed();
                double hangingCount = Math.Floor(flyingTime / MovingTime);
                flyingTime += hangingCount * HangingTime;
                return flyingTime;
            }
        }
    }
}
