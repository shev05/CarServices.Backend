using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CarServices.Domain;

namespace CarServices.Persistence.EntityTypeConfigurations
{
    public class CarServicesConfigurations: IEntityTypeConfiguration<CarService>
    {
        public void Configure(EntityTypeBuilder<CarService> builder)
        {
            builder.HasKey(car => car.Id);
            builder.HasIndex(car => car.Id).IsUnique();
            builder.Property(car => car.Mark).HasMaxLength(250);
            builder.Property(car => car.Model).HasMaxLength(250);

        }

    }
}
