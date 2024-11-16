using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarberManagement.data;
using BarberManagement.Models;
using BarberManagement.Repository;
using BarberManagement.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BarberManagement.Services
{
    public class Authentication
    {
        private readonly IUnityOfWork _uow;
        public Authentication(IUnityOfWork uow)
        {
            _uow = uow;
        }
        public  BarberAdminModel Authenticate(string name, string password)
        {
            BarberAdminModel? Barber = _uow.BarberAdminRepo.Get(
                barber => EF.Functions.Collate(barber.NameAdm,"utf8mb4_bin") == name
                 && 
                EF.Functions.Collate(barber.PasswordAdm,"utf8mb4_bin") == password);

            return Barber;
        }
    }
}