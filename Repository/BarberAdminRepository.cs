using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarberManagement.data;
using BarberManagement.Models;
using BarberManagement.Repository.Interfaces;

namespace BarberManagement.Repository
{
    public class BarberAdminRepository(AppDbContext context) : Repository<BarberAdminModel>(context), IBarberAdminRepository
    {
        
    }
}