using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041_Operator_null
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null; //null값을 입력받음
            int b = 10;
            int? c = null;
            int d = 100;
            int result;

            result = a ?? b; //10  a가 null이면 b로 넘어감 둘중에 하나는 null이 아니여야 사용가능함
            Console.WriteLine("result: " + result);

            result = a ?? c ?? d; //100
            Console.WriteLine("result: " + result);

            c = 100000;
            result = a ?? c ?? d; //10000
            Console.WriteLine("result: " + result);

        }
    }
}
