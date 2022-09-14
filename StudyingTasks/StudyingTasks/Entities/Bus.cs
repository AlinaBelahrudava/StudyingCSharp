
using Parts;

namespace Entity
{
    public class Bus : Transport
    {
        private int NumberOfSeats;
        private int NumberOfPassangers;
        private bool IsWCAvailable;
        public Bus(int id, Engine engine, Chassis chassis, Transmission transmission, int numberOfSeats,
            int numberOfPassangers, bool isWCAvailable)
        : base(id, engine, chassis, transmission)
        {
            this.NumberOfSeats = numberOfSeats;
            this.NumberOfPassangers = numberOfPassangers;
            this.IsWCAvailable = isWCAvailable;
        }

        public int GetNumberOfSeats() => this.NumberOfSeats;
        public int GetNumberOfPassangers() => this.NumberOfPassangers;

        public bool GetIsWCAvailable() => this.IsWCAvailable;

        public override string ToString()
        {
            return this.GetType().Name + ". " + base.ToString() + " number of seats: " + NumberOfSeats
                + "; number of passangers: " + NumberOfPassangers + "; WC availability: " + IsWCAvailable + ".\n";
        }
    }
}
