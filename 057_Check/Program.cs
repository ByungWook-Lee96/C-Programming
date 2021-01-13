using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _057_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int max = 0;
            int min = 999;
            for(int i = 0; i < 5; i++)
            {
                Console.Write("학생의 성적을 입력하세요: ");
                int grade = int.Parse(Console.ReadLine());
                if (grade < min)
                {
                    min = grade;
                }
                if(grade > max)
                {
                    max = grade;
                }
            }
            Console.WriteLine("최대값: {0}  최소값: {1}", max, min);

            Console.ReadKey();
        }
    }
}
