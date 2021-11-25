using CarRent.Models;
using CarRent.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarRepo _carRepo;

        public CarController(ICarRepo carRepo)
        {
            _carRepo = carRepo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Car>>> GetAllCars()
        {
            return Ok(await _carRepo.GetAllAsync());  
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Car>> GetCarById(int id)
        {
            return Ok(await _carRepo.GetFirstAsync(x => x.CarId == id));
        }
    }
}
