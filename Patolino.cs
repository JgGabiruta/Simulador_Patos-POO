using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Patos_POO
{
    internal class Patolino : Duck, IUsaRoupa, IVaiProShopping
    {
        public string usarRoupa()
        {
            return "Patolino está usando uma calça jeans de shopping.";
        }
        public string vaiProShopping()
        {
            return "Patolino pode comprar uma calça de shopping.";
        }
    }
}
