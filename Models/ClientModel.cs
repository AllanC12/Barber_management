using System.ComponentModel.DataAnnotations;

namespace BarberManagement.Models
{
    public class ClientModel
    
    {   
        [Key]
        public int Id {get; set;}
        public string Name {get; set;}
        public string LastName {get; set;}
        public DateOnly Birthday {get; set;}
        public string Address {get; set;}
        public string Favorite_Service { get; set; }
        public string Observation { get; set; }
    }
}
