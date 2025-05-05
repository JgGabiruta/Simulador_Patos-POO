using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Patos_POO
{
    public class RubberDuck : Duck, IQuackable
    {
        public override void display()
        {
            Console.WriteLine("Eu sou Rubber Duck!!!");
        }
        public void quack()
        {
            Console.WriteLine("Quaaaack!!!");
        }

    }
}
