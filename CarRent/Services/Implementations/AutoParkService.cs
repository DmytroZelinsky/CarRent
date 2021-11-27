using CarRent.Models;
using CarRent.Repositories.Interfaces;
using CarRent.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRent.Services.Implementations
{
    public class AutoParkService : IAutoParkService
    {
        private readonly IAutoParkRepo _autoParkRepo;

        public AutoParkService(IAutoParkRepo autoParkRepo)
        {
            _autoParkRepo = autoParkRepo;
        }

        public async Task<IEnumerable<AutoPark>> GetAllAutoParks()
        {
            return await _autoParkRepo.GetAllAsync(include: 
                source => source
                .Include(x => x.Address));
        }

        public async Task<AutoPark> GetAutoParkByIdAsync(int id)
        {
            return await _autoParkRepo.GetFirstAsync(x => x.AutoParkId == id,
                source => source
                .Include(x => x.Address)
                .Include(x => x.Cars)
                    .ThenInclude(x => x.CarService));
        }
    }
}
