using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServices.Application.Interface;
using MediatR;
using Microsoft.EntityFrameworkCore;
using CarServices.Application.Common.Exceptions;
using CarServices.Domain;

namespace CarServices.Application.CarServices.Commands.UpdateCar
{
    public class UpdateCarCommandHandler
        : IRequestHandler<UpdateCarCommand, Unit>
    {
        private readonly ICarServiceDbContext _dbContext;
        public UpdateCarCommandHandler(ICarServiceDbContext dbContext) =>
            _dbContext = dbContext;

        public async Task<Unit> Handle(UpdateCarCommand request,
            CancellationToken cancellationToken)
        {
            var entity =
                await _dbContext.CarServices.FirstOrDefaultAsync(car => car.Id == request.Id, cancellationToken);
            if(entity == null || entity.ServiceId != request.ServiceId) 
            {
                throw new NotFoundException(nameof(CarService), request.Id);
            }

            entity.Mark = request.Mark;
            entity.Model = request.Model;
            entity.Cost_car = request.Cost_car;
            
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
