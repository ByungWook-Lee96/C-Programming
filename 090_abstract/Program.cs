using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _090_abstract
{
    abstract class abstractAA
    {
        protected int num;

        public abstractAA(int num)
        {
            this.num = num;
        }

        public abstract void abstractPrint(); // 강제적으로 상속받은 클래스에서 구현부 정의

        public virtual void virtualPrint()
        {
            Console.WriteLine("abstractAA virtual void virtualPrint()");
        }
        public void Print()
        {
            Console.WriteLine("abstractAA Print()");
        }
    }
    class AA : abstractAA
    {
        public AA(int num): base(num)  // 인스턴스가 없는 생성자 메소드를 상위 클래스에서 만들지 않아서 base(num)을 써야함
        {
            Console.WriteLine("num: {0}", num);
        }
        public override void abstractPrint()
        {
            Console.WriteLine("AA override void abstractPrint()");
        }

        public override void virtualPrint()
        {
            base.virtualPrint();

            Console.WriteLine("AA  override void virtualPrint() ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA(10);
            aa.abstractPrint();
            aa.virtualPrint();
            aa.Print();

            //abstractAA aaa = new abstractAA(10); // 불가
            abstractAA aaa = aa as AA;
            aaa.Print();
            
        }
    }
}
