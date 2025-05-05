using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Patos_POO
{
    public class RedHeadDuck:Duck,IFlayable,IQuackable
    {
        public override void display()
        {
            Console.WriteLine("Eu sou Red Head Duck!!!");
        }
        public void fly()
        {

        }
        public void quack()
        {

        }

    }
}
