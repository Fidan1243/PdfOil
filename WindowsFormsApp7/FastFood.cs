﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class FastFood
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
