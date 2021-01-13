using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _055_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int answer = 0;
            int correct = 0;
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}: 다음 두 수의 합은 몇?(총 5문제)",i+1);
                int a = rnd.Next(0, 100);
                int b = rnd.Next(0, 100);
                Console.WriteLine("{0} + {1} = ??", a, b);
                answer = int.Parse(Console.ReadLine());
                if (a + b == answer)
                {
                    Console.WriteLine("== 정답 ==");
                    correct++;
                }
                else
                {
                    Console.WriteLine("오답(정답은: {0})", a + b);
                }
                
            }
            Console.WriteLine("\n총 맞은 개수는 {0}개 입니다.", correct);
            Console.ReadKey();
        }
    }
}
