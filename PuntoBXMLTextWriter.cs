using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Xml;

namespace LAB3_Clase4
{
    internal class PuntoBXMLTextWriter
    {
        public void CrearXMLTextWriter(string rutaArchivo)
        {
            using (XmlTextWriter writer = new XmlTextWriter(rutaArchivo, System.Text.Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;

                writer.WriteStartDocument();
                writer.WriteStartElement("empleados");
                writer.WriteStartElement("listado");

                writer.WriteStartElement("empleado");
                writer.WriteElementString("id", "4884");
                writer.WriteElementString("nombreCompleto", "Rodriguez, Victor");
                writer.WriteElementString("cuil", "20103180326");
                writer.WriteStartElement("sector");
                writer.WriteAttributeString("denominacion", "Gerencia Recursos Humanos");
                writer.WriteAttributeString("id", "137");
                writer.WriteAttributeString("valorSemaforo", "130.13");
                writer.WriteAttributeString("colorSemaforo", "VERDE");
                writer.WriteEndElement();
                writer.WriteElementString("cupoAsignado", "1837.15");
                writer.WriteElementString("cupoConsumido", "658.02");
                writer.WriteEndElement();

                writer.WriteStartElement("empleado");
                writer.WriteElementString("id", "1225");
                writer.WriteElementString("nombreCompleto", "Sanchez, Juan Ignacio");
                writer.WriteElementString("cuil", "20271265817");
                writer.WriteStartElement("sector");
                writer.WriteAttributeString("denominacion", "Gerencia Operativa");
                writer.WriteAttributeString("id", "44");
                writer.WriteAttributeString("valorSemaforo", "130.13");
                writer.WriteAttributeString("colorSemaforo", "ROJO");
                writer.WriteEndElement();
                writer.WriteElementString("cupoAsignado", "750.87");
                writer.WriteElementString("cupoConsumido", "625.46");
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteElementString("subsectores", "5");
                writer.WriteElementString("totalCupoAsignadoSector", "4217.21");
                writer.WriteElementString("totalCupoConsumidoSector", "1405.88");
                writer.WriteElementString("valorDial", "33.34");

                writer.WriteEndElement();
                writer.WriteEndDocument();

                writer.Close();
            }
        }
    }
}