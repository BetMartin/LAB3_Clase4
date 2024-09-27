using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LAB3_Clase4
{
    internal class PuntoDXMLTextReader
    {
        public void LeerXMLConXmlTextReader(string rutaArchivo)
        {
            try
            {
                using (XmlTextReader reader = new XmlTextReader(rutaArchivo))
                {
                    string subsectores = "";
                    string totalCupoAsignadoSector = "";
                    string totalCupoConsumidoSector = "";
                    string valorDial = "";

                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "empleado")
                        {
                            string id = "";
                            string nombreCompleto = "";
                            string cuil = "";
                            string sectorDenominacion = "";
                            string sectorColorSemaforo = "";
                            string cupoAsignado = "";
                            string cupoConsumido = ""; ;

                            while (reader.Read() && !(reader.NodeType == XmlNodeType.EndElement && reader.Name == "empleado"))
                            {
                                if (reader.NodeType == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "id":
                                            id = reader.ReadElementContentAsString();
                                            break;

                                        case "nombreCompleto":
                                            nombreCompleto = reader.ReadElementContentAsString();
                                            break;

                                        case "cuil":
                                            cuil = reader.ReadElementContentAsString();
                                            break;

                                        case "sector":
                                            sectorDenominacion = reader.GetAttribute("denominacion");
                                            sectorColorSemaforo = reader.GetAttribute("colorSemaforo");
                                            break;

                                        case "cupoAsignado":
                                            cupoAsignado = reader.ReadElementContentAsString();
                                            break;

                                        case "cupoConsumido":
                                            cupoConsumido = reader.ReadElementContentAsString();
                                            break;

                                    }
                                }

                            }
                            Console.WriteLine($"\nEmpleado ID: {id}, Nombre: {nombreCompleto}, CUIL: {cuil}");
                            Console.WriteLine($"Sector: {sectorDenominacion}, Semáforo: {sectorColorSemaforo}");
                            Console.WriteLine($"Cupo Asignado: {cupoAsignado}, Cupo Consumido: {cupoConsumido}");
                            Console.WriteLine("-----------------------");
                        }

                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            switch (reader.Name)
                            {
                                case "subsectores":
                                    subsectores = reader.ReadElementContentAsString();
                                    break;

                                case "totalCupoAsignadoSector":
                                    totalCupoAsignadoSector = reader.ReadElementContentAsString();
                                    break;

                                case "totalCupoConsumidoSector":
                                    totalCupoConsumidoSector = reader.ReadElementContentAsString();
                                    break;

                                case "valorDial":
                                    valorDial = reader.ReadElementContentAsString();
                                    break;
                            }
                        }
                    }
                    Console.WriteLine($"\nSubsectores: {subsectores}");
                    Console.WriteLine($"Total Cupo Asignado del Sector: {totalCupoAsignadoSector}");
                    Console.WriteLine($"Total Cupo Consumido del Sector: {totalCupoConsumidoSector}");
                    Console.WriteLine($"Valor Dial: {valorDial}");
                    Console.WriteLine("-----------------------");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo XML: {ex.Message}");
            }
        }
    }
}


