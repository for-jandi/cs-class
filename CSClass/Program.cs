using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SetInTime();
            car.SetOutTime();
            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            foreach(var item in list)
            {
                Console.WriteLine("count : " + list.Count + "\t" + item);
            }
        }
    }
    class Car
    {
        /***
         * carNumber : 자동차 번호
         ***/
        int carNumber;
        DateTime inTime;
        DateTime outTime;
        /// <summary>
        /// 자동차가 들어온 시간 설정
        /// </summary>
        public void SetInTime()
        {
            this.inTime = DateTime.Now;
        }

        /// <summary>
        /// 자동차가 나간 시간 설정
        /// </summary>
        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }
    }
}
