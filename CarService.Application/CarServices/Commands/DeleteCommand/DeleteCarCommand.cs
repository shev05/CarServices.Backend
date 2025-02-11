using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace CarServices.Application.CarServices.Commands.DeleteCommand
{
    public class DeleteCarCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public Guid ServiceId { get; set; }

    }
}
