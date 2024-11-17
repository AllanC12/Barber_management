using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public UnityOfWork(AppDbContext context){
            _context = context;
        }

        public IBarberAdminRepository BarberAdminRepo{
            get{
                return _barberAdminRepo ??= new BarberAdminRepository(_context);
            }
        }

        public void BeginTransaction(){
            _context.Database.BeginTransaction();

        }

        public void Commit(){
            _context.SaveChanges(); 
            _context.Database.CommitTransaction();
        }

        public void Rollback(){
            _context.Database.RollbackTransaction();
        }

        public void Dispose() {
            _transaction?.Dispose();
        }

    }
}