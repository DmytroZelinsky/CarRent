using CarRent.Models;
using CarRent.Repositories.Interfaces;

namespace CarRent.Repositories.Implementations
{
    public class AutoParkRepo : BaseRepo<AutoPark>, IAutoParkRepo
    {
        public AutoParkRepo(CarRentDBContext dbContext) 
            : base(dbContext)
        {
        }
    }
}
