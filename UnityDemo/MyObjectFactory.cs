using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityDemo
{
    public class MyObjectFactory
    {
        public MyObjectFactory() { }

        public MyObjectFactory(UnityContainer unityContainer)
        {
            this.unityContainer = unityContainer;
        }

        public UnityContainer unityContainer;

        public IMyObject Create(string objKey)
        {
            return unityContainer.Resolve<IMyObject>(objKey);
        }
    }
}
