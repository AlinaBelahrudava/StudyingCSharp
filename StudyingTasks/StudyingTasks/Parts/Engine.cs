namespace Parts
{
    public class Engine
    {

        private double Power;
        private double Volume;
        private EngineType EngineType;
        private string? SerialNumber;

        public Engine()
        {

        }

        public Engine(double power, double volume, EngineType engineType, string serialNumber)
        {
            SetPower(power);
            SetVolume(volume);
            SetEngineType(engineType);
            SetSerialNumber(serialNumber);
        }

        public void SetPower(double power) => this.Power = power;

        public double GetPower() => this.Power;

        public void SetVolume(double volume) => this.Volume = volume;

        public double GetVolume() => this.Volume;

        public void SetEngineType(EngineType engineType) => this.EngineType = engineType;

        public EngineType GetEngineType() => this.EngineType;

        public void SetSerialNumber(string serialNumber) => this.SerialNumber = serialNumber ?? String.Empty;

        public string GetSerialNumber() => this.SerialNumber ?? String.Empty;
        public override string ToString()
        {
            return this.GetType().Name + ". Capacity: " + Power + "; volume: " + Volume + "; engine type: "
                + EngineType + "; serial number: " + SerialNumber;
        }
    }
}
