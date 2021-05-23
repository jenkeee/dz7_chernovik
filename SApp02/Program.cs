using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp02
{
    partial class MyClass
    {

        public int MyProperty1 { get; set; }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            myClass.MyProperty1 = 1;
            myClass.MyProperty2 = 2;
        }
    }
}
