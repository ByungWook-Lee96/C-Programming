using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003
{
    public class Solution
    {
        public int solution(int bridge_length, int weight, int[] truck_weights)
        {
            int answer = 0;

            return answer;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int bridge_length = 2;
            int weight = 10;
            int[] truck_weights = new int[] { 7, 4, 5, 6 };
            int time = 0;
            Queue<int> bridgeTruck = new Queue<int>();
            int index = 0;
            int sum = 0;
            int totalTime = 0;
            while (true)
            {
                while (time <= bridge_length)  // 다리 위에 있는 트럭
                {
                    totalTime++;
                    time++;
                    sum += truck_weights[index];

                    if (sum <= weight)
                    {
                        bridgeTruck.Enqueue(truck_weights[index]);
                        index++;
                    }
                    if(index > truck_weights.Length)
                    {
                        break;
                    }
                }
                Console.WriteLine(totalTime);
                bridgeTruck.Dequeue();
                time = 0;
                if (index > truck_weights.Length)
                {
                    break;
                }
            }
            Console.WriteLine(totalTime);
            
            


        }
    }
}
