using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _078_Constructor
{
    class AA
    {
        int a;
        float f;

        public AA()
        {
            a = 0;
            f = 0f;
            Console.WriteLine("  Call Constructor  ");
            Console.WriteLine("  a: {0}  ",a);
            Console.WriteLine("  f: {0}  ",f);

        }
        public AA(int _a)
        {
            a = _a;
            f = 0f;
            Console.WriteLine("  Call Constructor  ");
            Console.WriteLine("  a: {0}  ", a);
            Console.WriteLine("  f: {0}  ", f);

        }

        public AA(int _a,float _f)
        {
            a = _a;
            f = _f;
            Console.WriteLine("  Call Constructor  ");
            Console.WriteLine("  a: {0}  ", a);
            Console.WriteLine("  f: {0}  ", f);

        }
        ~AA()  // 파라미터 못넣음
        {
            Console.WriteLine("  Call Destructor  ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA(); // 생성자 함수가 여러개이면 모두 만들어 놔야함
            AA aaa = new AA(10);
            AA aaaa = new AA(100,0.5f);
        }
    }
}
