using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Estilos
    {
        // Propiedades:
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Descripcion;     // Voy a mostrar la descripción y no la definición del objeto 
        }
    }
}
