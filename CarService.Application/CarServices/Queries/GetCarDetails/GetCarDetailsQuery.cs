using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace CarServices.Application.CarServices.Queries.GetCarDetails
{
    public class GetCarDetailsQuery : IRequest<CarDetailsVm>
    {
        public Guid Id { get; set; }
        public Guid ServiceId { get; set; }

    }
}
