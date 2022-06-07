using System;

namespace CSClass
{
    class MyMath
    {
        /// <summary>
        /// 절대값 구하는 클래스 메소드
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        internal static int Abs(int v)
        {
            //sum_int = 5; // 인스턴스 변수 : 클레스 메소드에서 사용 불가 
            //foo(); // 인스턴스 메소드 : 클래스 메소드에서 사용 불가
            return (v < 0) ? -1 * v : v;
        }
        /// <summary>
        /// 절대값 구하는 클래스 메소드
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        internal static double Abs(double v)
        {
            //sum_int = 5; // 인스턴스 변수 : 클레스 메소드에서 사용 불가 
            //foo(); // 인스턴스 메소드 : 클래스 메소드에서 사용 불가
            return (v < 0) ? -1 * v : v;
        }

        void foo()
        {
            Console.WriteLine("클래스 메소드에서 접근 불가");
        }
    }
}