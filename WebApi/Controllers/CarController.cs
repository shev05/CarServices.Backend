using AutoMapper;
using CarServices.Application.CarServices.Commands.CreateCar;
using CarServices.Application.CarServices.Commands.DeleteCommand;
using CarServices.Application.CarServices.Commands.UpdateCar;
using CarServices.Application.CarServices.Queries.GetCarDetails;
using CarServices.Application.CarServices.Queries.GetCarList;
using CarServices.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
namespace CarServices.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class CarController : BaseController
    {
        private readonly IMapper _mapper;

        public CarController(IMapper mapper) => _mapper = mapper;

        [HttpGet]
        public async Task<ActionResult<CarListVm>> GetAll()
        {
            var query = new GetCarListQuery()
            {
                ServiceId = ServiceId
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CarDetailsVm>> Get(Guid id)
        {
            var query = new GetCarDetailsQuery
            {
                ServiceId = ServiceId,
                Id = id
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateCarDto createCarDto)
        {
            var command = _mapper.Map<CreateCarCommand>(createCarDto);
            command.ServiceId = ServiceId;
            var carId = await Mediator.Send(command);
            return Ok(carId);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateCarDto updateCarDto)
        {
            var command = _mapper.Map<UpdateCarCommand>(updateCarDto);
            command.ServiceId = ServiceId;
            command.Id = id;
            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delee(Guid id)
        {
            var command = new DeleteCarCommand
            {
                Id = id,
                ServiceId = ServiceId
            };
            await Mediator.Send(command);
            return NoContent();
        }
    }
}
