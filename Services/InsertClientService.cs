using BarberManagement.Models;
using BarberManagement.Repository.Interfaces;

namespace BarberManagement.Services
{
	public class InsertClientService : IInsertClientService
	{
		IUnityOfWork _uow;
		public InsertClientService(IUnityOfWork uow)
		{
			_uow = uow;
		}

		public void InsertClient(ClientModel dataClient)
		{
			try
			{
				_uow.BeginTransaction();

				_uow.ClientRepository.Create(dataClient);
				_uow.Commit();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				_uow.Rollback();
			}
		}
	}
}
