﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Question01
{
    internal interface IRectangle:IShape
    {
        double Length { get; set; }
        double Width { get; set; }

    }
}
