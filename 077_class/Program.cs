using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _077_class
{
    class AA
    {
        // 멤버 변수
        int num1;  // 기본적으로 private속성
        public int num2, num3;

        // 멤버 함수
        public void Print()
        {
            Console.WriteLine("aa: {0}, bb: {1}, cc: {2}", num1, num2, num3);
        }
        public AA() // 생성자
        {
            Console.WriteLine("안녕");
        }

        void PrintPrivate() // 접근 지정자를 안쓰면 private이 기본으로 되어있음
        {
            Console.WriteLine("aa: {0}, bb: {1}, cc: {2}", num1, num2, num3);
        }

    }
    class Program
    {
        static void Main(string[] args)       
        {
            AA aa = new AA();
            //aa.num1 = 10; // 오류
            aa.num2 = 100;
            aa.num3 = 1000;

            aa.Print();

            //aa.PrintPrivate(); // 오류
        }
    }
}
