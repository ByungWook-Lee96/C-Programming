using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _091_Property01
{
    class AA
    {
        private int num;

        public int NUM
        {
            get { return num; }
            set { num = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            // aa.num = 100; // 정보은닉을 하기위해 get set을 통해서 사용
            aa.NUM = 100;

            Console.WriteLine("aa.NUM: {0}", aa.NUM);
        }
    }
}
