using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityDemo
{
    class Program
    {
      public  UnityContainer container;

        public Program()
        {
            #region 类型的配置容器注册
            container = new UnityContainer();
            container.RegisterType<IMyObject, MyObjectFirstImplementation>("MyObjectFirstImplementation");
            container.RegisterType<IMyObject, MyObjectSecondImplementation>("MyObjectSecondImplementation");
            container.RegisterType<IMyObject, MyObjectThirdImplementation>(); 
            #endregion
            // container.RegisterType<IMyObject, MyObjectFirstImplementation>();

        }
        static void Main(string[] args)
        {
            var factory = new MyObjectFactory(new Program().container);
            var myObj = factory.Create("MyObjectFirstImplementation");
            string str = myObj.DoSomething();
           Console.WriteLine(str);

            var myObj1 = factory.Create("MyObjectSecondImplementation");
            string str1 = myObj1.DoSomething();
            Console.WriteLine(str1);

            var myObj2 = new Program().container.Resolve<IMyObject>();

            Console.WriteLine(myObj2.DoSomething());
            var p = new Program();
            Console.WriteLine(p.Add(1, 8, 3, 4, 5, 6));


            #region 已有对象实例的配置容器注册
            IUnityContainer myContainer = new UnityContainer();
            Program myExistingObject = new Program();
            myContainer.RegisterInstance<Program>(myExistingObject);
            Program myServiceInstance = myContainer.Resolve<Program>();
            Console.WriteLine(myServiceInstance.Add(1, 8, 3, 4, 5, 6)); 
            #endregion

            Console.ReadKey();
        }

        public int Add(params int[] values)
        {
            int sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            return sum;
        }
    }
}
