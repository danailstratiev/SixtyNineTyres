﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SixtyNineTyres.Data.Common.Models
{
    public class Tyre
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public string Type { get; set; }

        public decimal Price { get; set; }

        public int Width { get; set; }

        public int Ratio { get; set; }

        public int Diameter { get; set; }
    }
}
