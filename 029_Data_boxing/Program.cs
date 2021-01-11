using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * boxing을 하게 되면 힙영역에 데이터가 생기기 때문에 좋지 않음 
 * 스택영역과 힙영역은 스택영역은 데이터가 바로 사라지지만 힙영역은 데이터가 오래 지속됨
 */

namespace _029_Data_boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i;    //boxing
            int j = (int)o;  //unboxing
            i = 456;


            Console.WriteLine("i: {0}, o: {1}, j: {2}", i, o, j);
            Console.WriteLine("ReferenceEquals: {0}", Object.ReferenceEquals(i, o));
        }
    }
}
