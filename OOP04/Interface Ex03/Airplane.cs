using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Interface_Ex03
{
    internal class Airplane : Vechile,IMovable,IFlyable
    {
        public override int Speed { get; set; }
        //must be private 
        //i want forward must make reference from Imoveable
        void IFlyable.Backward()
        {
            Console.WriteLine("airplane move backward on Air");
        }

        void IMovable.Backward()
        {
            Console.WriteLine("airplane move backward on Ground");
        }

        //void IFlyable.forward()
        //{
        //    throw new NotImplementedException();
        //}

        //void IMovable.forward()
        //{
        //    throw new NotImplementedException();
        //}

        //void IFlyable.Left()
        //{
        //    throw new NotImplementedException();
        //}

        //void IMovable.Left()
        //{
        //    throw new NotImplementedException();
        //}

        //void IFlyable.Right()
        //{
        //    throw new NotImplementedException();
        //}

        //void IMovable.Right()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
