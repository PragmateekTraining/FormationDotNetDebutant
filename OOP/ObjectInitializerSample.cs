using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class ObjectInitializerSample
    {
        event EventHandler SomethingHappened;

        class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

        public void Run()
        {
            new Customer { ID = 1, Name = "Chuck Norris" };
        }
    }
}
