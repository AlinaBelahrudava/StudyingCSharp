
using Parts;

namespace Entity
{

    public class Scooter : Transport
    {
        private bool IsFoldingDesign;
        public Scooter(Engine engine, Chassis chassis, Transmission transmission, bool isFoldingDesign)
        : base(engine, chassis, transmission)
        {
            this.IsFoldingDesign = isFoldingDesign;
        }

        public bool GetIsFoldingDesign() => this.IsFoldingDesign;

        public override string ToString()
        {
            return this.GetType().Name + ". " + base.ToString() + " Folding design: " + IsFoldingDesign + ".\n";
        }
    }
}
