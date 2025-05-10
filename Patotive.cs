using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Patos_POO
{
    internal class Patotive : Duck, IQuackable, IAtacar, IUsaRoupa 
    {
        public string atirar()
        {
            return "Atirar com arma";
        }
        public override string display()
        {
            return "Eu sou Patotive!!!";
        }
        public string quack()
        {
            return "Quaaaack investigativo!!!";
        }
        public string usarRoupa()
        {
            return "Eu uso terno!";
        }
    }

    
}
