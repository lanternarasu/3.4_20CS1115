using System;

namespace _3._4_20CS1115
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new Class1(2, 4);
            Class1 obj2 = new Class1(1, 4);
            if(obj1 > obj2)
            {
                Console.WriteLine("park 1 is greater");
            }
            else if(obj1 < obj2)
            {
                Console.WriteLine("park 2 is greater");
            }
            else
            {

            }
        }
    }
}
