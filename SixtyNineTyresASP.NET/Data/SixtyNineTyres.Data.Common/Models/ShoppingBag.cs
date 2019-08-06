using System;
using System.Collections.Generic;
using System.Text;

namespace SixtyNineTyres.Data.Common.Models
{
    public class ShoppingBag
    {
        public List<Tyre> Tyres { get; set; }

        public decimal TotalPrice { get; set; }

    }
}
