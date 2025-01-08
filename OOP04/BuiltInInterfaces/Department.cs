using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP04.BuiltInInterfaces
{
    internal class Department: ICloneable
    {
        public int Code { get; set; }
        public string? Title { get; set; }

        public object Clone()
        {
            return new Department() {Code=Code,Title=Title };
        }
        public override string ToString()
        {
            return $"Code:{Code},Title:{Title}";
        }
    }
}
