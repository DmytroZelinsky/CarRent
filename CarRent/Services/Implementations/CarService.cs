using CarRent.Models;
using CarRent.Repositories.Interfaces;
using CarRent.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRent.Services.Implementations
{
    public class CarService : ICarService
    {
        private readonly ICarRepo _carRepo;

        public CarService(ICarRepo carRepo)
        {
            _carRepo = carRepo;
        }

        public async Task CreateCarAsync(Car car)
        {
            await _carRepo.CreateAsync(car);
            await _carRepo.SaveChangesAsync();
        }

        public async Task DeleteCarAsync(int id)
        {
            var car = await GetCarByIdAsync(id);
            _carRepo.Delete(car);
            await _carRepo.SaveChangesAsync();
        }
        public async Task UpdateCarAsync(int id, Car car)
        {
            car.CarId = id;
            _carRepo.Update(car);
            await _carRepo.SaveChangesAsync();
        }

        public Task<IEnumerable<Car>> GetAllCarsAsync()
        {
            return _carRepo.GetAllAsync();
        }

        public Task<Car> GetCarByIdAsync(int id)
        {
            return _carRepo.GetFirstAsync(x => x.CarId == id);
        }
    }
}
