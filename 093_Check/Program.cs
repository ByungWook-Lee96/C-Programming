using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _093_Check
{
    class Student
    {
        private int id;
        private int kor;
        private int math;
        private int eng;

        public int ID { get { return id; } }   // 클래스 밖에서 id를 가져오려면 사용해야함 
        public int KOR { get { return kor; } }
        public int MATH { get { return math; } }
        public int ENG { get { return eng; } }

        public Student()
        {
            this.id = 0;
            this.kor = 0;
            this.math = 0;
            this.eng = 0;
        }

        public void InputID()
        {
            Console.Write("학생 ID를 입력하세요?");
            this.id = int.Parse(Console.ReadLine());
        }
        public void InputKor()
        {
            Console.Write("국어 점수를 입력하세요?");
            this.kor = int.Parse(Console.ReadLine());
        }
        public void InputMath()
        {
            Console.Write("수학 점수를 입력하세요?");
            this.math = int.Parse(Console.ReadLine());
        }
        public void InputEng()
        {
            Console.Write("영어 점수를 입력하세요?");
            this.eng = int.Parse(Console.ReadLine());

        }
        public void PrintID()
        {
            Console.WriteLine("학생 ID: " + this.id);
        }
        public int GetTotal()
        {
            return kor + eng + math;
        }

    }
    class Program
    {
        static void PrintID(Student[] arrStudents)
        {
            foreach(Student data in arrStudents)
            {
                data.PrintID();
            }
        }

        static int CheckID(int id, Student[] arrStudents)
        {
            for (int i = 0; i < arrStudents.Length; i++)
            {
                if (id == arrStudents[i].ID)
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int inputSel ;
            int selID ;
            const int MAX = 3;
            Student[] arrStudents = new Student[MAX];

            for(int i = 0; i < MAX; i++)
            {
                arrStudents[i] = new Student();
                arrStudents[i].InputID();
                arrStudents[i].InputKor();
                arrStudents[i].InputMath();
                arrStudents[i].InputEng();

                Console.WriteLine();
            }

            Console.Clear();

            while (true)
            {
                PrintID(arrStudents);
                Console.Write("학생 아이디를 입력하세요? <0>나가기");
                inputSel = int.Parse(Console.ReadLine());
                if (inputSel == 0)
                {
                    break;
                }
                selID = CheckID(inputSel, arrStudents);
                if (selID >= 0)
                {

                    Console.WriteLine("국어 점수: " + arrStudents[selID].KOR);
                    Console.WriteLine("수학 점수: " + arrStudents[selID].MATH);
                    Console.WriteLine("영어 점수: " + arrStudents[selID].ENG);
                    int sum = arrStudents[selID].GetTotal();
                    float avg = sum / 3f;
                    Console.WriteLine("총점: " + sum);
                    Console.WriteLine("평균: " + avg);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("학생아이디가 없어요. 다시 입력하세요.");
                }
            }
            

        }
    }
}
