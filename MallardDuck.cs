using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Patos_POO
{
    public class MallardDuck : Duck, IFlayable, IQuackable
    {
        public override void display()
        {
            Console.WriteLine("Eu sou Mallard Duck!!!");
        }
        public void fly()
        {
            Console.WriteLine("Nuhh,, falei e saí voando!!");
        }
        public void quack()
        {
            Console.WriteLine("Quaaaack!!!");
        }

    }
}
