using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001
{
    public class Solution
    {
        public int[] solution(int[] numbers)
        {
            int[] answer = new int[] { };
            List<int> numList = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    numList.Add(numbers[i] + numbers[j]);
                }
            }
            numList.Sort();
            answer = numList.Distinct().ToArray();

            return answer;
        }
    }
    public class Solution_other
    {
        public int[] solution(int[] numbers)
        {
            int[] answer = new int[] { };
            List<int> numList = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if(!numList.Contains(numbers[i] + numbers[j]))
                        numList.Add(numbers[i] + numbers[j]);
                }
            }
            numList.Sort();
            answer = numList.ToArray();

            return answer;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] answer = new int[] { };
            List<int> numList = new List<int>();
            int[] arr = new int[] { 2, 1, 3, 4, 1 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    numList.Add(arr[i] + arr[j]);
                }
            }
            numList.Sort();
            answer = numList.Distinct().ToArray();
            for(int i = 0; i < answer.Length; i++)
            {
                Console.WriteLine(answer[i]);
            }

        }
    }
}
