using CarServices.Application.Interface;
using MediatR;
using CarServices.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarServices.Application.CarServices.Commands.CreateCar
{
    public class CreateCarCommandHandler
        : IRequestHandler<CreateCarCommand, Guid>
    {
        private readonly ICarServiceDbContext _dbContext;

        public CreateCarCommandHandler(ICarServiceDbContext dbContext) =>
            _dbContext = dbContext;

        public async Task<Guid> Handle(CreateCarCommand request,
            CancellationToken cancellationToken)
        {
            var car = new CarService
            {
                Mark = request.Mark,
                Model = request.Model,
                Id = Guid.NewGuid(),
                Year_car = request.Year_car,
                Cost_car = request.Cost_car,
                Status_car = true
            };
            await _dbContext.CarServices.AddAsync(car, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return car.Id;
        }

    }
}
