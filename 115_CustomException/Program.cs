using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//CustomException 기초, when 키워드, StackTrace 키워드
namespace _115_CustomException
{
    class MyException : ApplicationException
    {
        public int Num { get; set; }
        public MyException() : base()  //부모클래스의 생성자 함수 부르는 것
        {

        }
        public MyException(int a)
        {
            Num = a;
        }
        public override string ToString()
        {
            return "Num: " + Num;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string readStr = Console.ReadLine();
            try
            {
                int num = int.Parse(readStr);

                if (num == 0 || num == 10)
                    throw new MyException(num);
            }catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(MyException e) when (e.Num == 0)
            {
                Console.WriteLine("when(e.Num == 0)");
                Console.WriteLine("MyException: " + e.Num);
                Console.WriteLine("MyException: " + e.StackTrace);
            }catch(MyException e) when (e.Num == 10)
            {
                Console.WriteLine("when(e.Num == 10)");
                Console.WriteLine("MyException: " + e.Num);
                Console.WriteLine("MyException: " + e.ToString());
                Console.WriteLine("MyException: " + e.StackTrace);
            }
        }
    }
}
