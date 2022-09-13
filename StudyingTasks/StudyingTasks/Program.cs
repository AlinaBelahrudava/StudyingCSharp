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

        List<Transport> selection = transports.Where(t => 1.5 < t.GetEngine().GetVolume()).ToList();
        List<Transport> busAndTrucks = transports.Where(t => t is Bus || t is Truck).ToList();
        XMLBuilder.WriteFullInformationToXML(selection, "hugeVolume.xml");
        XMLBuilder.WriteEngineInformationToXML(busAndTrucks, "engines.xml");
        XMLBuilder.WriteGroupedByTransmissionInformationToXML(transports, "grouped.xml");
        XMLBuilder.WriteGroupedByTransmissionInformationToXMLUsingGroupBy(transports, "groupedBy.xml");
        Console.ReadKey();
    }

}