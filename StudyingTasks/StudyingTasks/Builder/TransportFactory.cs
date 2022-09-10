using Entity;
using Parts;
public class TransportFactory
{
    public TransportFactory()
    {
    }

    public static Transport CreateCar(Engine engine, Chassis chassis, Transmission transmission, int airBagsNumber, int numberOfSeats)
    {
        return new Car(engine, chassis, transmission, airBagsNumber, numberOfSeats);
    }

    public static Transport CreateScooter(Engine engine, Chassis chassis, Transmission transmission, bool isFoldingDesign)
    {
        return new Scooter(engine, chassis, transmission, isFoldingDesign);
    }

    public static Transport CreateTruck(Engine engine, Chassis chassis, Transmission transmission, bool isRefregerator)
    {
        return new Truck(engine, chassis, transmission, isRefregerator);
    }

    public static Transport CreateBus(Engine engine, Chassis chassis, Transmission transmission,
        int numberOfSeats, int numberOfPassangers, bool isWCAvailable)
    {
        return new Bus(engine, chassis, transmission, numberOfSeats, numberOfPassangers, isWCAvailable);
    }




}
