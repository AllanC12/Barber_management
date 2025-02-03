using System.ComponentModel.DataAnnotations;

namespace BarberManagement.Models
{
	public class BarberAdminModel
	{
		[Key]
		public int Id { get; set; }
		public string NameAdm { get; set; }
		public string PasswordAdm { get; set; }
		public string Annotations { get; set; }
		public string Especializations { get; set; }

	}
}

