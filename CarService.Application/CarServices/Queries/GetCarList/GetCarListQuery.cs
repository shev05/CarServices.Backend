using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace CarServices.Application.CarServices.Queries.GetCarList
{
    public class GetCarListQuery : IRequest<CarListVm> 
    {
        public Guid ServiceId { get; set; }
    }
}
