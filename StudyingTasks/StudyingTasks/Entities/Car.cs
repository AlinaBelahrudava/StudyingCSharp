using Parts;
using StudyingTasks.Entities;

namespace Entity
{

    public class Car : Transport
    {
        private CarModel Model;
        private int AirBagsNumber;
        private int NumberOfSeats;
        public Car(int id, Engine engine, Chassis chassis, Transmission transmission, int airBagsNumber, int numberOfSeats, CarModel model)
        : base(id, engine, chassis, transmission)
        {
            this.Model = model;
            this.AirBagsNumber = airBagsNumber;
            this.NumberOfSeats = numberOfSeats;
        }

        public int GetAirBagsNumber() => this.AirBagsNumber;
        public int GetNumberOfSeats() => this.NumberOfSeats;
        public CarModel GetModel() => this.Model;

        public void SetModel(CarModel model) => this.Model = model;
        public override string ToString()
        {
            return this.GetType().Name + ". " + base.ToString() + " Model: " + Model + "; air bags number: " + AirBagsNumber
                + "; number of seats: " + NumberOfSeats + ".\n";
        }
    }
}
