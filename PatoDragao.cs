using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Patos_POO
{
    internal class PatoDragao : Duck, IFlayable, IAtacar
    {
        public string atirar()
        {
            return "Eu cuspo fogo";
        }
        public override string display()
        {
            return "Eu sou Pato Dragão!!!";
        }
        public string fly()
        {
            return "Nuhh,, falei e saí voando!!";
        }

    }
}
