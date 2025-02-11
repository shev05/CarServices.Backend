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

        public void Mapping(Profile profile) 
        {
            profile.CreateMap<CarService, CarLookupDto>()
                .ForMember(carDto => carDto.Id,
                opt => opt.MapFrom(car => car.Id))
                .ForMember(carDto => carDto.Mark,
                opt => opt.MapFrom(car => car.Mark))
                .ForMember(carDto => carDto.Model,
                opt => opt.MapFrom(car => car.Model));
        }
    }
}
