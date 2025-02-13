using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace CarServices.Application.CarServices.Commands.UpdateCar
{
    public class UpdateCarCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public Guid ServiceId { get; set; }
        public DateTime Year_car { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public int Cost_car { get; set; }
    }
}
