using BarberManagement.Models;
using BarberManagement.Repository.Interfaces;

namespace BarberManagement.Services
{
	public class InsertBarberService : IInsertBarberService
	{
		IUnityOfWork _uow;

		public InsertBarberService(IUnityOfWork uow)
		{
			_uow = uow;
		}

		public void InsertBarber(BarberAdminModel newBarber)
		{
			_uow.BarberAdminRepository.Create(newBarber);
		}
	}
}
