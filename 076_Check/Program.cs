using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _076_Check
{
    class Program
    {
        
        static int InputNumber(int count)
        {
           
            if (count == 0)
            {
                Console.Write("첫번째 수를 입력 해 주세요? "); 
            }
            else
            {
                Console.Write("두번째 수를 입력 해 주세요? ");
            }
            
            return int.Parse(Console.ReadLine());
        }
        static void PrintResult(int a, int b)
        {
            Console.WriteLine(a + " + " + b + " = " + (a + b));           
        }
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
            int[] firstNum = new int[10];
            int[] secondNum = new int[10];
            
            while (true)
            {
                firstNum[count]=InputNumber(0);
                secondNum[count] = InputNumber(1);

                PrintResult(firstNum[count], secondNum[count]);
                count++;

                if(count>=10 || CheckEnd() == false)
                {
                    for (int i = 0; i < count; i++)
                    {
                        PrintResult(firstNum[i], secondNum[i]);
                    }
                    break;
                }


            }
        }
    }
}
