using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Pokemon        // La clase debe ser 'public' para poder se accedida desde otro proyecto como "winform-app" o "negocio"
    {
        // Propiedades:

        public int Id { get; set; }

        [DisplayName("Número")]     // Annotation -> (validaciones, formato de fecha) ->  darle un nombre a la columna, agregar tílde
        public int Numero { get; set; }
        public string Nombre { get; set; }
        
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public string UrlImagen { get; set; }   // Agrego esta prop. para poder cargar la imagen del Pokemon
        public Elemento Tipo { get; set; }
        public Elemento Debilidad { get; set; }
    }
}
