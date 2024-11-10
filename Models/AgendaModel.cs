using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BarberManagement.Models
{
    public class AgendaModel
    {
        public DateTime Time_service {get; set; }
        [ForeignKey("")]
        public int AdmModelId {get; set; }
        public int ServicesModelId {get; set; }
        public int ClientModelId {get; set; }
    }
}