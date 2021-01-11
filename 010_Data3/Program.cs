using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Data3
{
    class Program
    {
        static void Main(string[] args)
        {
            //데이터 형식의 오류
            byte sbyteData = 255;
            sbyte sbyteData2 = (sbyte)sbyteData; //캐스트 연산오류 큰 데이터 형식에서 작은 데이터형식으로 바꿀때 생김
            int num = (int)sbyteData;

            Console.WriteLine("sbyteData: " + sbyteData);
            Console.WriteLine("sbyteData2: " + sbyteData2);
            Console.WriteLine("sbyte.MaxValue: " + sbyte.MaxValue);
            Console.WriteLine("num: " + num);
            Console.WriteLine("int.MaxValue: " + int.MaxValue);



        }
    }
}
