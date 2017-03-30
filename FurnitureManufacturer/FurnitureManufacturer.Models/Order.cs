using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FurnitureManufacturer.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string Customer { get; set; }
        public string Address { get; set; }
        public DateTime DeliveryDate { get; set; }
        public float Total { get; set; }
    }
}
