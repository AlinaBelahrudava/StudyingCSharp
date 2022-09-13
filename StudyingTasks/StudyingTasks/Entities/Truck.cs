
using Parts;

namespace Entity
{

    public class Truck : Transport
    {
        private bool IsRefregerator;
        public Truck(int id, Engine engine, Chassis chassis, Transmission transmission, bool isRefregerator)
        : base(id, engine, chassis, transmission)
        {
            this.IsRefregerator = isRefregerator;
        }

        public bool GetIsRefregerator() => this.IsRefregerator;
        public override string ToString()
        {
            return this.GetType().Name + ". " + base.ToString() + " Refregerator: " + IsRefregerator + ".\n";
        }
    }
}
