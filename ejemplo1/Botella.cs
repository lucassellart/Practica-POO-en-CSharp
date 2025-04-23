using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Botella
    {
        // Capacidad máxima = 100
        // Cantidad actual: inicia en cero
        // Método recarga: carga al 100 y devuelve el costo de recargar. 50 cada 100.


        // Constructor:
        public Botella(string color, string material)        // El constructor puede recibir parámetros o no
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }

        // Botella: Capacidad, Color, Material

        // Atributos:
        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;

        public int Capacidad
        {
            get { return capacidad; }
        }

        public int CantidadActual
        {
            get { return cantidadActual; }
        }

        public string Color        // Creo la propiedad "Color" en modo lectura para poder acceder desde el exterior (Program)
        {                          // Necesito acceder desde el exterior porque los atributos son privados
            get { return color; }
        }
        public string Material      // Igual que en la propiedad "Color"
        {
            get { return material; }
        }

        // PROPIEDAD
        /*
        public int Capacidad        // Esta propiedad reemplaza el 'set' y 'get' del objeto Persona
        {
            set { capacidad = value; }

            get { return capacidad; }
        }
        */

        // MÉTODOS:

        public float recargar()
        {
            if (cantidadActual >= 0)
            {
                cantidadActual = 330;
            }
            return 50;
        }

        // SOBRECARGA Método recargar:

        public float recargar(int capacidad)
        {
            cantidadActual = capacidad;
            return 1;
        }
    }
}
