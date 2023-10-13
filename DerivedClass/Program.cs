using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedClass
{
    internal class Program
    {
        public class MyClass
        {
            private string myString;


            public MyClass(string yourString)
            {
                myString = yourString;
            }

            public virtual string GetString()
            {
                return myString;
            }

            public string MyString { 
                set { myString = value; }
            }
        }

        public class MyDerivedClass : MyClass
        {
            public MyDerivedClass(string yourString) : base(yourString)
            {

            }
            public override string GetString()
            {
                string overString = base.GetString() + " (output from the derived class)";
                return overString;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}


