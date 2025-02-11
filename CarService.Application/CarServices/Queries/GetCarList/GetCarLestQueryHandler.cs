using AutoMapper;
using AutoMapper.QueryableExtensions;
using CarServices.Application.Interface;
using CarServices.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace CarServices.Application.CarServices.Queries.GetCarList
{
    public class GetCarLestQueryHandler
        :IRequestHandler<GetCarListQuery, CarListVm>
    {
        private readonly ICarServiceDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetCarLestQueryHandler(ICarServiceDbContext dbContext, 
            IMapper mapper) => (_dbContext, _mapper) = (dbContext, mapper); 
        
        public async Task<CarListVm> Handle(GetCarListQuery request, 
            CancellationToken cancellationToken)
        {
            var carsQuery = await _dbContext.CarServices
                .Where(car => car.ServiceId == request.ServiceId)
                .ProjectTo<CarLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync();

            return new CarListVm { Cars = carsQuery };

        }
    }
}
