using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    internal class Gato : AnimalDomestico
    {
        // Sobreescritura del método "comunicarse"

        public override string comunicarse()
        {
            return "miau... miau...";  
        }
    }
}
