using Parts;
namespace Builder
{
    public class TransmissionBuilder
    {
        private readonly Transmission TransportTransmission = new();
        public TransmissionBuilder()
        {
        }

        public TransmissionBuilder SetTransmissionsNumber(int transmissionsNumber)
        {
            TransportTransmission.SetTransmissionsNumber(transmissionsNumber);
            return this;
        }

        public TransmissionBuilder SetTransmissionType(TransmissionType transmissionType)
        {
            TransportTransmission.SetTransmissionType(transmissionType);
            return this;
        }

        public TransmissionBuilder SetProducer(string producer)
        {
            TransportTransmission.SetProducer(producer);
            return this;
        }

        public Transmission Build()
        {
            return TransportTransmission;
        }

    }
}
