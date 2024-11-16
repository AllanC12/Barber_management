using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BarberManagement.Models
{
    public class BarberServiceModel
    {   
        [Key]
        public int Id {get; set;}
        public string ServiceName {get; set;}
        public decimal ServicePrice {get; set;}
    }
}