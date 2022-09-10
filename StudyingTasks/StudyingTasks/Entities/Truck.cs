
using Parts;

namespace Entity
{

    public class Truck : Transport
    {
        private bool IsRefregerator { get; set; } = false;
        public Truck(Engine engine, Chassis chassis, Transmission transmission, bool isRefregerator)
        : base(engine, chassis, transmission)
        {
            this.IsRefregerator = isRefregerator;
        }

        public override string ToString()
        {
            return this.GetType().Name + ". " + base.ToString() + " Refregerator: " + IsRefregerator + ".\n";
        }
    }
}
