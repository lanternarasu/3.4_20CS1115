using System;
using System.Collections.Generic;
using System.Text;

namespace _3._4_20CS1115
{
    class Class1
    {
        private int l, w,area;
        public Class1()
        {

        }
        public Class1(int a,int b)
        {
            l = a;
            w = b;
            area = l * w;
        }
        public static bool operator > (Class1 obj1,Class1 obj2)
        {
            Class1 temp1 = new Class1();
            Class1 temp2 = new Class1();
            temp1.area = obj1.area;
            temp2.area = obj2.area;
            if (temp1.area > temp2.area)
                return true;
            else
                return false;
        }
        public static bool operator <(Class1 obj1, Class1 obj2)
        {
            Class1 temp1 = new Class1();
            Class1 temp2 = new Class1();
            temp1.area = obj1.area;
            temp2.area = obj2.area;
            if (temp1.area < temp2.area)
                return true;
            else
                return false;
        }
    }
}
