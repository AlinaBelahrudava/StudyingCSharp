using Parts;

namespace Entity
{

    public class Car : Transport
    {
        private int AirBagsNumber { get; set; } = 0;
        private int NumberOfSeats { get; set; } = 0;
        public Car(Engine engine, Chassis chassis, Transmission transmission, int airBagsNumber, int numberOfSeats)
        : base(engine, chassis, transmission)
        {
            this.AirBagsNumber = airBagsNumber;
            this.NumberOfSeats = numberOfSeats;
        }

        public override string ToString()
        {
            return this.GetType().Name + ". " + base.ToString() + " Air bags number: " + AirBagsNumber
                + "; number of seats: " + NumberOfSeats + ".\n";
        }
    }
}
