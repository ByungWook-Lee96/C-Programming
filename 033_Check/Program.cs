using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("국어 점수를 입력하세요?");
            string strLan = Console.ReadLine();
            Console.Write("영어 점수를 입력하세요?");
            string strEng = Console.ReadLine();
            Console.Write("수학 점수를 입력하세요?");
            string strMath = Console.ReadLine();
            Console.Write("과학 점수를 입력하세요?");
            string strSci = Console.ReadLine();

            int Lan = int.Parse(strLan);
            int Eng = int.Parse(strEng);
            int Math = int.Parse(strMath);
            int Sci = Convert.ToInt32(strSci);

            int sum = Lan + Eng + Math + Sci;
            float avg = (float)sum / 4;

            Console.WriteLine("국어: {0}   영어: {1}   수학: {2}   과학: {3}", Lan, Eng, Math, Sci);
            Console.WriteLine("총점: {0}   평균: {1}", sum, avg);
        }
    }
}
