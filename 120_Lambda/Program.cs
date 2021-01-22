using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _120_Lambda
{
    delegate void dPrint(string str);
    delegate int dAdd(int a);
    class Program
    {
        static public void CallPrint(string str)
        {
            Console.WriteLine(str);
        }
        static public int CallAdd(int a)
        {
            return a + a;
        }
        static void Main(string[] args)
        {
            dPrint dp = CallPrint;
            dp("CallPrint");
            dp = (str) => { Console.WriteLine(str); };  // CallPrint가 아닌 새로운 메소드 생성
            dp("Lambda");

            dAdd da = CallAdd;
            Console.WriteLine("CallAdd: " + da(10));
            da = (a) => { return a + a; };
            Console.WriteLine("Lambda: " + da(10));
        }
    }
}
