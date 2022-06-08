using System;

namespace CSClass
{
    class sampleClass
    {
        public static int value = 10;
        static sampleClass()
        {
            value = 20;
            Console.WriteLine("정적 생성자 호출");
        }
    }
}