using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace LAB3_Clase4
{
    internal class PuntoAWriteXML
    {
        public void CrearDocumentoXML(String rutaArchivo)
        {
            try
            {
                XElement empleados = new XElement("empleados");
                XElement listado = new XElement("listado");

                XElement empleado = new XElement("empleado");
                XElement id = new XElement("id", "4884");
                XElement nombreCompleto = new XElement("nombreCompleto", "Rodriguez, Victor");
                XElement cuil = new XElement("cuil", "20103180326");
                XElement sector = new XElement("sector");
                XAttribute denominacion = new XAttribute("denominacion", "Gerencia Recursos Humanos");
                XAttribute idSector = new XAttribute("id", "137");
                XAttribute valorSemaforo = new XAttribute("valorSemaforo", "130.13");
                XAttribute colorSemanforo = new XAttribute("colorSemaforo", "VERDE");
                sector.Add(denominacion, idSector, valorSemaforo, colorSemanforo);
                XElement cupoAsignado = new XElement("cupoAsignado", "1837.15");
                XElement cupoConsumido = new XElement("cupoConsumido", "658.02");
                empleado.Add(id, nombreCompleto, cuil, sector, cupoAsignado, cupoConsumido);
                listado.Add(empleado);

                empleado = new XElement("empleado");
                id = new XElement("id", "1225");
                nombreCompleto = new XElement("nombreCompleto", "Sanchez, Juan Ignacio");
                cuil = new XElement("cuil", "20271265817");
                sector = new XElement("sector");
                denominacion = new XAttribute("denominacion", "Gerencia Operativa");
                idSector = new XAttribute("id", "44");
                valorSemaforo = new XAttribute("valorSemaforo", "130.13");
                colorSemanforo = new XAttribute("colorSemaforo", "ROJO");
                sector.Add(denominacion, idSector, valorSemaforo, colorSemanforo);
                cupoAsignado = new XElement("cupoAsignado", "750.87");
                cupoConsumido = new XElement("cupoConsumido", "625.46");
                empleado.Add(id, nombreCompleto, cuil, sector, cupoAsignado, cupoConsumido);
                listado.Add(empleado);

                XElement subsectores = new XElement("subsectores", "5");
                XElement totalCupoAsignado = new XElement("totalCupoAsignadoSector", "4217.21");
                XElement totalCupoConsumido = new XElement("totalCupoConsumidoSector", "1405.88");
                XElement valorDial = new XElement("valorDial", "33.34");
                empleados.Add(listado, subsectores, totalCupoAsignado, totalCupoConsumido, valorDial);

                XDeclaration declaration = new XDeclaration("1.0", "utf-8", "yes");
                XComment comentario = new XComment("Lista de Empleados");
                XDocument docXML = new XDocument(declaration, comentario, empleados);


                docXML.Save(rutaArchivo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
