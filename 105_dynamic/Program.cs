using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// dynamic, object, var 비교해야함
namespace _105_dynamic
{
    class Program
    {
        static T AddArray<T>(T[] arrDatas)
        {
            //T temp = 0; 에러
            //object temp=0; 박싱,언박싱 발생
            dynamic temp = default(T);  // 데이터형을 자유롭게 사용할 수 있음 dynamic
            for (int i = 0; i < arrDatas.Length; i++)
            {
                temp += arrDatas[i];
            }
            return temp;
        }
        static T SumArray<T>(T[] arrDatas)
        {
            T temp = default(T);
            for (int i = 0; i < arrDatas.Length; i++)
            {
                temp += (dynamic)arrDatas[i];
            }
            return temp;
        }
        static void PrintArrays<T>(T[] arrDatas)
        {
            foreach(var data in arrDatas)
            {
                Console.WriteLine("data: {0}", data);
            }
        }
        static void Main(string[] args)
        {
            int[] arrNums = { 1, 2, 3, 4, 5 };

            Console.WriteLine("AddArray: {0}", AddArray(arrNums));
            PrintArrays(arrNums);
        }
    }
}
