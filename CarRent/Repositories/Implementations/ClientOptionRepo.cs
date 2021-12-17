using CarRent.Models;
using CarRent.Repositories.Interfaces;

namespace CarRent.Repositories.Implementations
{
    public class ClientOptionRepo : BaseRepo<ClientOption>, IClientOptionRepo
    {
        public ClientOptionRepo(CarRentDBContext dbContext) : base(dbContext)
        {
        }
    }
}
