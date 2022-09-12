
namespace StudyingTasks
{
    public abstract class FlyingObject : IFlyable
    {
        private int CurrentSpeed;
        private bool IsFlySuccessful = false;
        protected Coordinate CurrentPoint;

        protected FlyingObject(Coordinate coordinate)
        {
            this.CurrentPoint = coordinate;
            this.CurrentSpeed = 0;
        }
        public abstract void FlyTo(Coordinate newPoint);
        public abstract double GetFlyTime(Coordinate newPoint);

        /* Method GetPath return path between two 3D points using te following formula
        AB = √(xb — xa)2 + (yb — ya)2 + (zb — za)2
        */
        protected double GetPath(Coordinate newPoint)
        {
            return Math.Sqrt(Math.Pow(newPoint.X - CurrentPoint.X, 2) + Math.Pow(newPoint.Y - CurrentPoint.Y, 2)
                 + Math.Pow(newPoint.Z - CurrentPoint.Z, 2));

        }

        protected int GetCurrentSpeed() => this.CurrentSpeed;
        protected void SetCurrentSpeed(int newSpeed) => this.CurrentSpeed = newSpeed;
        protected bool GetIsFlySuccessful() => this.IsFlySuccessful;
        protected void SetIsFlySuccessful(bool isFlySuccessful)
        {
            this.IsFlySuccessful = isFlySuccessful;
            Console.WriteLine("Fly successfully: " + IsFlySuccessful);
        }
    }
}
