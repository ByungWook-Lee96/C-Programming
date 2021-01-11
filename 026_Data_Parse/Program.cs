using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*------------------------------------------------------------------
 * Parse(string -> 정수, 실수 자료형 변환)
 ------------------------------------------------------------------*/
namespace _026_Data_Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            string strA = "100";
            string strB = "3.141593";
            string strC = "3.14123123123123123";

            int parseA = int.Parse(strA); //int parseA = 100;
            float parseB = float.Parse(strB); //float parseB = 3.141593f;
            decimal parseC = decimal.Parse(strC);

            Console.WriteLine("int.Parse: {0}", parseA);
            Console.WriteLine("float.Parse: {0}", parseB);
            Console.WriteLine("double.Parse: {0}", parseC);

        }
    }
}
