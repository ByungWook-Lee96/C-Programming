﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_Data_cast
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            double dNum = (double)num;
            Console.WriteLine("num: {0},  num2: {1}", num, dNum);

            double dNum2 = 123455678912;
            int num2 = (int)dNum2;  //큰 데이터형을 작은 데이터형로 변경시 주의!
            Console.WriteLine("dNum2:{0},  num2: {1}", dNum2, num2);
        }
    }
}
