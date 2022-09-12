using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyingTasks
{
    internal class Bird : FlyingObject
    {
        //Constant value for MAX speed
        public static int MaxSpeed = 20;
        public static int MaxTime = 6;

        public Bird(Coordinate coordinate) : base(coordinate)
        {
        }

        // Method return random speed value from 1 to max
        private int GetRandomFlyingSpeed() => new Random().Next(1, MaxSpeed + 1);

        // Bird starts flying with new random speed
        public override void FlyTo(Coordinate newPoint)
        {
            SetCurrentSpeed(GetRandomFlyingSpeed());
            //if flying time exceeds max value then there is no motion
            if (GetFlyTime(newPoint) > MaxTime)
            {
                SetIsFlySuccessful(false);
                SetCurrentSpeed(0);
            }
            else
            {
                SetIsFlySuccessful(true);
            }
        }
        //As speed is constant value, so time calculates with formula t = S/v
        //if speed is 0, there is no motion and return 0
        public override double GetFlyTime(Coordinate newPoint)
        {
            return 0 != GetCurrentSpeed() ? GetPath(newPoint) / GetCurrentSpeed() : 0;
        }
    }
}
