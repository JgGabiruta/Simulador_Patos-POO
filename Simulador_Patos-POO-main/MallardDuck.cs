using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Patos_POO
{
    public class MallardDuck : Duck, IFlayable, IQuackable
    {
        public override string display()
        {
            return "Eu sou Mallard Duck!!!";
        }
        public string fly()
        {
            return "Nuhh,, falei e saí voando!!";
        }
        public string quack()
        {
            return "Quaaaack!!!";
        }

    }
}
