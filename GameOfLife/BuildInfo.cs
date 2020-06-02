﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class BuildInfo
    {
        public bool RandomBuild { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public double Probability { get; set; } 
        public int Iterations { get; set; }
        
    }
}
