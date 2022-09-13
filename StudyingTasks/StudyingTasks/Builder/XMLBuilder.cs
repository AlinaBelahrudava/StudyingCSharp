using Entity;
using Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudyingTasks.Builder
{
    internal class XMLBuilder
    {

        public static void WriteToXML(List<Transport> autopark, string fileName)
        {
            XDocument xdocument = new();
            XElement xautopark = new("autopark");
            foreach (Transport transport in autopark)
            {
                string name = transport.GetType().Name;
                XElement xtransport = new("transport");
                XAttribute xtransportName = new("name", name);
                xtransport.Add(xtransportName);

                if (transport is Scooter)
                {
                    XElement xFoldingDesign = new("folding_design", (transport as Scooter).GetIsFoldingDesign());
                    xtransport.Add(xFoldingDesign);
                }
                else if (transport is Bus)
                {
                    XElement xNumberOfSeats = new("seats", (transport as Bus).GetNumberOfSeats());
                    xtransport.Add(xNumberOfSeats);
                    XElement xNumberOfPassangers = new("passangers", (transport as Bus).GetNumberOfPassangers());
                    xtransport.Add(xNumberOfPassangers);
                    XElement xIsWCAvailable = new("wc", (transport as Bus).GetIsWCAvailable());
                    xtransport.Add(xIsWCAvailable);
                }
                else if (transport is Car)
                {
                    XElement xAirBagsNumber = new("air_bags", (transport as Car).GetAirBagsNumber());
                    xtransport.Add(xAirBagsNumber);
                    XElement xNumberOfSeats = new("seats", (transport as Car).GetNumberOfSeats());
                    xtransport.Add(xNumberOfSeats);

                }
                else if (transport is Truck)
                {
                    XElement xIsRefregerator = new("refregerator", (transport as Truck).GetIsRefregerator());
                    xtransport.Add(xIsRefregerator);
                }

                xtransport.Add(BuildEngineElement(transport));
                xtransport.Add(BuildChassisElement(transport));
                xtransport.Add(BuildTransmissionElement(transport));

                xautopark.Add(xtransport);
            }

            xdocument.Add(xautopark);
            xdocument.Save(fileName);
        }

        private static XElement BuildEngineElement(Transport transport)
        {
            XElement xEngine = new("engine");
            XElement xEnginePower = new("power", transport.GetEngine().GetPower());
            xEngine.Add(xEnginePower);
            XElement xEngineVolume = new("volume", transport.GetEngine().GetVolume());
            xEngine.Add(xEngineVolume);
            XElement xEngineType = new("type", transport.GetEngine().GetEngineType());
            xEngine.Add(xEngineType);
            XElement xEngineSerialNumber = new("serial_number", transport.GetEngine().GetSerialNumber());
            xEngine.Add(xEngineSerialNumber);
            return xEngine;
        }

        private static XElement BuildChassisElement(Transport transport)
        {
            XElement xChassis = new("chassis");
            XElement xChassisWheelsNumber = new("wheels", transport.GetChassis().GetWhellNumber());
            xChassis.Add(xChassisWheelsNumber);
            XElement xChassisNumber = new("number", transport.GetChassis().GetNumber());
            xChassis.Add(xChassisNumber);
            XElement xChassisCapacity = new("capacity", transport.GetChassis().GetCapacity());
            xChassis.Add(xChassisCapacity);
            return xChassis;
        }

        private static XElement BuildTransmissionElement(Transport transport)
        {
            XElement xTransmission = new("transmission");
            XElement xTransmissionType = new("type", transport.GetTransmission().GetTransmissionType());
            xTransmission.Add(xTransmissionType);
            XElement xTransmissionsNumber = new("transmissions_number", transport.GetTransmission().GetTransmissionNumber());
            xTransmission.Add(xTransmissionsNumber);
            XElement xTransmissionProducer = new("producer", transport.GetTransmission().GetProducer());
            xTransmission.Add(xTransmissionProducer);
            return xTransmission;
        }
    }
}
