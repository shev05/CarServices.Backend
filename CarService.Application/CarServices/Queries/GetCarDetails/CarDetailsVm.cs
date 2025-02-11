using CarServices.Application.Common.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServices.Domain;
using AutoMapper;

namespace CarServices.Application.CarServices.Queries.GetCarDetails
{
    public class CarDetailsVm : IMapWith<CarService>
    {
        public Guid Id { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public DateTime Year_car { get; set; }
        public int Cost_car { get; set; }
        public bool Status_car { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CarService, CarDetailsVm>()
                .ForMember(carVm => carVm.Mark,
                opt => opt.MapFrom(car => car.Mark))
                .ForMember(carVm => carVm.Model,
                opt => opt.MapFrom(car => car.Model))
                .ForMember(carVm => carVm.Year_car,
                opt => opt.MapFrom(car => car.Year_car))
                .ForMember(carVm => carVm.Cost_car,
                opt => opt.MapFrom(car => car.Cost_car))
                .ForMember(carVm => carVm.Status_car,
                opt => opt.MapFrom(car => car.Status_car));
        }
    }
}
