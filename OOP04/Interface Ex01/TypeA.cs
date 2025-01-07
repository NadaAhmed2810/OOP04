using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Interface_Ex01
{
    internal class TypeA : IType
    {
        public int MyProperty { get =>MyProperty; set => MyProperty=value; }

        public void MyMethod()
        {
            Console.WriteLine("Hello,World");
        }
    }
}
