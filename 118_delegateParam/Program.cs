using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _118_delegateParam
{
    delegate void delegateFunc();

    class MessageProcess
    {
        delegateFunc CallOkFunc;
        delegateFunc CallCancelFunc;

        public void Message(string msg, delegateFunc okFunc,delegateFunc cancelFunc)
        {
            CallOkFunc = okFunc;
            CallCancelFunc = cancelFunc;

            Console.WriteLine("Message: " + msg + "(0: Ok, 1: Cancel)");

            string inputStr = Console.ReadLine();

            if (inputStr.Equals("0"))
            {
                CallOkFunc();
            }
            else
            {
                CallCancelFunc();
            }
        }
    }
    class Program
    {
        static void CallOK()
        {
            Console.WriteLine("CallOk");
        }
        static void CallCancel()
        {
            Console.WriteLine("CallCancel");
        }
        static void Main(string[] args)
        {
            MessageProcess msg = new MessageProcess();
            msg.Message("Test Message", CallOK, CallCancel);

            //msg.Message("Test Message",    
            //    delegate ()                //CallOk부분에 새로운 익명 델리게이트 넣음
            //    {
            //        Console.WriteLine("delete");
            //    }, CallCancel);
        }
    }
}
