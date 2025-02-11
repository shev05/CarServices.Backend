using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using CarServices.Application.Interface;
using CarServices.Application.Common.Exceptions;
using CarServices.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarServices.Application.CarServices.Commands.DeleteCommand
{
    public class DeleteCarCommandHandler 
        : IRequestHandler<DeleteCarCommand, Unit>
    {
        private readonly ICarServiceDbContext _dbContext;
        public async Task<Unit> Handle(DeleteCarCommand request,
            CancellationToken cancellationToken)
        {
            var entity =
                await _dbContext.CarServices.FirstOrDefaultAsync(car => car.Id == request.Id, cancellationToken);
            if (entity == null || entity.ServiceId != request.ServiceId)
            {
                throw new NotFoundException(nameof(CarService), request.Id);
            }
            _dbContext.CarServices.Remove(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
