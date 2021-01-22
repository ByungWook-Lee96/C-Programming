using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _122_FuncLambda
{
    delegate void dPrint(string str);
    delegate void dFunc();
    class Program
    {
        static public void CallPrint(string str)
        {
            Console.WriteLine(str);
        }
        static public void CallBackFunc(dPrint dp,string msg)
        {
            if (null != dp)
            {
                dp("CallBackFunc: " + msg);
            }
        }
        static void Main(string[] args)
        {
            CallBackFunc(CallPrint, "Hello"); //함수 연결
            CallBackFunc(delegate (string str) { Console.WriteLine(str); }, "Hello");
            CallBackFunc((string str) => { Console.WriteLine(str); }, "Hello");
            CallBackFunc((str) => { Console.WriteLine(str); }, "Hello");
            CallBackFunc(str => Console.WriteLine(str), "Hello");  // 가장 심플해서 많이 쓰임

            dFunc dfunc = () => Console.WriteLine("No Params"); // 파라미터가 없으면 ()를 써야함
        }
    }
}
