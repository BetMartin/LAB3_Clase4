using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_Clase4
{
    internal class programa
    {
        static void Main(string[] args)
        {
            PuntoAWriteXML puntoA = new PuntoAWriteXML();
            PuntoBXMLTextWriter puntoB = new PuntoBXMLTextWriter();
            PuntoCReadXML puntoC = new PuntoCReadXML();
            PuntoDXMLTextReader puntoD = new PuntoDXMLTextReader();

            string path = Directory.GetCurrentDirectory();

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Ejercicios: ");
                Console.WriteLine("1. Escribir XML con XDocument (Punto A)");
                Console.WriteLine("2. Escribir XML con XmlTextWriter (Punto B)");
                Console.WriteLine("3. Leer XML generado con XDocument (Punto C)");
                Console.WriteLine("4. Leer XML generado con XmlTextReader (Punto D)");
                Console.WriteLine("5. Salir");
                Console.Write("Elige una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        path = path.Replace("bin\\Debug", "PuntoA.xml");
                        Console.WriteLine("Creando XML con XDocument...");
                        puntoA.CrearDocumentoXML(path);
                        Console.WriteLine("XML creado correctamente");
                        break;

                    case "2":
                        path = path.Replace("bin\\Debug", "PuntoB.xml");
                        Console.WriteLine("Creando XML con XmlTextWriter...");
                        puntoB.CrearXMLTextWriter(path);
                        Console.WriteLine("XML creado correctamente");
                        break;

                    case "3":
                        path = path.Replace("bin\\Debug", "PuntoA.xml");
                        Console.WriteLine("Leyendo XML generado con XDocument...");

                        puntoC.LeerDocumentoXML(path);
                        break;

                    case "4":
                        path = path.Replace("bin\\Debug", "PuntoB.xml");
                        Console.WriteLine("Leyendo XML generado con XmlTextReader...");
                        puntoD.LeerXMLConXmlTextReader(path);
                        break;

                    case "5":
                        
                        Console.WriteLine("Saliendo del programa...");
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida, por favor intenta de nuevo.");
                        break;
                }

                Console.WriteLine("-----------------------");
            }
        }
    }
}

