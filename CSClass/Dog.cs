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
        public Dog()
        {
        }
        public void Bark()
        {
            Console.WriteLine("멍멍");
        }
    }
}
