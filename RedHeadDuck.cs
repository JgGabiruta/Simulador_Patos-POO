using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Patos_POO
{
    public class RedHeadDuck:Duck,IFlayable,IQuackable
    {
        public override string display()
        {
            return "Eu sou Red Head Duck!!!";
        }
        public string fly()
        {
            return "";
        }
        public string quack()
        {
            return "";
        }
        public override string swim()
        {
            return "Eu nado";
        }

    }
}
