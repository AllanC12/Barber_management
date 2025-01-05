using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarberManagement.Repository.Interfaces
{
    public interface IUnityOfWork : IDisposable
    {
        IBarberAdminRepository BarberAdminRepo {get;}
        IClientRepository ClientRepo { get; }

        void BeginTransaction();

        void Commit();

        void Rollback();
    }
}