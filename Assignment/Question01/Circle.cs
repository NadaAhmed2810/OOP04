using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Question01
{
    internal class Circle : ICircle
    {
        public double Radius { get; set; }

        public double Area => 3.14*Math.Pow(Radius,2);
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle: Radius = {Radius}, Area = {Area}");
        }
    }
}
