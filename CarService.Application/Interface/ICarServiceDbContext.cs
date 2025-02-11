using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarServices.Domain;

namespace CarServices.Application.Interface
{
    public interface ICarServiceDbContext
    {
        DbSet<CarService> CarServices { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
