namespace BarberManagement.Repository.Interfaces
{
	public interface IUnityOfWork : IDisposable
	{
		IBarberAdminRepository BarberAdminRepository { get; }
		IClientRepository ClientRepository { get; }

		void BeginTransaction();

		void Commit();

		void Rollback();
	}
}