using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Persona p1 = new Persona("Beturri");

            //p1.Edad = 72;

            //Console.WriteLine(p1.saludar());
            //Console.WriteLine(p1.saludar("Marquitos"));
            //Console.WriteLine("La edad de la persona es: " + p1.Edad);

            //Console.ReadKey();

            Botella b1 = new Botella("Rojo", "Plástico");

            string m = b1.Material;
            string c = b1.Color;

            Console.WriteLine("\nEl color de la botella es: " + c + " y el material es: " + m);

            //b1.Capacidad = 750;
            
            Console.WriteLine("\nLa capacidad de la botella es: " + b1.Capacidad + "ml.");
            Console.WriteLine("\nLa cantidad actual es de: " + b1.CantidadActual + "ml");

            b1.recargar();

            Console.WriteLine("\nLuego de recargar, la capacidad de la botella es de: " + b1.CantidadActual);

            b1.recargar(225);       // Sobrecarga del método

            Console.WriteLine("\nAhora, la cantidad de líquido es: " + b1.CantidadActual);

            //Perro r1 = new Perro();
            //r1.Nombre = "Dolly";

            //Console.WriteLine("\nEl nombre del perro es: " + r1.Nombre);

            Console.ReadKey();
        }
    }
}
