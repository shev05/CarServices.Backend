using MediatR;

namespace CarServices.Application.CarServices.Commands.UpdateCar
{
    public class UpdateCarCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public Guid ServiceId { get; set; }
        public int Year_car { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public int Cost_car { get; set; }
    }
}
