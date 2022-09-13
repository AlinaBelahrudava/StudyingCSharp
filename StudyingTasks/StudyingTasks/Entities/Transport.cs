using Parts;

namespace Entity
{
    public class Transport
    {
        private int ID;
        private Engine Engine;
        private Chassis Chassis;
        private Transmission Transmission;
        public Transport(int id, Engine engine, Chassis chassis, Transmission transmission)
        {
            this.ID = id;
            SetEngine(engine);
            SetChassis(chassis);
            SetTransmission(transmission);
        }

        public override string ToString()
        {
            return "ID: " + ID + ". " + Engine.ToString() + ". " + Chassis.ToString() + ". " + Transmission.ToString() + ".";

        }

        public int GetID() => this.ID;
        public void SetID(int id) => this.ID = id;
        protected void SetEngine(Engine engine) => this.Engine = engine ?? new();

        public Engine GetEngine() => this.Engine;
        protected void SetChassis(Chassis chassis) => this.Chassis = chassis ?? new();

        public Chassis GetChassis() => this.Chassis;

        protected void SetTransmission(Transmission transmission) => this.Transmission = transmission ?? new();

        public Transmission GetTransmission() => this.Transmission;

    }

}