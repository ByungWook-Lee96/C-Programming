using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Hang();
            Thread.Sleep(300);
            Console.Clear();
            Head();
            
        }
        static void Hang()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t _______________");
            for (int i = 0; i < 10; i++)
            {
                if (i > 1)
                {
                    Console.WriteLine("\t\t\t\t| ");
                }
                else
                {
                    Console.WriteLine("\t\t\t\t|\t\t|");  //Console.WriteLine("\t\t\t\t|\t\t|");  위에서 7번째 옆에서는 \t\t\t\t|\t\t하고 얼굴 만들기

                }
            }
            Console.WriteLine("\t\t\t   -----------");

        }
        static void Head()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t _______________");
            for (int i = 0; i < 10; i++)
            {
                if (i > 2)
                {
                    Console.WriteLine("\t\t\t\t| ");
                }
                else if (i == 2)
                {
                    Console.WriteLine("\t\t\t\t|\t        ○");

                }
                else
                {
                    Console.WriteLine("\t\t\t\t|\t\t|");  //Console.WriteLine("\t\t\t\t|\t\t|");  위에서 7번째 옆에서는 \t\t\t\t|\t\t하고 얼굴 만들기

                }
            }
            Console.WriteLine("\t\t\t   -----------");
        }
    }
}
