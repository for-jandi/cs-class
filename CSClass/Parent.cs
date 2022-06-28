using System;

namespace CSClass
{
    public class Parent
    {
        public int variable = 5135211;
        public void Method()
        {
            Console.WriteLine("부모의 메소드");
        }
        public void Method2()
        {
            Console.WriteLine("부모의 메소드");
        }
        public Parent()
        {
            Console.WriteLine("Parent()");
        }

        public Parent(int param)
        {
            Console.WriteLine("Parent(int param)");
        }
        public Parent(string input)
        {
            Console.WriteLine("Parent(string param)");
        }
    }
}