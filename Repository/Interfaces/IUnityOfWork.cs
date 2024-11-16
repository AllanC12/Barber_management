using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarberManagement.Repository.Interfaces
{
    public interface IUnityOfWork : IDisposable
    {
        IBarberAdminRepository BarberAdminRepo {get;}

        void BeginTransaction();

        void Commit();

        void Rollback();
    }
}