using CarServices.Application.Common.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using CarServices.Domain;
using AutoMapper;

namespace CarServices.Application.CarServices.Queries.GetCarList
{
    public class CarLookupDto : IMapWith<CarService>
    {
        public Guid Id { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public int Year_car { get; set; }
        public int Cost_car { get; set; }
        public bool Status_car { get; set; }


        public void Mapping(Profile profile) 
        {
            profile.CreateMap<CarService, CarLookupDto>()
                .ForMember(carDto => carDto.Id,
                opt => opt.MapFrom(car => car.Id))
                .ForMember(carDto => carDto.Mark,
                opt => opt.MapFrom(car => car.Mark))
                .ForMember(carDto => carDto.Model,
                opt => opt.MapFrom(car => car.Model))
                .ForMember(carDto => carDto.Year_car,
                opt => opt.MapFrom(car => car.Year_car))
                .ForMember(carDto => carDto.Cost_car,
                opt => opt.MapFrom(car => car.Cost_car))
                .ForMember(carDto => carDto.Status_car,
                opt => opt.MapFrom(car => car.Status_car));

        }
    }
}
