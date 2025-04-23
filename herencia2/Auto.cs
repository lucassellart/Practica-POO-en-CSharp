using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia2
{
    internal class Auto : Vehiculo
    {
        // Constructor para la clase:
        public Auto()
        {
            Chasis = new Chasis();
        }

        // ASOCIACIÓN: Composición y Agregación
        public int Anio { get; set; }

        public string Modelo { get; set; }
        public string Color { get; set; }


        // Composición: El objeto nace con la propiedad
        public Chasis Chasis { get; } // El auto tiene que nacer con un Chasis, por eso le saco el "set", no se puede modificar

        // Agregación: El objeto no nace con la propiedad (se puede "agregar" después)
        public Motor Motor { get; set; }
    }
}
