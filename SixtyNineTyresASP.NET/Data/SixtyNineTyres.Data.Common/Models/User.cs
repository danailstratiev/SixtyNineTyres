using System;
using System.Collections.Generic;
using System.Text;

namespace SixtyNineTyres.Data.Common.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public ShoppingBag ShoppingBag { get; set; }
    }
}
