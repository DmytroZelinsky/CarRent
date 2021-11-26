using CarRent.Models;
using CarRent.Repositories.Interfaces;

namespace CarRent.Repositories.Implementations
{
    public class CarRepo : BaseRepo<Car>, ICarRepo
    {
        public CarRepo(CarRentDBContext dbContext) 
            : base(dbContext)
        {
        }
    }
}
