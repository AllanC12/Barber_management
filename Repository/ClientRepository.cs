using BarberManagement.data;
using BarberManagement.Models;
using BarberManagement.Repository.Interfaces;

namespace BarberManagement.Repository
{
    public class ClientRepository(AppDbContext context) : Repository<ClientModel>(context) , IClientRepository
    {
    }
}
