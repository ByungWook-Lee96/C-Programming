using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _075_Check
{
    class Program
    {
        static void InputID(int[] ID, int index)
        {
            Console.Write("학생 ID를 입력하세요?");
            ID[index] = int.Parse(Console.ReadLine());
        }
        static void InputKor(int[] kor, int index)
        {
            Console.Write("국어 점수를 입력하세요?");
            kor[index] = int.Parse(Console.ReadLine());
        }
        static void InputMath(int[] math, int index)
        {
            Console.Write("수학 점수를 입력하세요?");
            math[index] = int.Parse(Console.ReadLine());
        }
        static void InputEng(int[] eng, int index)
        {
            Console.Write("영어 점수를 입력하세요?");
            eng[index] = int.Parse(Console.ReadLine());

            Console.WriteLine();

        }
        static void PrintID(int[] ID)
        {
            Console.WriteLine("학생 ID: " + ID[0]);
            Console.WriteLine("학생 ID: " + ID[1]);
            Console.WriteLine("학생 ID: " + ID[2]);
            
        }
        static int CheckID(int id,int[] ID)
        {         
            for (int i = 0; i < ID.Length; i++)
            {
                if (id == ID[i])
                {
                    return i;
                }
            }
            Console.WriteLine("학생 아이디가 없어요. 다시 입력하세요.");
            return -1;
        }
        static void Main(string[] args)
        {
            int[] ID = new int[3];
            int[] kor = new int[3];
            int[] math = new int[3];
            int[] eng = new int[3];
            int id = 0;

            for (int i = 0; i < 3; i++)
            {
                InputID(ID, i);
                InputKor(kor, i);
                InputMath(math, i);
                InputEng(eng, i);
            }
            Console.Clear();

            while (true)
            {
                PrintID(ID);
                Console.Write("학생 아이디를 입력하세요? <0>나가기");
                id = int.Parse(Console.ReadLine());
                if (id == 0)
                {
                    break;
                }
                if(CheckID(id, ID) == -1)
                {
                    continue;
                }
                Console.WriteLine("국어 점수: " + kor[CheckID(id, ID)]);
                Console.WriteLine("수학 점수: " + math[CheckID(id, ID)]);
                Console.WriteLine("영어 점수: " + eng[CheckID(id, ID)]);
                int sum = kor[CheckID(id, ID)] + math[CheckID(id, ID)] + eng[CheckID(id, ID)];
                float avg = sum / 3f;
                Console.WriteLine("총점: " + sum);
                Console.WriteLine("평균: " + avg);

                
            }


        }
    }
}
