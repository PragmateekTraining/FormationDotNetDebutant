using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsInitializers
{
    class DuckTypingSample
    {
        class A : IEnumerable
        {
            public void Add(int a, double b, string c) { }

            public IEnumerator GetEnumerator()
            {
                return null;
            }
        }

        public void Run()
        {
            A a = new A
            {
                { 1, 1.0, "1" },
                { 2, 2.0, "2" },
                { 3, 3.0, "3" }
            };
        }
    }
}
