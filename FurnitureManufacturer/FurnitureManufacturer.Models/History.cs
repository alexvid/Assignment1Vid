using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FurnitureManufacturer.Models
{
    public class History
    {
        public int ID { get; set; }
        public int IDEmployee { get; set; }
        public int IDOperation { get; set; }
        public string TableName { get; set; }
        public DateTime Date { get; set; }
    }
}
