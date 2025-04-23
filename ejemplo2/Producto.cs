using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Producto
    {
        //      - Código Artículo (3 dígitos no correlativos)
        //      - Precio
        //      - Código de Marca (1 a 10)

        // Hago los atributos con esos 3 datos: para poder guardar información sobre los productos
        // private int codArticulo;
        // private float precio;
        private int codMarca;

        // Para poder manipular los atributos desde el exterior puedo hacer PROPIEDADES:
        public int CodigoArticulo { get; set; } // Forma reducida de hacer la Propiedad (hecho en la clase "Botella")
        public float Precio { get; set; }

        public int CodigoMarca      // Acá hago la propiedad larga porque quiero condicionar (evaluar) de alguna forma el valor del código
        {
            set 
            {
                if (codMarca > 0 && codMarca < 11)
                {
                    codMarca = value;
                } else
                {
                    codMarca = -1;  // Esto significa error
                }
            }
            get { return codMarca; }
        }
    }
}
