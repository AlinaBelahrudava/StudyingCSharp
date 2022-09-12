

namespace StudyingTasks
{
    interface IFlyable
    {
        public void FlyTo(Coordinate newPoint);
        public double GetFlyTime(Coordinate newPoint);
    }
}
