using Parts;
using Builder;
using Entity;
using StudyingTasks;
using StudyingTasks.Builder;
using StudyingTasks.Exceptions;
using StudyingTasks.Entities;

class Program
{

    static void Main()
    {
        Transmission? mazdaTransmission = null;
        Chassis? mazdaChassis = null;

        Engine MazdaEngine = new EngineBuilder()
           .SetPower(3000)
           .SetVolume(7)
           .SetEngineType(EngineType.Petrol)
           .SetSerialNumber("MAZDA90123456CAR")
           .Build();

        try
        {
            mazdaTransmission = new TransmissionBuilder()
                .SetTransmissionType(TransmissionType.Automatic)
                .SetTransmissionsNumber(-5)
                .SetProducer("MAZDA")
                .Build();
        }
        catch (InitializationException ex)
        {
            Console.WriteLine(ex.GetType().Name + " " + ex.Message);
        }
        try
        {
            mazdaChassis = new ChassisBuilder()
               .SetWheelsNumber(0)
               .SetNumber("MAZDA12ccsk23222")
               .SetCapacity(3000)
               .Build();
        }
        catch (InitializationException ex)
        {
            Console.WriteLine(ex.GetType().Name + " " + ex.Message);
        }

       
        Transport car = TransportFactory.CreateCar(2, MazdaEngine, mazdaChassis, mazdaTransmission, 2, 5, CarModel.Coupe);
        
       

        List<Transport> transports = AutoParkInit.Init();
        AutoParkManager manager = new AutoParkManager(transports);

        try
        {
            manager.AddTransport(car);
        }
        catch (AddException ex)
        {
            Console.WriteLine(ex.GetType().Name + " " + ex.Message);
        }
        finally
        {
            car.SetID(5);     
        }

        try
        {
            manager.UpdateAuto(car);
        }
        catch (UpdateAutoException ex)
        {
            Console.WriteLine(ex.GetType().Name + " " + ex.Message);
        }
        try
        {
            manager.RemoveAuto(5);
        }
        catch (RemoveAutoException ex)
        {
            Console.WriteLine(ex.GetType().Name + " " + ex.Message);
        }
        manager.AddTransport(car);
        Transport carForUpdate = TransportFactory.CreateCar(5, MazdaEngine, mazdaChassis, mazdaTransmission, 2, 5, CarModel.Sedan);
        manager.UpdateAuto(carForUpdate);
        manager.RemoveAuto(5);

        Console.ReadKey();
    }

}