using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] arr3 = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
            List<int> list1 = new List<int>(arr1);
            List<int> list2 = new List<int>(arr2);
            List<int> list3 = new List<int>(arr3);
            int[] answer = new int[3];
            int[] answers = new int[] { 1,2,3,4,5,1 };
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;

            while (list1.Count() < answers.Length)
            {
                list1.AddRange(arr1);
            }
            while(list2.Count() < answers.Length)
            {
                list2.AddRange(arr2);
            }
            while (list3.Count() < answers.Length)
            {
                list3.AddRange(arr3);
            }

            for (int i = 0; i < answers.Length; i++)
            {
                if (list1[i] == answers[i])
                {
                    count1++;
                }
                if (list2[i] == answers[i])
                {
                    count2++;
                }
                if (list3[i] == answers[i])
                {
                    count3++;
                }
            }
            int[] countArray = new int[] { count1, count2, count3 };
            List<int> answerList = new List<int>();
            for(int i = 0; i < countArray.Length; i++)
            {
                if (countArray.Max() == countArray[i])
                {
                    answerList.Add(i);
                }
            }

            answer=answerList.ToArray();
            for(int i = 0; i < answer.Length; i++)
            {
                Console.Write((answer[i]+1)+" ");
            }
            
            

        }
    }
}
