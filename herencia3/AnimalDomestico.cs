using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    internal class AnimalDomestico : Animal
    {
        // Propiedades:

        public string Nombre { get; set; }      // El animal doméstico tiene un nombre,
                                                // el animal salvaje no

        // Voy a sobreescribir el método "ToString()":

        public override string ToString()
        {
            return "Animal Doméstico: " + Nombre; 
        }
    }
}
