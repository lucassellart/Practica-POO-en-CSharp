using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_app
{
    internal class Pokemon
    {
        // Propiedades:
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string UrlImagen { get; set; }   // Agrego esta prop. para poder cargar la imagen del Pokemon
        public Elemento Tipo { get; set; }
        public Elemento Debilidad { get; set; }
    }
}
