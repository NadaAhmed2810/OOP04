using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.BuiltInInterfaces
{
    internal class EmployeeComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Employee? employee01 = (Employee?)x;
            Employee? employee02 = (Employee?)y;
            return employee01?.Id.CompareTo(employee02?.Id) ?? (employee02 is null ? 0 : -1);
        }
  
    }
}
