using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Question01
{
    internal interface IShape
    {
        public double Area {  get; }
        public void DisplayShapeInfo();
    }
}
