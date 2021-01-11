using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025_Data_ToString
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            float b = 3.141593f;
            decimal c = 3.14123123123123123m;

            string strA = a.ToString(); //"100"
            string strB = b.ToString(); //"3.141593"
            string strC = c.ToString();

            Console.WriteLine("a.ToString(): {0}", strA);
            Console.WriteLine("b.ToString(): {0}", strB);
            Console.WriteLine("c.ToString(): {0}", strC);

        }
    }
}
