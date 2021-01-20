using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102_Check_origin
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
        static bool CheckEnd(int index)
        {
            bool isEnd = false;
            int temp = 0;

            Console.Write("{0}번째 추가로 계산할까요(1: OK,0: NO)",(index+1));
            temp = int.Parse(Console.ReadLine());
            isEnd = (temp == 0);

            return isEnd;
        }
        static void Main(string[] args)
        {
            ArrayList saveNumber = new ArrayList();

            while (true)
            {
                Cal cal = new Cal();
                cal.InputNumber(0);
                cal.InputNumber(1);

                cal.PrintResult();
                saveNumber.Add(cal);

                if (CheckEnd(saveNumber.Count))
                {
                    Console.Clear();
                    foreach(Cal data in saveNumber)
                    {
                        data.PrintResult();
                    }
                    break;
                }

            }

        }
    }
}
