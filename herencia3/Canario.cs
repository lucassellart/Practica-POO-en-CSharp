using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    internal class Canario : AnimalDomestico, Flyable
    {
        // Sobreescritura del método "comunicarse"

        public override string comunicarse()
        {
            return "piu... piu...";
        }

        public string volar()
        {
            return "Vuela como un canario...";
        }
    }
}
