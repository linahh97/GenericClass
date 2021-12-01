using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClass
{
    public class ChildClass2 : Check<string>
    {
        public static bool toCheck(string n1, string n2)
        {
            return n1 == n2;
        }
    }
}
