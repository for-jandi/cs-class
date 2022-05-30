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

            foreach (var item in list)
            {
                Console.WriteLine("count : " + list.Count + "\t" + item);
            }

            Console.WriteLine(Math.Abs(-5555));
            Console.WriteLine(Math.Ceiling(52.3333));
            Console.WriteLine(Math.Floor(52.3333));
            Console.WriteLine(Math.Round(52.3333));
            Console.WriteLine(Math.Max(52.3333, 7));
            Console.WriteLine(Math.Min(52.3333, 7));
            Console.WriteLine(Math.PI);

            /*            Product product = new Product();
                        product.name = "감자";
                        product.price = 6000;*/

            Product product1 = new Product()
            {
                name = "감자",
                price = 6000
            };
            Product product2 = new Product()
            {
                price = 6000,
                name = "감자"
                
            };
            Product product3 = new Product()
            {
                name = "감자"
            };

            Console.WriteLine(product1);
            Console.WriteLine(product2);
            Console.WriteLine(product3);
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
