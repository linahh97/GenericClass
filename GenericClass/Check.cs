using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClass
{
    public class Check<Unknown>
    {
        public bool toCheck(Unknown num1, Unknown num2)
        {
            if (num1.Equals(num2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
