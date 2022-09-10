
using Parts;

namespace Entity
{

    public class Scooter : Transport
    {
        private bool IsFoldingDesign { get; set; } = true;
        public Scooter(Engine engine, Chassis chassis, Transmission transmission, bool isFoldingDesign)
        : base(engine, chassis, transmission)
        {
            this.IsFoldingDesign = isFoldingDesign;
        }

        public override string ToString()
        {
            return this.GetType().Name + ". " + base.ToString() + " Folding design: " + IsFoldingDesign + ".\n";
        }
    }
}
