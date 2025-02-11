using System;
using MediatR;

namespace CarServices.Application.CarServices.Commands.CreateCar
{
    public class CreateCarCommand : IRequest<Guid>
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public int Cost_car { get; set; }
    }
}
