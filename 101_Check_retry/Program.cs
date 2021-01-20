using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _101_Check_retry
{
    class CStudent
    {
        private int id;
        private int kor;
        private int math;
        private int eng;

        public int ID { get { return id; } }
        public int Kor { get { return kor; } }
        public int Math { get { return math; } }
        public int Eng { get { return eng; } }

        public CStudent()
        {
            this.id = 0;
            this.kor = 0;
            this.math = 0;
            this.eng = 0;
        }
        public void InputID()
        {
            Console.Write("학생 ID를 입력하세요? ");
            this.id = int.Parse(Console.ReadLine());
        }
        public void InputKor()
        {
            Console.Write("국어 점수를 입력하세요? ");
            this.kor = int.Parse(Console.ReadLine());
        }
        public void InputMath()
        {
            Console.Write("수학 점수를 입력하세요? ");
            this.math = int.Parse(Console.ReadLine());
        }
        public void InputEng()
        {
            Console.Write("영어 점수를 입력하세요? ");
            this.eng = int.Parse(Console.ReadLine());
        }
        public void PrintID()
        {
            Console.WriteLine("학생 ID: " + this.id);
        }
    }
    class Program
    {
        static void PrintID(Hashtable hashTable)
        {
            foreach(object key in hashTable.Keys)
            {
                Console.WriteLine("학생 ID: " + key);
            }
        }
        static int CheckID(int index,Hashtable hashTable)
        {
            if (hashTable.ContainsKey(index))
            {
                return index;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int selID = -1;
            int index = 0;
            Hashtable hashStudentTable = new Hashtable();
            while (true)
            {
                PrintID(hashStudentTable);
                Console.Write("== 성적 입력중 == (0) 나가기");
                if (Console.ReadLine() == "0")
                {
                    break;
                }

                CStudent student = new CStudent();
                student.InputID();
                student.InputKor();
                student.InputMath();
                student.InputEng();

                hashStudentTable.Add(student.ID, student);  // 헷갈리지 않기
                Console.WriteLine();
            }
            Console.Clear();

            while (true)
            {
                PrintID(hashStudentTable);
                Console.Write("학생 아이디를 입력하세요? 0 누르면 나감");
                selID=int.Parse(Console.ReadLine());
                if (selID == 0)
                {
                    break;
                }
                index = CheckID(selID, hashStudentTable);
                if(index >=0)
                {
                    CStudent selStudent = (CStudent)hashStudentTable[index];  // 이 부분 헷갈림
                    int sum = selStudent.Kor + selStudent.Math + selStudent.Eng;
                    Console.WriteLine("국어 점수: " + selStudent.Kor);
                    Console.WriteLine("수학 점수: " + selStudent.Math);
                    Console.WriteLine("영어 점수: " + selStudent.Eng);
                    Console.WriteLine("총점: " + sum);
                    Console.WriteLine("평균: " + sum / 3f);

                }
                else
                {
                    Console.WriteLine("아이디가 없습니다. 다시 입력해주세요.");
                }
                Console.WriteLine();
                
            }
        }
    }
}
