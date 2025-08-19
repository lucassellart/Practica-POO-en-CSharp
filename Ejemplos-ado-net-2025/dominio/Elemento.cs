using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Elemento
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        // Voy a sobreescribir el método ToString para que me devuelva la descripción del elemento:

        public override string ToString()
        {
            return Descripcion;     // Devuelvo la propiedad "Descripcion"
        }
    }
}
