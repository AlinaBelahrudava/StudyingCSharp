using Parts;
using Builder;

namespace StudyingTasks
{
    public class AutoParkInit
    {
        private static readonly List<Entity.Transport> AutoPark = new();

        public static List<Entity.Transport> Init()
        {

            Engine XiaomiEngine = new EngineBuilder()
                .SetPower(250)
                .SetVolume(5.1)
                .SetEngineType(EngineType.Electric)
                .SetSerialNumber("XI123456SCOOTER")
                .Build();

            Engine HondaScooterEngine = new EngineBuilder()
               .SetPower(109.51)
               .SetVolume(1)
               .SetEngineType(EngineType.Petrol)
               .SetSerialNumber("HONDA56DF678DSCOOTER")
               .Build();

            Transmission XiaomiTransmission = new TransmissionBuilder()
                .SetTransmissionType(TransmissionType.Automatic)
                .SetTransmissionsNumber(1)
                .SetProducer("XIAOMI")
                .Build();

            Transmission HondaScooterTransmission = new TransmissionBuilder()
               .SetTransmissionType(TransmissionType.Automatic)
               .SetTransmissionsNumber(3)
               .SetProducer("HONDA")
               .Build();

            Chassis XiaomiChassis = new ChassisBuilder()
                .SetWheelsNumber(2)
                .SetNumber("XI123877868769")
                .SetCapacity(300)
                .Build();

            Chassis HondaChassis = new ChassisBuilder()
               .SetWheelsNumber(2)
               .SetNumber("HONDA455586231489")
               .SetCapacity(360)
               .Build();

            Engine MazdaEngine = new EngineBuilder()
               .SetPower(3000)
               .SetVolume(7)
               .SetEngineType(EngineType.Petrol)
               .SetSerialNumber("MAZDA90123456CAR")
               .Build();

            Engine TruckEngine = new EngineBuilder()
               .SetPower(4000)
               .SetVolume(10)
               .SetEngineType(EngineType.Diesel)
               .SetSerialNumber("MAZ56DF678777TRUCK")
               .Build();

            Engine BusEngine = new EngineBuilder()
              .SetPower(4000)
              .SetVolume(6)
              .SetEngineType(EngineType.Diesel)
              .SetSerialNumber("MAZ56389283BUS")
              .Build();

            Transmission MazdaTransmission = new TransmissionBuilder()
                .SetTransmissionType(TransmissionType.Automatic)
                .SetTransmissionsNumber(5)
                .SetProducer("MAZDA")
                .Build();

            Transmission TruckTransmission = new TransmissionBuilder()
               .SetTransmissionType(TransmissionType.Manual)
               .SetTransmissionsNumber(6)
               .SetProducer("MAZ")
               .Build();

            Transmission BusTransmission = new TransmissionBuilder()
               .SetTransmissionType(TransmissionType.CVT)
               .SetTransmissionsNumber(5)
               .SetProducer("MAZ")
               .Build();

            Chassis MazdaChassis = new ChassisBuilder()
                .SetWheelsNumber(4)
                .SetNumber("MAZDA12ccsk23222")
                .SetCapacity(3000)
                .Build();


            Chassis TruckChassis = new ChassisBuilder()
                .SetWheelsNumber(6)
                .SetNumber("MAZ1255dsdsd7979779")
                .SetCapacity(20000)
                .Build();

            Chassis BusChassis = new ChassisBuilder()
                .SetWheelsNumber(8)
                .SetNumber("MAZ15455555588669")
                .SetCapacity(10000)
                .Build();

            AutoPark.Add(TransportFactory.CreateScooter(XiaomiEngine, XiaomiChassis, XiaomiTransmission, true));
            AutoPark.Add(TransportFactory.CreateScooter(HondaScooterEngine, HondaChassis, HondaScooterTransmission, false));
            AutoPark.Add(TransportFactory.CreateCar(MazdaEngine, MazdaChassis, MazdaTransmission, 10, 5));
            AutoPark.Add(TransportFactory.CreateTruck(TruckEngine, TruckChassis, TruckTransmission, false));
            AutoPark.Add(TransportFactory.CreateBus(BusEngine, BusChassis, BusTransmission, 30, 60, true));


            return AutoPark;
        }


    }
}
