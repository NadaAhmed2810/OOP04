using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Interface_Ex02
{
    internal interface ISeries
    {
        public int Current { get; set; }
        public void GetNext();
        //default Implemented method
       public void Reset()
        {
            Current = 0;
        }
    }
}
