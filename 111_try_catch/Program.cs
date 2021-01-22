using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _111_try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = 0;
            bool isCorrect = false;

            while (!isCorrect)
            {
                Console.Write("정수를 입력해주세요: ");
                string readStr = Console.ReadLine();

                try
                {
                    inputNum = int.Parse(readStr);
                    isCorrect = true;
                }
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("입력문자: " + readStr + " 정수를 입력하세요.");
                }
            }
            Console.WriteLine("inputNum: " + inputNum);
        }
    }
}
