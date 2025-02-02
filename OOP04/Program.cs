﻿using OOP04.BuiltInInterfaces;
using OOP04.Interface_Ex01;
using OOP04.Interface_Ex02;
using OOP04.Interface_Ex03;

namespace OOP04
{
    internal class Program
    {
        static void PrintTenNumbersFromSeries(ISeries seriesByTwo)
        {
            if (seriesByTwo != null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(seriesByTwo.Current);
                    seriesByTwo.GetNext();
                }
                seriesByTwo.Reset();
            }
        }
        static void Main(string[] args)
        {
            #region Interface Example01
            //IType reference;
            //Refer for reference of Type "IType"[ Containing Garbage Value]
            //Can Refer to an Object any type implementing IType interface
            //ClR will allocate 4 byte in stack
            //Clr Will allocate 0 Byte in heap 
            //reference = new TypeA();
            //reference.MyProperty = 22;
            //reference.Print();
            //reference.MyMethod();
            //TypeA type=new TypeA();
            //type.MyMethod();
            //type.MyProperty = 3;
            //type.Print(); Invalid  
            #endregion
            #region Interface Example02
            ////TypeB Has Behaviour series
            //TypeB seriesByTwo = new TypeB();
            //PrintTenNumbersFromSeries(seriesByTwo);
            //TypeC seriesByThree = new TypeC();
            //PrintTenNumbersFromSeries(seriesByThree);
            //TypeD seriesByFour = new TypeD();
            //PrintTenNumbersFromSeries(seriesByFour);
            #endregion
            #region Interface Ex03
            //Airplane airplane = new Airplane();
            //airplane.Speed = 180;
            ////airplane.forward();//Not correct
            //IFlyable flyable=airplane;
            //flyable.Backward();
            //IMovable moveable = airplane;
            //moveable.Backward();
            #endregion
            #region Shallow Copy Vs Deep Copy 
            //int[] Arr01= [1, 2, 3 ];

            //int[] Arr02 = [ 4, 5, 6 ];
            //Console.WriteLine($"Arr01.GetHashCode()={Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02.GetHashCode()={Arr02.GetHashCode()}");
            #region shallow 
            //[Shallow Copy] from Stack 
            //object of Arr01 Has two reference
            // object of Arr02 unreachable object 
            //Arr02 = Arr01;
            //Console.WriteLine("After Shallow Copy:"); 
            #endregion
            #region Deep in case array of value type
            //Arr02 = (int[])Arr01.Clone();
            //return object 
            //Clone Method: Will Generate New Object with New and Different Identity
            //            : This Object Will Have The Same State [Data] of the Caller Object 
            //Console.WriteLine($"Arr01.GetHashCode()={Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02.GetHashCode()={Arr02.GetHashCode()}");
            //Arr02[0] = 100;
            //Console.WriteLine(Arr01[0]);
            #endregion

            #endregion
            #region deep in case reference type 
            //string[] Names = {"Amr", "Mona"};
            //string[] Names2 = { "Ahmed", "Nour" };
            //Console.WriteLine(Names.GetHashCode());
            //Console.WriteLine(Names2.GetHashCode());
            //Names2= (string[])Names.Clone();
            //Clone Method :Will Generate New object with New and Different Identity
            //             :The Object Will Has the same state[Data] pf the original object[Shallow copy of the Item ]
            //Console.WriteLine("After deep copy:");
            //Console.WriteLine(Names.GetHashCode());
            //Console.WriteLine(Names2.GetHashCode());
            //Names2[0] = new string("Khalad");
            //Console.WriteLine(Names[0]); 
            #endregion
            #region Built_In Interfaces ICloneable
            //Employee employee = new Employee() { Id = 10, Name = "Ahmed", Salary = 5000, Department = new Department() {Code=10,Title="sales" } };
            //Employee employee2 = new Employee() { Id = 20, Name = "Omnia", Salary = 7000, Department = new Department() { Code = 20, Title = "HR" }  };
            //Console.WriteLine(employee.GetHashCode());
            //Console.WriteLine(employee2.GetHashCode());
            //employee2 = (Employee)employee.Clone();
            //employee2=new Employee(employee);
            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine(employee.GetHashCode());
            //Console.WriteLine(employee2.GetHashCode());
            //Console.WriteLine("*******************");
            //Console.WriteLine(employee);
            //Console.WriteLine(employee2);
            //employee2.Salary = 10000;
            //if (employee2.Department is not null)
            //    employee2.Department.Title = "NEW";
            //Console.WriteLine("*******************");
            //Console.WriteLine(employee);
            //Console.WriteLine(employee2); 
            #endregion
            #region BuiltIN Interface ICompareable and Icomparer
            //int[] Numbers = [9, 4, -1, 10, 2, 7, 5, 6];
            //Array.Sort(Numbers);
            //foreach (int i in Numbers)
            //{
            //    Console.WriteLine(i);

            //}
            //Employee[] employees = 
            //{ 
            //    new Employee(){Id=3,Name="ahmed",Salary=60000,Department =new Department(){Code=1001,Title="Sales" } },
            //     new Employee(){Id=2,Name="Ali",Salary=5000,Department =new Department(){Code=1002,Title="HR" } },
            //     new Employee(){Id=4,Name="Nada",Salary=50000,Department =new Department(){Code=1001,Title="Sales" } },
            //      new Employee(){Id=5,Name="Omnia",Salary=53000,Department =new Department(){Code=1003,Title="HR" } }
            //};
            //Array.Sort(employees,new EmployeeComparer());
            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}
            #endregion
            #region Sort Array of interger des
            //int[] Numbers = [1, 4, 5, 6, 7, 9, -5, 8];
            //Array.Sort(Numbers);
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}
            #endregion




        }
    }
}
