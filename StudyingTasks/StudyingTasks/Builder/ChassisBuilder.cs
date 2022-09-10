using Parts;
namespace Builder
{
    public class ChassisBuilder
    {
        private readonly Chassis TransportChassis = new();
        public ChassisBuilder()
        {
        }

        public ChassisBuilder SetCapacity(int capacity)
        {
            TransportChassis.SetCapacity(capacity);
            return this;
        }

        public ChassisBuilder SetWheelsNumber(int wheelsNumber)
        {
            TransportChassis.SetWheelNumber(wheelsNumber);
            return this;
        }

        public ChassisBuilder SetNumber(string number)
        {
            TransportChassis.SetNumber(number);
            return this;
        }

        public Chassis Build()
        {
            return TransportChassis;
        }

    }
}
