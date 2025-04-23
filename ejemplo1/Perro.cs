using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Perro
    {
        // Perro: Nombre, Color, Origen

        // Atributos: 
        string nombre;
        string color;
        string origen;

        // PROPIEDADES: -> esto es para leer y obtener datos del perro

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
    }
}
