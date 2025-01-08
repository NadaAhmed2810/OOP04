using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Question01
{
    internal class Rectangle : IRectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public double Area => Length*Width;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle: Length = {Length}, Width = {Width}, Area = {Area}");
        }
    }
}
