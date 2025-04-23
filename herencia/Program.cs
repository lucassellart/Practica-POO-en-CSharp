using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lider, Developer y Tester heredan de Persona las propiedades: 
            // Apellido, Nombre y Legajo

            Lider l1 = new Lider();
            l1.Apellido = "Fernandez";

            Developer d1 = new Developer();
            d1.Nombre = "Marcelo";

            Tester t1 = new Tester();
            t1.Legajo = 147;

            Console.WriteLine("Apellido Lider: " + l1.Apellido + "\nNombre Developer: " + d1.Nombre + "\nLegajo Tester: " + t1.Legajo);
            Console.ReadKey();
        }


    }
}

