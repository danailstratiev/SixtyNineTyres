using System;
using System.Collections.Generic;
using System.Text;

namespace SixtyNineTyres.Data.Common.Models
{
   public class Order
    {
        public string Id { get; set; }

        public DateTime DateOfCreation { get; set; }

        public DateTime DeliveryDate { get; set; }

        public DeliveryDestination DeliveryDestination { get; set; }
    }
}
