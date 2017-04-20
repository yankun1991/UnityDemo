using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityDemo
{
    public class MyObjectSecondImplementation : IMyObject
    {
        public string DoSomething()
        {
            return "You call me ? I am the second one, I am from MyObjectSecondImplementation!! ";
        }
    }
}
