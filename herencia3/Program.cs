using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sobreescritura de métodos:

            AnimalDomestico a1 = new AnimalDomestico();
            a1.Nombre = "TITO";

            Animal an = new Animal();
            Perro p1 = new Perro();
            Gato g1 = new Gato();
            Pez pe = new Pez();
            Canario ca = new Canario();

            Console.WriteLine(a1.ToString());   // Esto muestra la definición del objeto "Animal"
            Console.WriteLine(an.comunicarse());
            Console.WriteLine(p1.comunicarse());
            Console.WriteLine(g1.comunicarse());
            Console.WriteLine(pe.comunicarse());
            Console.WriteLine(ca.comunicarse());

            List<Animal> animales = new List<Animal>();

            animales.Add(an);
            animales.Add(p1);
            animales.Add(g1);
            animales.Add(pe);
            animales.Add(ca);
            animales.Add(an);

            foreach (Animal item in animales)
            {
                Console.WriteLine(item.comunicarse());
            }

            List<Flyable> animalesVoladores = new List<Flyable>();      // Lista de animales voladores, gracias a la interfaz "Flyable"
            animalesVoladores.Add(new Aguila());
            animalesVoladores.Add(new Canario());

            foreach (Flyable item in animalesVoladores)
            {
                Console.WriteLine(item.volar());
            }


            Console.ReadKey();
        }
    }
}
