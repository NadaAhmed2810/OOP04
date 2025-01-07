using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Interface_Ex01
{
    internal interface IType
    {
       
        /// /public is default Access Modifier inside interface And private is not Allowed For Signature Only [property and method]
       
        //What you can write Inter Interface?
        //1.Signature For Property [type ,has set or get]
        //not generate BacKing field
         int MyProperty { get; set; }
        //2.Signature For Methods
         void MyMethod();
        //3.Default Implemented Methods [C# 8.0 New Feature [.Net 3.1 2019]]
        //Can Be private 
        //Abstraction  [i need in Class Like I need Swap method in Sorting Class  ]
        /*public*/ void Print()
        {
            Console.WriteLine("Default Implemented Methods ");
           
        }
        //4. static Member [field ,property,methods] [C# 8.0 New Feature [.Net 3.1 2019]]

    }
}
