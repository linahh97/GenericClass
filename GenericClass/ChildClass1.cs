using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClass
{
    public class ChildClass1 : Check<int>
    {
        public static bool toCheck(int n1, int n2)
        {
            return n1 == n2;
        }
    }
}
