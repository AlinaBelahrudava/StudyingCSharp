using Parts;
using Builder;
using Entity;
using StudyingTasks;
using StudyingTasks.Builder;

class Program
{

    static void Main()
    {
        List<Transport> transports = AutoParkInit.Init();
        transports.ForEach(t => Console.WriteLine(t.ToString()));
        List<Transport> selection = new();
        foreach (Transport transport in transports)
        {
            if (1.5 < transport.GetEngine().GetVolume())
            {
                selection.Add(transport);
            }
        }
        List<Transport> busAndTrucks = new();
        foreach (Transport transport in transports)
        {
            if (transport is Bus || transport is Truck)
            {
                busAndTrucks.Add(transport);
            }
        }
        XMLBuilder.WriteFullInformationToXML(selection, "hugeVolume.xml");
        XMLBuilder.WriteEngineInformationToXML(busAndTrucks, "engines.xml");
        XMLBuilder.WriteGroupedByTransmissionInformationToXML(transports, "grouped.xml");
        Console.ReadKey();
    }

}