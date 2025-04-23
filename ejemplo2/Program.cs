using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Primer lote con 10 registros de productos, cada producto tiene:
            //      - Código Artículo (3 dígitos no correlativos)
            //      - Precio
            //      - Código de Marca (1 a 10)

            //  Segundo lote con las ventas de la semana. Cada venta tiene:
            //      - Código Artículo
            //      - Cantidad
            //      - Código Cliente (1 a 100)
            //  Este lote corta con Código de Cliente cero.

            Producto[] productos = new Producto[10];    // Creo un vector para almacenar esos 10 productos y trabajar con los 3 datos que tengo

            // Ciclo para cargar los Productos:
            for (int i = 0; i < 10; i++)
            {
                productos[i] = new Producto();  // En cada vuelta del ciclo voy a cargar un nuevo producto (Son 10 productos por lote)

                // Le voy a pedir al usuario los datos del producto:
                Console.WriteLine("Ingrese los datos del producto:\n");

                Console.WriteLine("Código Artículo:\n");
                productos[i].CodigoArticulo = int.Parse(Console.ReadLine());

                Console.WriteLine("Precio:\n");
                productos[i].Precio = float.Parse(Console.ReadLine());

                Console.WriteLine("Código Marca:\n");
                productos[i].CodigoMarca = int.Parse(Console.ReadLine());
            }
            // Acá ya está cargado el vector con los 10 productos, amazing

            // Voy a procesar el segundo lote, las ventas:

            Venta ventas = new Venta();

            Console.WriteLine("Ingrese la venta:\n");
            
            Console.WriteLine("Ingrese el Código de Cliente: (1 a 100)\n");
            ventas.CodigoCliente = int.Parse(Console.ReadLine());   

            while (ventas.CodigoCliente != 0)
            {
                Console.WriteLine("Ingrese el Código de Artículo:\n");
                ventas.CodArticulo = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la Cantidad:\n");
                ventas.Cantidad = int.Parse(Console.ReadLine());

                // Pido cliente nuevamente:
                Console.WriteLine("Ingrese la venta:\n");

                Console.WriteLine("Ingrese el Código de Cliente: (1 a 100)\n");
                ventas.CodigoCliente = int.Parse(Console.ReadLine());
            }
        }
    }
}
