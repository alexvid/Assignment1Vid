using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FurnitureManufacturer.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password;
        public bool IsAdmin { get; set; }
        
        //non bindable attribute
        public string firstName { get; set; }
        //non bindable attribute
        public string lastName { get; set; }

       
        public string FullName
        {
            get
            { return firstName + " " + lastName; }
        }





    }
}
