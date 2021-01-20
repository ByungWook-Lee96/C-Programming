using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _102_Check
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

                Console.Write("추가로 계산 할까요? 1: OK, 0: 나가기");
                if (Console.ReadLine() == "0")
                {
                    break;
                }
               
            }
            Console.Clear();
            foreach(Cal data in saveNumber)   
            {
                data.PrintResult();
            }
            //foreach (object data in saveNumber)  ctrl+k+c ctrl+k+u
            //{
            //    Console.WriteLine(data);        //str로 받게 되면 사용가능
            //}


        }
    }
}
