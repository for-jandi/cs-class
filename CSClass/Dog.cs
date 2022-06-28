using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Dog : Animal
    {
        string Color;
        public new void Eat()
        {
            Console.WriteLine("강아지가 우걱우걱 먹어요");
        }
        public Dog()
        {
        }
        public void Bark()
        {
            Console.WriteLine("멍멍");
        }
    }
}
