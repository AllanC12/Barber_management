using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BarberManagement.Models
{
    public class CustomerModel
    
    {   
        [Key]
        public int Id {get; set;}
        public string Name {get; set;}
        public string LastName {get; set;}
        public DateTime Birthday {get; set;}
        public string Address {get; set;}
    }
}
