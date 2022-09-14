using Entity;
using Parts;
using StudyingTasks.Entities;

public class TransportFactory
{
    public TransportFactory()
    {
    }

    public static Transport CreateCar(int id, Engine engine, Chassis chassis, Transmission transmission, int airBagsNumber, int numberOfSeats, CarModel model)
    {
        return new Car(id, engine, chassis, transmission, airBagsNumber, numberOfSeats, model);
    }

    public static Transport CreateScooter(int id, Engine engine, Chassis chassis, Transmission transmission, bool isFoldingDesign)
    {
        return new Scooter(id, engine, chassis, transmission, isFoldingDesign);
    }

    public static Transport CreateTruck(int id, Engine engine, Chassis chassis, Transmission transmission, bool isRefregerator)
    {
        return new Truck(id, engine, chassis, transmission, isRefregerator);
    }

    public static Transport CreateBus(int id, Engine engine, Chassis chassis, Transmission transmission,
        int numberOfSeats, int numberOfPassangers, bool isWCAvailable)
    {
        return new Bus(id, engine, chassis, transmission, numberOfSeats, numberOfPassangers, isWCAvailable);
    }




}
