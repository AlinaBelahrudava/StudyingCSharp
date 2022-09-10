
using Parts;

namespace Entity
{
    public class Bus : Transport
    {
        private int NumberOfSeats { get; set; } = 0;
        private int NumberOfPassangers { get; set; } = 0;

        private bool IsWCAvailable { get; set; } = false;
        public Bus(Engine engine, Chassis chassis, Transmission transmission, int numberOfSeats,
            int numberOfPassangers, bool isWCAvailable)
        : base(engine, chassis, transmission)
        {
            this.NumberOfSeats = numberOfSeats;
            this.NumberOfPassangers = numberOfPassangers;
            this.IsWCAvailable = isWCAvailable;
        }

        public override string ToString()
        {
            return this.GetType().Name + ". " + base.ToString() + " number of seats: " + NumberOfSeats
                + "; number of passangers: " + NumberOfPassangers + "; WC availability: " + IsWCAvailable + ".\n";
        }
    }
}
