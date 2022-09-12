
namespace StudyingTasks
{
    internal class Plane : FlyingObject
    {
        //Constant value for start speed.
        public static int StartSpeed = 200;
        //Max speed limit
        public static int MaxSpeed = 900;
        public static int SpeedChangeStep = 10;
        public static int SpeedChangePath = 10;
        //plane can fly while speed can be excided to max value.
        //in other words this plane cannot fly with constant speed.
        public static int MaxPath = (MaxSpeed - StartSpeed) / SpeedChangeStep * SpeedChangePath;

        public Plane(Coordinate coordinate) : base(coordinate)
        {
        }

        public override void FlyTo(Coordinate newPoint)
        {
            double path = GetPath(newPoint);
            if (path > MaxPath)
            {
                SetIsFlySuccessful(false);
            }
            else
            {
                if (GetCurrentSpeed() < StartSpeed)
                {
                    SetCurrentSpeed(StartSpeed);
                }
                int speed = GetCurrentSpeed();
                while (path / SpeedChangePath > 1 && speed <= MaxSpeed)
                {
                    speed = GetCurrentSpeed() + SpeedChangeStep;
                    SetCurrentSpeed(speed);
                    path -= SpeedChangePath;
                }
                SetIsFlySuccessful(true);
            }
        }

        public override double GetFlyTime(Coordinate newPoint)
        {
            double path = GetPath(newPoint);
            // if speed is 0 then there is no motion and flying time is equal to 0.
            //Or path is more than max then return 0.
            if (0 == GetCurrentSpeed() || path > MaxPath) { return 0; }
            int speed = GetCurrentSpeed();
            double flyingTime = (path % SpeedChangePath) / speed;
            while (path / SpeedChangePath > 1)
            {
                speed -= SpeedChangeStep;
                flyingTime += (double)SpeedChangeStep / (double)speed;
                path -= SpeedChangePath;
            }

            return flyingTime;
        }
    }
}
