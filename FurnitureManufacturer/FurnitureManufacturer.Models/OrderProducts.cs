using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FurnitureManufacturer.Models
{
    public class OrderProducts
    {
        public int IDOrder;
        public int IDProduct { get; set; }
        public int Quantity { get; set; }
    }
}
