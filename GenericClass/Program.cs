using System;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            ChildClass1 c1 = new ChildClass1();
            bool notok = c1.toCheck(20, 25);
            Console.WriteLine("Result: Not Equal: {0}", notok);
           
            ChildClass1 c2 = new ChildClass1();
            bool ok = c2.toCheck(50, 50);
            Console.WriteLine("Result: Equal: {0}", ok);

            ChildClass2 c3 = new ChildClass2();
            bool NotNice = c3.toCheck("lmao", "rofl");
            Console.WriteLine("Result: Not Equal: {0}", NotNice);

            ChildClass2 c4 = new ChildClass2();
            bool Nice = c4.toCheck("lol", "lol");
            Console.WriteLine("Result: Equal: {0}", Nice);
           
            Console.ReadKey();
        }
    }
}
