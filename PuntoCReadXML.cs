using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.IO;

namespace LAB3_Clase4
{
    internal class PuntoCReadXML
    {
        public void LeerDocumentoXML(string rutaArchivo)
        {
            try
            {
                XmlDocument xmlDocumento = new XmlDocument();
                xmlDocumento.Load(rutaArchivo);

                XmlNodeList listado = xmlDocumento.GetElementsByTagName("empleado");

                foreach (XmlElement empleado in listado)
                {
                    string id = empleado.GetElementsByTagName("id")[0].InnerText;
                    string nombreCompleto = empleado.GetElementsByTagName("nombreCompleto")[0].InnerText;
                    string cuil = empleado.GetElementsByTagName("cuil")[0].InnerText;

                    XmlElement sector = (XmlElement)empleado.GetElementsByTagName("sector")[0];
                    string sectorDenominacion = sector.GetAttribute("denominacion");
                    string sectorColorSemaforo = sector.GetAttribute("colorSemaforo");

                    string cupoAsignado = empleado.GetElementsByTagName("cupoAsignado")[0].InnerText;
                    string cupoConsumido = empleado.GetElementsByTagName("cupoConsumido")[0].InnerText;

                    Console.WriteLine($"\nEmpleado ID: {id}, Nombre: {nombreCompleto}, CUIL: {cuil}");
                    Console.WriteLine($"Sector: {sectorDenominacion}, Semáforo: {sectorColorSemaforo}");
                    Console.WriteLine($"Cupo Asignado: {cupoAsignado}, Cupo Consumido: {cupoConsumido}");
                    Console.WriteLine("-----------------------");
                }
                string subsectores = xmlDocumento.GetElementsByTagName("subsectores")[0].InnerText;
                string totalCupoAsignadoSector = xmlDocumento.GetElementsByTagName("totalCupoAsignadoSector")[0].InnerText;
                string totalCupoConsumidoSector = xmlDocumento.GetElementsByTagName("totalCupoConsumidoSector")[0].InnerText;
                string valorDial = xmlDocumento.GetElementsByTagName("valorDial")[0].InnerText;

                Console.WriteLine($"\nSubsectores: {subsectores}");
                Console.WriteLine($"Total Cupo Consumido del Sector: {totalCupoAsignadoSector}");
                Console.WriteLine($"Total Cupo Consumido del Sector: {totalCupoConsumidoSector}");
                Console.WriteLine($"Valor Dial: {valorDial}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo XML: {ex.Message}");
            }
        }
    }
}
