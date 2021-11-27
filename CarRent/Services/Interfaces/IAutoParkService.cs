using CarRent.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRent.Services.Interfaces
{
    public interface IAutoParkService
    {
        Task<IEnumerable<AutoPark>> GetAllAutoParks();
        Task<AutoPark> GetAutoParkByIdAsync(int id);
    }
}
