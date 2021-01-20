using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 093_Check를 입력제한 없이 받아라
namespace _101_Check
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
        static void PrintID(Hashtable hashTable)
        {
            foreach(int key in hashTable.Keys)
            {
                Student castData = (Student)hashTable[key];
                castData.PrintID();
            }
        }

        static int CheckID(int id,Hashtable hashtable)
        {
            if (hashtable.ContainsKey(id))
            {
                return id;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int index;
            int selId;

            Hashtable hashStudents = new Hashtable();
            while (true)
            {
                PrintID(hashStudents);
                Console.Write("== 성적 입력중 == (0) 나가기");
                if (Console.ReadLine() == "0")
                    break;
                Student temp = new Student();
                temp.InputID();
                temp.InputKor();
                temp.InputMath();
                temp.InputEng();

                hashStudents.Add(temp.ID, temp);
                foreach (object key in hashStudents.Keys)
                {
                    Console.WriteLine("key: {0}, data: {1}", key, hashStudents[key]);
                }
                Console.WriteLine();
            }
            Console.Clear();

            while (true)
            {
                PrintID(hashStudents);
                Console.Write("학생 아이디를 입력하세요? 0은 나가기");
                index = int.Parse(Console.ReadLine());
                if (index == 0)
                {
                    break;
                }
                selId=CheckID(index,hashStudents);
                if (selId >= 0)
                {
                    Student selStudent = (Student)hashStudents[selId];
                    int sum = selStudent.Kor + selStudent.Math + selStudent.Eng;
                    Console.WriteLine("국어 점수: {0}", selStudent.Kor);
                    Console.WriteLine("수학 점수: {0}", selStudent.Math);
                    Console.WriteLine("영어 점수: {0}", selStudent.Eng);
                    Console.WriteLine("총점: {0}", sum);
                    Console.WriteLine("평균: {0}", (float)sum / 3f);
                }
                else
                {
                    Console.WriteLine("없는 아이디 입니다.다시입력해주세요.");

                }

            }


        }
    }
}

