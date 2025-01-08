using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Interface_Ex02
{
    internal class TypeD:ISeries
    {
        public int Current { get; set; }

        public void GetNext()
        {

            Current += 4;
        }

      
    }
}
