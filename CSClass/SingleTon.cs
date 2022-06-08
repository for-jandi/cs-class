using System;

namespace CSClass
{
    class SingleTon
    {
        private static SingleTon instance = null;
        private SingleTon()
        {

        }
        static SingleTon getInstance()
        {
            if(instance == null)
            {
                instance = new SingleTon();
            }
            return instance;
        }
    }
}