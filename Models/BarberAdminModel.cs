using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BarberManagement.Models
{
    public class BarberAdminModel
    {   
        [Key]
        public int Id {get; set;}
        public string NameAdm {get; set;}
        public string PasswordAdm {get; set;}
        public string Annotations {get; set;}

    }
}
