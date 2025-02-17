using MediatR;

namespace CarServices.Application.CarServices.Commands.CreateCar
{
    public class CreateCarCommand : IRequest<Guid>
    {
        public Guid ServiceId { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public int Year_car { get; set; }
        public int Cost_car { get; set; }
    }
}
