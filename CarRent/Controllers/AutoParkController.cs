using AutoMapper;
using CarRent.Services.Interfaces;
using CarRent.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoParkController : ControllerBase
    {
        private readonly IAutoParkService _autoParkService;
        private readonly IMapper _mapper;

        public AutoParkController(IAutoParkService autoParkService, IMapper mapper)
        {
            _autoParkService = autoParkService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AutoParkView>>> GetAllAutoParks()
        {
            var autoParks = await _autoParkService.GetAllAutoParks();
            var autoParkView = _mapper.Map<IEnumerable<AutoParkView>>(autoParks); 
            return Ok(autoParkView);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AutoParkView>> GetAutoParkById(int id)
        {
            var autoPark = await _autoParkService.GetAutoParkByIdAsync(id);
            var autoParkView = _mapper.Map<AutoParkView>(autoPark); 
            return Ok(autoParkView);
        }
    }
}
