using System;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            bool notok = ChildClass1.toCheck(20, 25);
            if (notok)
            {
                Console.WriteLine("Equal : {0}", notok);
            }
            else
            {
                Console.WriteLine("Not Equal : {0}", notok);
            }

            bool ok = ChildClass1.toCheck(50, 50);
            if (ok)
            {
                Console.WriteLine("Equal : {0}", ok);
            }
            else
            {
                Console.WriteLine("Not Equal : {0}", ok);
            }

            bool NotNice = ChildClass2.toCheck("lmao", "rofl");
            if (NotNice)
            {
                Console.WriteLine("Equal : {0}", NotNice);
            }
            else
            {
                Console.WriteLine("Not Equal : {0}", NotNice);
            }

            bool Nice = ChildClass2.toCheck("lol", "lol");
            if (Nice)
            {
                Console.WriteLine("Equal : {0}", Nice);
            }
            else
            {
                Console.WriteLine("Not Equal : {0}", Nice);
            }
            Console.ReadKey();
        }
    }
}
