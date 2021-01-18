using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _080_static
{
    class AA
    {
        public static int a;
        public static int b;
        public static readonly int c = 200; // 상수화

        public int num;
        public static void Print()
        {
            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);

            //num = 100; static으로 생성 안해서 오류

        }
        public AA()
        {
            Console.WriteLine("안녕"); // new로 객체생성 안해서 생성 X
        }
    }
    class BB
    {
        public int a;
        public int b;

        public void Print()
        {
            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);

        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            AA.a = 10;  // 객체 생성 없이 바로 접근 가능
            AA.b = 100;
            //AA.c = 200; //readonly이기때문에 오류

            AA.Print();

            //BB.a //오류
            //BB.b //오류
            //BB.Print(); //오류

            BB bb = new BB();
            bb.a = 100;
            bb.b = 200;

            bb.Print();

        }
    }
}
