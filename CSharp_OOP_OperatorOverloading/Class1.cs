using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_OperatorOverloading
{
    public class Class1
    {
        public string _name="";
        public short _score=0;

        public Class1()
        {
            
        }

        public Class1(string name="", short score=0)
        {
            this._name = name;
            this._score = score;
        }

        public static Class1 operator +(Class1 obj1, Class1 obj2)
        {
            Class1 obj3 = new Class1();
            obj3._name = obj1._name + obj2._name;
            obj3._score = (short)(obj1._score + obj2._score);

            return obj3;
        }
    }


}
