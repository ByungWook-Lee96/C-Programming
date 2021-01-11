using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Check
{
    class Program
    {
        /*
         * exe파일에서 cmd를 통해 들어갈때 args에 2가지 입력을 받아서 출력한다.
         */
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine("지금 듣는 강의는 " + args[0] + args[1] + " 좋아요!");
            }
            else
            {
                Console.WriteLine("입력못받음");
            }
            Console.ReadKey();  // cmd에서 ReadKey를 안하면 바로 종료가 되고, ReadKey를 쓰게되면 그 다음에 입력을 해야 종료가 됨
            
        }
    }
}
