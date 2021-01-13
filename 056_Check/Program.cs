using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _056_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndNum = rnd.Next(1, 100);
            int count = 0;
            while (true)
            {
                count++;
                Console.Write("0~99사이 어떤 숫자일까요?(단, 0은 나가기)");
                int inputNum = int.Parse(Console.ReadLine());
                if (rndNum > inputNum)
                {
                    Console.WriteLine("입력한 수는 작아요.");
                }
                else if(rndNum < inputNum)
                {
                    Console.WriteLine("입력한 수는 커요.");
                }
                else if (rndNum == inputNum)
                {
                    Console.WriteLine("=== 정답 입니다.===");
                    break;
                }
                else
                {
                    Console.WriteLine("종료합니다.");
                    break;
                }
                
            }
            Console.WriteLine("총 {0}번 시도",count);
            Console.ReadKey();

        }
    }
}
