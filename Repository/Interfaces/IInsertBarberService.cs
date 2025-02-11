using BarberManagement.Models;

namespace BarberManagement.Repository.Interfaces
{
	public interface IInsertBarberService
	{
		public void InsertBarber(BarberAdminModel newBarber);
	}
}
