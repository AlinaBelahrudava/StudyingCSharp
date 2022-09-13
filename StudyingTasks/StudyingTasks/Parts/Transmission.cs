using StudyingTasks.Exceptions;

namespace Parts
{
    public class Transmission

    {
        private TransmissionType TransmissionType;
        private int TransmissionsNumber;
        private string? Producer;

        public Transmission()
        {

        }
        public Transmission(TransmissionType transmissionType, int transmissionsNumber, string producer)
        {
            SetTransmissionType(transmissionType);
            SetTransmissionsNumber(transmissionsNumber);
            SetProducer(producer);
        }

        public void SetTransmissionType(TransmissionType transmissionType) => this.TransmissionType = transmissionType;


        public TransmissionType GetTransmissionType() => this.TransmissionType;


        public void SetTransmissionsNumber(int transmissionsNumber)
        {
            if (transmissionsNumber < 1)
            {
                throw new InitializationException("Incorrect data. Transmissions number cannot be less than 1");
            }
            this.TransmissionsNumber = transmissionsNumber;
        }


        public int GetTransmissionNumber() => this.TransmissionsNumber;

        public void SetProducer(string producer) => this.Producer = producer ?? String.Empty;


        public string GetProducer() => this.Producer ?? String.Empty;

        public override string ToString()
        {
            return this.GetType().Name + ". Transmission type: " + TransmissionType + "; number of transmissions: "
                + TransmissionsNumber + "; producer: " + Producer;
        }
    }
}
