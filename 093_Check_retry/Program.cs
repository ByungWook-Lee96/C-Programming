using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _093_Check_retry
{
    class Student
    {
        private int id;
        private int kor;
        private int math;
        private int eng;

        public int ID { get { return id; } }
        public int Kor { get { return kor; } }
        public int Math { get { return math; } }
        public int Eng { get { return eng; } }

        public Student()
        {
            this.id = 0;
            this.kor = 0;
            this.math = 0;
            this.eng = 0;
        }

        public void InputID()
        {
            Console.Write("학생 id를 입력하세요. ");
            this.id = int.Parse(Console.ReadLine());
        }
        public void InputKor()
        {
            Console.Write("국어 점수를 입력하세요.");
            this. kor = int.Parse(Console.ReadLine());
        }
        public void InputMath()
        {
            Console.Write("수학 점수를 입력하세요.");
            this.math = int.Parse(Console.ReadLine());
        }
        public void InputEng()
        {
            Console.Write("영어 점수를 입력하세요.");
            this.eng = int.Parse(Console.ReadLine());
        }
        public void PrintID()
        {
            Console.WriteLine("id : {0}", this.id);
        }

    }
    class Program
    {
        static int Check(int index,Student[] student)
        {
            for (int i = 0; i < student.Length; i++)
            {
                if(index == student[i].ID)
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int index;
            int selId;
            Student[] student = new Student[3];

            for (int i = 0; i < student.Length; i++)
            {
                student[i] = new Student();
                student[i].InputID();
                student[i].InputKor();
                student[i].InputMath();
                student[i].InputEng();

                Console.WriteLine();

            }
            Console.Clear();

            while (true)
            {
                for (int i = 0; i < student.Length; i++)
                {
                    student[i].PrintID();
                }
                Console.Write("학생 아이디를 입력하세요? 0은 나가기");
                index = int.Parse(Console.ReadLine());
                if (index == 0)
                {
                    break;
                }
                selId=Check(index,student);
                if (selId >= 0)
                {
                    int sum = student[selId].Kor + student[selId].Math + student[selId].Eng;
                    Console.WriteLine("국어 점수: {0}", student[selId].Kor);
                    Console.WriteLine("수학 점수: {0}", student[selId].Math);
                    Console.WriteLine("영어 점수: {0}", student[selId].Eng);
                    Console.WriteLine("총점: {0}", sum);
                    Console.WriteLine("평균: {0}", sum / 3f);
                }
                else
                {
                    Console.WriteLine("없는 아이디 입니다.다시입력해주세요.");

                }

            }


        }
    }
}
