using AutoMapper;
using CarServices.Application.Common.Exceptions;
using CarServices.Application.Interface;
using CarServices.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CarServices.Application.CarServices.Queries.GetCarDetails
{
    public class GetCarDetailsQueryHandler
        : IRequestHandler<GetCarDetailsQuery, CarDetailsVm>
    {
        private readonly ICarServiceDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetCarDetailsQueryHandler (ICarServiceDbContext dbContext, 
            IMapper mapper) => (_dbContext, _mapper) = (dbContext, mapper);

        public async Task<CarDetailsVm> Handle(GetCarDetailsQuery request, 
            CancellationToken cancellationToken)
        {
            var entity =
                await _dbContext.CarServices.FirstOrDefaultAsync(car => car.Id == request.Id, cancellationToken);
            if (entity == null || entity.ServiceId != request.ServiceId)
            {
                throw new NotFoundException(nameof(CarService), request.Id);
            }

            return _mapper.Map<CarDetailsVm>(entity);
        }
    }
}
