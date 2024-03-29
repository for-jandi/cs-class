﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Program
    {
        private static object productA;

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

            List<Student> students = new List<Student>();
            students.Add(new Student()
            {
                name = "이민지",
                grade = 100
            });
            students.Add(new Student()
            {
                name = "가연우",
                grade = 60
            });
            students.Add(new Student()
            {
                name = "김유나",
                grade = 100
            });
            students.Add(new Student()
            {
                name = "김유진",
                grade = 89
            });
            students.Add(new Student()
            {
                name = "김하진",
                grade = 80
            });
            students.Add(new Student()
            {
                name = "심이진",
                grade = 22
            });
            students.Add(new Student()
            {
                name = "유예영",
                grade = 56
            });
            /*foreach (var item in students)
            {
                if(item.grade > 60)
                    students.RemoveAt(item); 
            }
            */


            /*            for(int i = 0; i < students.Count; i++)
                        {
                            if (students[i].grade > 60)
                            {
                                students.RemoveAt(i);
                                i--;
                            }
                        }*/
            for (int i = students.Count - 1; i >= 0; i--)
            {
                if (students[i].grade > 60)
                {
                    students.RemoveAt(i);
                }
            }
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-52));
            Console.WriteLine(MyMath.Abs(-52.3));
            Console.WriteLine(MyMath.Abs(52.3));
            Console.WriteLine(MyMath.Abs(52f));
            Console.WriteLine(MyMath.Abs(52L));

            Product productX = new Product("감자", 2000);
            Product productY = new Product("고구마", 3000);
            Console.WriteLine(productX);
            Console.WriteLine(productY);
            Console.WriteLine(Product.counter + "개가 생성되었습니다.");

            SingleTon mySingle = SingleTon.getInstance();
            Console.WriteLine("첫번째 위치");
            sampleClass sample = new sampleClass();
            Console.WriteLine("두번째 위치");
            Console.WriteLine(sampleClass.value);
            Console.WriteLine("세번째 위치");
            Console.WriteLine(sampleClass.value);

            Product product = new Product("과자", 1500);
            productA = null;
            Box box = new Box(10, 20);
            Console.WriteLine(box.getArea());

            Fibonacci fibo = new Fibonacci();
            Console.WriteLine(fibo.Get(1));
            Console.WriteLine(fibo.Get(50));
            Console.WriteLine(fibo.Get(100));
            Console.WriteLine(fibo.Get(1000));

            List<Dog> dogList = new List<Dog>() { new Dog(), new Dog(), new Dog()};
            List<Cat> catList = new List<Cat>() { new Cat(), new Cat(),new Cat()};
            List<Animal> animalList = new List<Animal>() { new Dog(), new Dog(), new Dog() , new Cat(), new Cat(), new Cat() };
            foreach(var item in animalList)
            {
                item.Eat();
                item.Sleep();
                if (item is Dog) ((Dog)item).Bark();
                else if (item is Cat) ((Cat)item).Meow();

                var dog = item as Dog;
                if(dog != null) { dog.Bark(); }
                var cat = item as Cat;
                if(cat != null) { cat.Meow(); }
            }
            Child childA = new Child();
            Child childB = new Child("string");

            // Shadowing
            int number = 20;
            Console.WriteLine(number); 

            foreach(var item in animalList)
            {
                item.Eat();
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
