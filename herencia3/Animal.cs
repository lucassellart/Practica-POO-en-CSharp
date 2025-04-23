using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    internal class Animal
    { 
        // Todos los animales se comunican:
        public virtual string comunicarse()     // Método
        {
            return "ruido... ruido...";
        }
    }
}
