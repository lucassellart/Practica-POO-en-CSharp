using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vehículo > Auto > AutoDeportivo > AutoUrbano
            //          > Camioneta
            //          > Moto

            //Vehiculo v1 = new Vehiculo();
            //Camioneta c1 = new Camioneta();
            //Camioneta c2 = new Camioneta();
            //Camioneta c3 = new Camioneta();

            //c1.Color = "Amarillo";
            //c2.Color = "Rojo";
            //c3.Color = "Gris";

            // Voy a crear una colección de tipo Camioneta

            //List<Camioneta> listaCamionetas = new List<Camioneta>();

            //listaCamionetas.Add(c1);
            //listaCamionetas.Add(c2);
            //listaCamionetas.Add(c3);

            //Console.WriteLine("La cantidad de camionetas es: " + listaCamionetas.Count);
            //listaCamionetas[2].Color = "Marrón";
            //Console.WriteLine("\nEl color de la camioneta es: " + c3.Color);

            //listaCamionetas.Remove(c2);
            //Console.WriteLine("\nDespués de eliminar, la cantidad de camionetas es: " + listaCamionetas.Count);


            //foreach (Camioneta item in listaCamionetas)     // Para mostrar el color de todas las camionetas, por ejemplo
            //{                                               // El "item" es como el "índice"
            //    Console.WriteLine("Color: " + item.Color);
            //}

            // Relación entre clases por asociación:
            Auto a1 = new Auto();
            a1.Motor = new Motor();

            Console.ReadKey();
        }
    }
}
