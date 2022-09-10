using Parts;
namespace Builder
{
    public class EngineBuilder
    {
        private readonly Engine TransportEngine = new();
        public EngineBuilder()
        {
        }

        public EngineBuilder SetPower(double power)
        {
            TransportEngine.SetPower(power);
            return this;
        }

        public EngineBuilder SetVolume(double volume)
        {
            TransportEngine.SetVolume(volume);
            return this;
        }

        public EngineBuilder SetEngineType(EngineType engineType)
        {
            TransportEngine.SetEngineType(engineType);
            return this;
        }

        public EngineBuilder SetSerialNumber(string serialNumber)
        {
            TransportEngine.SetSerialNumber(serialNumber);
            return this;
        }

        public Engine Build()
        {
            return TransportEngine;
        }

    }
}
