using CarRent.Models;
using CarRent.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRent.Services.Interfaces
{
    public interface ICarService
    {
        Task<IEnumerable<Car>> GetAllCarsAsync();
        Task<Car> GetCarByIdAsync(int id);
        Task CreateCarAsync(Car car);
        Task DeleteCarAsync(int id);
        Task UpdateCarAsync(int id, Car car);
    }   
}
