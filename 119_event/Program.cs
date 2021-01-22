using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _119_event
{
    public delegate void delegateEvent(string msg);

    class InDelegate
    {
        public delegateEvent myDelegate;
        public event delegateEvent myEvent;

        public void DoEvent(int a, int b)  // 이 메소드를 만들어야만 event사용 가능
        {
            if (null != myEvent)     // 델리게이트,event 생성할때는 null값 체크 필수!!!
                myEvent("DoEvent: " + (a + b)); //== ConsoleFunc("DoEvent: " + (a + b));
        }
    }
    class Program
    {
        static public void ConsoleFunc(string msg)
        {
            Console.WriteLine("ConsoleFunc: " + msg);
        }
        static void Main(string[] args)
        {
            InDelegate id = new InDelegate();
            //id.myEvent += new delegateEvent(ConsoleFunc);  //이것도 사용 가능
            id.myEvent += ConsoleFunc; //이벤트는 +=만 사용(-= 이건 사용가능)
            //id.myEvent = ConsoleFunc;  //대입연산자 사용불가

            id.myDelegate = ConsoleFunc;  // event가 아니고 delegate라 가능

            id.myDelegate("Test");  // 클래스 외부에서 직접 호출 가능
            //id.myEvent("Test");   // 클래스 외부에서 직접 호출 불가능

            for (int i = 0; i < 10; i++)
            {
                if (i == 9) id.myEvent -= ConsoleFunc;  //이벤트 빼기
                id.DoEvent(i + 1, i + 2);
            }


        }
    }
}
