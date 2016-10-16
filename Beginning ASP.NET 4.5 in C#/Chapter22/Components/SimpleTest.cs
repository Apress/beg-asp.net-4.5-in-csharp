using System;
using System.Collections.Generic;
using System.Text;

namespace Components
{
    public class SimpleTest
    {
        public string GetInfo(string param)
        {
            return "You invoked SimpleTest.GetInfo() with '" +
                   param + "'";
        }
    }

    public class SimpleTest2
    {
        public string GetInfo(string param)
        {
            return "You invoked SimpleTest2.GetInfo() with '" +
                   param + "'";
        }
    }

}
