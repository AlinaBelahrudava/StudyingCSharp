using Parts;

namespace Entity
{

    public class Car : Transport
    {
        private int AirBagsNumber;
        private int NumberOfSeats;
        public Car(Engine engine, Chassis chassis, Transmission transmission, int airBagsNumber, int numberOfSeats)
        : base(engine, chassis, transmission)
        {
            this.AirBagsNumber = airBagsNumber;
            this.NumberOfSeats = numberOfSeats;
        }

        public int GetAirBagsNumber() => this.AirBagsNumber;
        public int GetNumberOfSeats() => this.NumberOfSeats;
        public override string ToString()
        {
            return this.GetType().Name + ". " + base.ToString() + " Air bags number: " + AirBagsNumber
                + "; number of seats: " + NumberOfSeats + ".\n";
        }
    }
}
