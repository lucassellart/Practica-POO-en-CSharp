using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Venta
    {
        //  Segundo lote con las ventas de la semana. Cada venta tiene:
        //      - Código Artículo
        //      - Cantidad
        //      - Código Cliente (1 a 100)
        //  Este lote corta con Código de Cliente cero.

        // Estas son las Propiedades en formato reducido para manejar los datos de las ventas
        // Con estas propiedades puedo leer y setear valores
        public int CodArticulo { get; set; }
        public int Cantidad { get; set; }

        private int codCliente; // Atributo privado, lo necesito para la propiedad en formato largo
        public int CodigoCliente    // Propiedad para evaluar el código del cliente
        {
            get { return codCliente; }
            set
            {
                if (codCliente >= 1 && codCliente <= 100)
                    codCliente = value;
                else
                    codCliente = -1; // Esto significa error en el codigo, número no válido
            }
        }
    }
}

