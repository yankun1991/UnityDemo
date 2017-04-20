using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityDemo
{
    public class MyObjectFirstImplementation : IMyObject
    {
        public string DoSomething()
        {
            return "You call me ? I am the first one,  I am from MyObjectFirstImplementation!! ";
        }
    }
}
