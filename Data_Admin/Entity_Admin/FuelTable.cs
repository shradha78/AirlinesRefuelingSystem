using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Team_Mars_Backend.Data_Admin.Entity_Admin
{
    public class FuelTable
    {


        [Key]
        public int ID { get; set; }

        [StringLength(20)]
        public string Fuel_Id { get; set; }

        [StringLength(30)]
        public string Fuel_Name { get; set; }

        public float Fuel_price { get; set; }

        public int Fuel_quantity { get; set; }

        public string Fuel_Type { get; set; }






    }
}
