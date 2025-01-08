using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Interface_Ex03
{
    internal class Car : Vechile,IMovable
    {
        public override int Speed { get; set; }

        public void Backward()
        {
            Console.WriteLine("Backward");
        }

        public void forward()
        {
            Console.WriteLine("Forward");
        }

        public void Left()
        {
            Console.WriteLine("Left"); 
        }

        public void Right()
        {
            Console.WriteLine("Right");
        }
    }
}
