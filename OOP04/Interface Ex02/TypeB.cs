using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Interface_Ex02
{
    internal class TypeB:ISeries
    {
            //private int current;
            //public int Current { get => current ; set => current=value; }
            public int Current { get; set; }

            public void GetNext()
            {

                Current += 2;
            }

    }
}

