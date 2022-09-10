namespace Parts
{
    public class Chassis
    {
        private int WheelNumber;
        private string? Number;
        private int Capacity;

        public Chassis()
        {

        }
        public Chassis(int wheelNumber, string number, int capacity)
        {
            SetWheelNumber(wheelNumber);
            SetNumber(number);
            SetCapacity(capacity);
        }

        public void SetWheelNumber(int wheelNumber) => this.WheelNumber = wheelNumber;

        public int GetWhellNumber() => this.WheelNumber;

        public void SetNumber(string number) => this.Number = number ?? String.Empty;

        public string GetNumber() => this.Number ?? String.Empty;

        public void SetCapacity(int capacity) => this.Capacity = capacity;

        public int GetCapacity() => this.Capacity;

        public override string ToString()
        {
            return this.GetType().Name + ". Number of wheels: " + WheelNumber + "; number: " + Number
                + "; capacity: " + Capacity;
        }
    }
}
