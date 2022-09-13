using Entity;
using System.Xml.Linq;
using System.Xml.XPath;

namespace StudyingTasks.Builder
{
    internal class XMLBuilder
    {
        public const string TransmissionTypeXPath = "./transport/transmission/type";
        public const string TransportByTransmissionTypeXPath = "./transport/transmission[type='{0}']/parent::transport";
        public const string TransmissionTag = "transmission";
        public const string TransmissionsTag = "transmissions";
        public const string AutoparkTag = "autopark";
        public const string TransmissionTypeTag = "transmission_type";
        public const string TransportTag = "transport";
        public const string NameAttribute = "name";
        public const string EngineTag = "engine";
        public const string PowerTag = "power";
        public const string VolumeTag = "volume";
        public const string TypeTag = "type";
        public const string ChassisTag = "chassis";
        public const string CapacityTag = "capacity";
        public const string WheelsTag = "wheels";
        public const string SerialNumberTag = "serial_number";
        public const string NumberTag = "number";
        public const string RefregeratgorTag = "refregerator";
        public const string WCTag = "wc";
        public const string SeatsTag = "seats";
        public const string PassangersTag = "passangers";
        public const string TransmissionsNumberTag = "transmissions_number";
        public const string AirBagTag = "air_bags";
        public const string ProducerTag = "producer";
        public const string FoldingDesignTag = "folding_design";
        public static void WriteFullInformationToXML(List<Transport> autopark, string fileName)
        {
            XDocument xDocument = CreateXmlWithFullInformation(autopark);
            xDocument.Save(fileName);
        }

        public static void WriteGroupedByTransmissionInformationToXML(List<Transport> autopark, string fileName)
        {
            XDocument xDocument = CreateXmlWithFullInformation(autopark);
            XDocument xTransmissionsGroupDoc = new();
            XElement xRoot = new(TransmissionsTag);
            xTransmissionsGroupDoc.Add(xRoot);
            List<string> types = new();
            XElement? xAutoPark = xDocument.Element(AutoparkTag);

            if (null != xAutoPark)
            {

                IEnumerable<XElement> xTypes = xAutoPark.XPathSelectElements(TransmissionTypeXPath);
                foreach (XElement xType in xTypes)
                {
                    if (!types.Contains(xType.Value))
                    {
                        types.Add(xType.Value);
                    }
                }
                foreach (string type in types)
                {
                    XElement xTransmissionType = new(TransmissionTypeTag);
                    XAttribute xName = new(NameAttribute, type);
                    xTransmissionType.Add(xName);
                    IEnumerable<XElement> xGroup = xAutoPark.XPathSelectElements(String.Format(TransportByTransmissionTypeXPath, type));
                    foreach (XElement xelement in xGroup)
                    {
                        xTransmissionType.Add(xelement);
                    }
                    xRoot.Add(xTransmissionType);
                }
            }
            xTransmissionsGroupDoc.Save(fileName);
        }

        public static void WriteEngineInformationToXML(List<Transport> autopark, string fileName)
        {
            XDocument xdocument = new();
            XElement xautopark = new(AutoparkTag);
            foreach (Transport transport in autopark)
            {
                XElement xtransport = new(TransportTag);
                XAttribute xtransportName = new(NameAttribute, transport.GetType().Name);
                xtransport.Add(xtransportName);
                xtransport.Add(BuildEngineElement(transport));
                xautopark.Add(xtransport);
            }

            xdocument.Add(xautopark);
            xdocument.Save(fileName);
        }

        private static XDocument CreateXmlWithFullInformation(List<Transport> autopark)
        {
            XDocument xDocument = new();
            XElement xAutoPark = new(AutoparkTag);
            foreach (Transport transport in autopark)
            {
                string name = transport.GetType().Name;
                XElement xtransport = new(TransportTag);
                XAttribute xtransportName = new(NameAttribute, name);
                xtransport.Add(xtransportName);

                if (transport is Scooter)
                {
                    XElement xFoldingDesign = new(FoldingDesignTag, (transport as Scooter).GetIsFoldingDesign());
                    xtransport.Add(xFoldingDesign);
                }
                else if (transport is Bus)
                {
                    XElement xNumberOfSeats = new(SeatsTag, (transport as Bus).GetNumberOfSeats());
                    xtransport.Add(xNumberOfSeats);
                    XElement xNumberOfPassangers = new(PassangersTag, (transport as Bus).GetNumberOfPassangers());
                    xtransport.Add(xNumberOfPassangers);
                    XElement xIsWCAvailable = new(WCTag, (transport as Bus).GetIsWCAvailable());
                    xtransport.Add(xIsWCAvailable);
                }
                else if (transport is Car)
                {
                    XElement xAirBagsNumber = new(AirBagTag, (transport as Car).GetAirBagsNumber());
                    xtransport.Add(xAirBagsNumber);
                    XElement xNumberOfSeats = new(SeatsTag, (transport as Car).GetNumberOfSeats());
                    xtransport.Add(xNumberOfSeats);

                }
                else if (transport is Truck)
                {
                    XElement xIsRefregerator = new(RefregeratgorTag, (transport as Truck).GetIsRefregerator());
                    xtransport.Add(xIsRefregerator);
                }

                xtransport.Add(BuildEngineElement(transport));
                xtransport.Add(BuildChassisElement(transport));
                xtransport.Add(BuildTransmissionElement(transport));

                xAutoPark.Add(xtransport);
            }

            xDocument.Add(xAutoPark);
            return xDocument;
        }
        private static XElement BuildEngineElement(Transport transport)
        {
            XElement xEngine = new(EngineTag);
            XElement xEnginePower = new(PowerTag, transport.GetEngine().GetPower());
            xEngine.Add(xEnginePower);
            XElement xEngineVolume = new(VolumeTag, transport.GetEngine().GetVolume());
            xEngine.Add(xEngineVolume);
            XElement xEngineType = new(TypeTag, transport.GetEngine().GetEngineType());
            xEngine.Add(xEngineType);
            XElement xEngineSerialNumber = new(SerialNumberTag, transport.GetEngine().GetSerialNumber());
            xEngine.Add(xEngineSerialNumber);
            return xEngine;
        }

        private static XElement BuildChassisElement(Transport transport)
        {
            XElement xChassis = new(ChassisTag);
            XElement xChassisWheelsNumber = new(WheelsTag, transport.GetChassis().GetWhellNumber());
            xChassis.Add(xChassisWheelsNumber);
            XElement xChassisNumber = new(NumberTag, transport.GetChassis().GetNumber());
            xChassis.Add(xChassisNumber);
            XElement xChassisCapacity = new(CapacityTag, transport.GetChassis().GetCapacity());
            xChassis.Add(xChassisCapacity);
            return xChassis;
        }

        private static XElement BuildTransmissionElement(Transport transport)
        {
            XElement xTransmission = new(TransmissionTag);
            XElement xTransmissionType = new(TypeTag, transport.GetTransmission().GetTransmissionType());
            xTransmission.Add(xTransmissionType);
            XElement xTransmissionsNumber = new(TransmissionsNumberTag, transport.GetTransmission().GetTransmissionNumber());
            xTransmission.Add(xTransmissionsNumber);
            XElement xTransmissionProducer = new(ProducerTag, transport.GetTransmission().GetProducer());
            xTransmission.Add(xTransmissionProducer);
            return xTransmission;
        }
    }
}
