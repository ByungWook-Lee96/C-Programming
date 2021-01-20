using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _096_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");

            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(i);
            }

            Console.WriteLine("queue data: {0}", queue.Peek()); // Peek는 가장 먼저 나올 데이터가 무엇인지

            while (queue.Count > 0)
            {
                Console.WriteLine("queue data: {0},count: {1}", queue.Dequeue(), queue.Count);
            }
            foreach(object data in queue)
            {
                Console.WriteLine(data);
            }

            //배열 데이터로 초기화
            Console.WriteLine("배열데이터로 초기화");
            int[] arrData = { 100, 200, 300 };
            Queue queueCopy = new Queue(arrData);

            foreach(object data in queueCopy)
            {
                Console.WriteLine("queueCopy data: " + data);
            }
        }
    }
}
