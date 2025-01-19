using BarberManagement.data;
using BarberManagement.Repository.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;

namespace BarberManagement.Repository
{
	public class UnityOfWork : IUnityOfWork
	{
		protected AppDbContext _context;
		private IDbContextTransaction _transaction;

		private IBarberAdminRepository _barberAdminRepo;
		private IClientRepository _clientRepo;

		public UnityOfWork(AppDbContext context)
		{
			_context = context;
		}

		public IBarberAdminRepository BarberAdminRepository
		{
			get
			{
				return _barberAdminRepo ??= new BarberAdminRepository(_context);
			}
		}

		public IClientRepository ClientRepository
		{
			get
			{
				return _clientRepo ??= new ClientRepository(_context);
			}
		}

		public void BeginTransaction()
		{
			_context.Database.BeginTransaction();

		}

		public void Commit()
		{
			_context.SaveChanges();
			_context.Database.CommitTransaction();
		}

		public void Rollback()
		{
			_context.Database.RollbackTransaction();
		}

		public void Dispose()
		{
			_transaction?.Dispose();
		}

	}
}