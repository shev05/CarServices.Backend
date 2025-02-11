using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarServices.Application.Interface;
using CarServices.Domain;
using CarServices.Persistence.EntityTypeConfigurations;

namespace CarServices.Persistence
{
    public class CarServicesDbContext : DbContext, ICarServiceDbContext
    {
        public DbSet<CarService> CarServices { get; set; }

        public CarServicesDbContext(DbContextOptions<CarServicesDbContext> opions) 
            : base(opions) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CarServicesConfigurations());
            base.OnModelCreating(builder);
        }
       
    }
}
