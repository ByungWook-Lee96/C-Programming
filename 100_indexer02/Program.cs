using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100_indexer02
{
    class AA
    {
        ArrayList arrayList = new ArrayList();

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < arrayList.Count)
                    return (string)arrayList[index];
                else
                    return null;
            }
            set
            {
                if (index >= 0 && index < arrayList.Count)
                    arrayList[index] = value;
                else if (index == arrayList.Count)
                    arrayList.Add(value);
            }
        }

        public int count
        {
            get { return arrayList.Count; }
        }
      
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            for (int i = 0; i < 10; i++)
            {
                aa[i] = string.Format("{0}", i);  //string.Format()문자열로 바꿀때 사용
            }

            aa[0] = "Hello";
            aa[1] = "World";
            aa[10] = "!!!";

            for (int i = 0; i < aa.count; i++)
            {
                Console.WriteLine("aa: " + aa[i]);
            }
        }
    }
}
