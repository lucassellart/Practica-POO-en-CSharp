using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class DISCOS
    {
        // Propiedades:
        //public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public int CantidadCanciones { get; set; }
        public string UrlImagenTapa { get; set; }
        public Estilos Estilo { get; set; }
        public TiposEdicion TipoEdicion { get; set; }
    }
}
