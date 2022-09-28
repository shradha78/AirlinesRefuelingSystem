using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Team_Mars_Backend.Data_Admin.Entity_Admin
{
    public class AdminTable { 
    
       
            [Key]
            public int ID { get; set; }
            
            [StringLength(20)]
            public string Admin_Id { get; set;}
            [MinLength(10), MaxLength(11)]
            public long Phone_number { get; set; }
            [EmailAddress]
            public string email { get; set; }
            [StringLength(30)]
            public string Company_Name { get; set; }

            [MinLength(8), MaxLength(12)]
            public string Password { get; set; }
        
    }
}
