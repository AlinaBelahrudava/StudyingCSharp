using Parts;

namespace Entity
{
    public class Transport
    {
        private Engine Engine;
        private Chassis Chassis;
        private Transmission Transmission;
        public Transport(Engine engine, Chassis chassis, Transmission transmission)
        {
            SetEngine(engine);
            SetChassis(chassis);
            SetTransmission(transmission);
        }

        public override string ToString()
        {
            return Engine.ToString() + ". " + Chassis.ToString() + ". " + Transmission.ToString() + ".";

        }

        protected void SetEngine(Engine engine) => this.Engine = engine ?? new();

        public Engine GetEngine() => this.Engine;
        protected void SetChassis(Chassis chassis) => this.Chassis = chassis ?? new();

        public Chassis GetChassis() => this.Chassis;

        protected void SetTransmission(Transmission transmission) => this.Transmission = transmission ?? new();

        public Transmission GetTransmission() => this.Transmission;

    }

}