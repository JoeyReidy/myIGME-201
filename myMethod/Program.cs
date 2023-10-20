using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myMethod
{
    internal class Program
    {
        public interface myInterface
        {
            void theLine();
        }

        public class myClass : myInterface
        {
            public void theLine()
            {
                Console.WriteLine("this is the line");
            }
        }

        public class myOtherClass : myInterface
        {
            public void theLine()
            {
                Console.WriteLine("this is the other line");
            }
        }

        public static void MyMethod(object myObject)
        {
            if (myObject is myClass)
            {
                myClass myClass = (myClass)myObject;
                myClass.theLine();
            }
            else if (myObject is myOtherClass)
            {
                myOtherClass myOtherClass = (myOtherClass)myObject;
                myOtherClass.theLine();
            }
        }
        static void Main(string[] args)
        {
            myClass myClass = new myClass();
            myOtherClass myOtherClass = new myOtherClass();
            MyMethod(myClass);
            MyMethod(myOtherClass);
        }
    }
}
