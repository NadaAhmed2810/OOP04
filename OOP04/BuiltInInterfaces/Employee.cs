using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.BuiltInInterfaces
{
     class Employee:ICloneable
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public Department? Department { get; set; }
        public Employee() { }
        //Copy Constructor : Is a Special Constructor Make deep Copy
        public Employee(Employee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            Salary = employee.Salary;
            Department = (Department?)employee?.Department?.Clone();
        }
        public object Clone()
        {
            return new Employee(this);
            //return new Employee()
            //{
            //    Id = Id,
            //    Name = Name,
            //    Salary = Salary,
            //    Department =(Department?) Department?.Clone()
            //};

        }

        public override string ToString()
        {
            return $"Id:{Id},Name:{Name},Salary:{Salary},Department:{Department}";
        }


    }
}
