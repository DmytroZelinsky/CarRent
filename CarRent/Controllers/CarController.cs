using AutoMapper;
using CarRent.DTOs;
using CarRent.Models;
using CarRent.Repositories.Interfaces;
using CarRent.Services.Interfaces;
using CarRent.ViewModels;
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
        private readonly ICarService _carService;
        private readonly IMapper _mapper;
        public CarController(ICarService carService, IMapper mapper)
        {
            _carService = carService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarView>>> GetAllCars()
        {
            var cars = await _carService.GetAllCarsAsync();
            var carsView = _mapper.Map<IEnumerable<CarView>>(cars);
            return Ok(carsView);
        }

        [HttpGet("{id}", Name = "GetCarById")]
        public async Task<ActionResult<CarView>> GetCarById(int id)
        {
            var car = await _carService.GetCarByIdAsync(id);
            var carView = _mapper.Map<CarView>(car);
            return Ok(carView);
        }

        [HttpPost]
        public async Task<ActionResult<CarView>> CreateCar(CarDTO newCar)
        {
            var car = _mapper.Map<Car>(newCar);
            await _carService.CreateCarAsync(car);
            var carView = _mapper.Map<CarView>(car);
            return CreatedAtRoute(nameof(GetCarById), new { Id = carView.CarId }, carView);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCar(int id, CarDTO updatedCar)
        {
            var car = _mapper.Map<Car>(updatedCar);
            await _carService.UpdateCarAsync(id, car);
            var carView = _mapper.Map<CarView>(car);
            return Ok(carView);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCar(int id)
        {
            await _carService.DeleteCarAsync(id);
            return Ok();
        }

    }
}
