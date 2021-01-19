using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 076_Check를 클래스로 변경
namespace _094_Check
{
    class Cal
    {
        private int num1 { get; set; }
        private int num2 { get; set; }

        public Cal()
        {
            num1 = 0;
            num2 = 0;
        }
        public void InputNumber(int count)
        {

            if (count == 0)
            {
                Console.Write("첫번째 수를 입력 해 주세요? ");
                num1 = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.Write("두번째 수를 입력 해 주세요? ");
                num2 = int.Parse(Console.ReadLine());

            }


        }
        public void PrintResult()
        {
            Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
        }
    }
    class Program
    {
        static bool CheckEnd()
        {
            Console.Write("추가로 계산할까요(1: OK, 0: NO, 단 총 10번까지 가능)");
            if (int.Parse(Console.ReadLine()) == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static void Main(string[] args)
        {
            int count = 0;
            Cal[] cal = new Cal[10];
            
            while (true)
            {
                cal[count] = new Cal();
                cal[count].InputNumber(0);
                cal[count].InputNumber(1);

                cal[count].PrintResult();
                count++;

                if (count >= 10 || CheckEnd() == false)
                {
                    for (int i = 0; i < count; i++)
                    {
                        cal[i].PrintResult();
                    }
                    break;
                }


            }
        }
    }
}
