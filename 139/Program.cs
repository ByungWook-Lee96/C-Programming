﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace _139_Thread01
{
    class Program
    {
        static void RunThread(int index)
        {
            var sw = Stopwatch.StartNew();

            Console.WriteLine(string.Format("RunThread index: {0} Start", index));

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("RunThread index: {0} sec: {1:N2}", index, sw.ElapsedMilliseconds / 1000.0f);
                Thread.Sleep(100);
            }

            Console.WriteLine(string.Format("RunThread index: {0} End", index));
            Console.WriteLine();
        }

        static void RunThread()
        {
            var sw = Stopwatch.StartNew();

            Console.WriteLine(string.Format("RunThread index: 0 Start"));

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("RunThread index: {0} sec: {1:N2}", "0", sw.ElapsedMilliseconds / 1000.0f);
                Thread.Sleep(100);
            }

            Console.WriteLine(string.Format("RunThread index: 0 End"));
            Console.WriteLine();
        }

        static void RunThreadObject(object index)
        {
            var sw = Stopwatch.StartNew();

            Console.WriteLine(string.Format("RunThreadObject index: {0} Start", index));

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("RunThreadObject index: {0} sec: {1:N2}", index, sw.ElapsedMilliseconds / 1000.0f);
                Thread.Sleep(100);
            }

            Console.WriteLine(string.Format("RunThreadObject index: {0} End", index));
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            RunThread();
            RunThread(1);
            RunThreadObject(2);

            Thread _thread = new Thread(RunThread);
            _thread.Start();

            Console.WriteLine("======================================");
            Console.WriteLine();

            Thread _thread2 = new Thread(() => RunThread(1));
            _thread2.Start();

            new Thread(() => RunThread(2)).Start();

            Thread thread2 = new Thread(new ParameterizedThreadStart(RunThreadObject));
            thread2.Start(3);
        }
    }
}
