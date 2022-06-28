using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    public class Cat : Animal
    {
        string Color;
        public new void Eat()
        {
            Console.WriteLine("고양이가 맛있게 먹어요");
        }
        public Cat()
        {
        }
        public void Meow()
        {
            Console.WriteLine("냐옹");
        }
    }
}
