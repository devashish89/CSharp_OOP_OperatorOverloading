using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_OOP_OperatorOverloading;

namespace ProgrsmMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new Class1("Devashish", 10);
            Class1 obj2 = new Class1();
            obj2._name = "Nigam";
            obj2._score = 20;

            Class1 obj3 = new Class1();
            obj3 = obj1 + obj2;

            Console.WriteLine(obj3._name+"||"+obj3._score);
        }
    }
}
