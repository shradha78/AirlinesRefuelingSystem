using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Team_Mars_Backend.Data_Admin.Entity_Admin
{
    public class Order
    {
        [Key]
        public int Order_id { get; set; }
        [ForeignKey("Vendor_Id")]
        public int Vendor_Id { get; set; }

        [ForeignKey("Fuel_Id")]
        public string Fuel_Id { get; set; }
       
        public int Fuel_quantity { get; set; }


    }
}
