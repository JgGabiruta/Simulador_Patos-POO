﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Patos_POO
{
    public class Patolino : Duck, IUsaRoupa, IVaiProShopping
    {
        public string usarRoupa()
        {
            return "Usar Roupa";
        }

        public override string display()
        {
            return "Eu sou o Patolino";
        }
        public string vaiProShopping()
        {
            return "Shopping!";
        }
    }
}
