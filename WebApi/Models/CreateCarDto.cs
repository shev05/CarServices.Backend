using AutoMapper;
using CarServices.Application.CarServices.Commands.CreateCar;
using CarServices.Application.Common.Mappings;

namespace CarServices.WebApi.Models
{
    public class CreateCarDto : IMapWith<CreateCarCommand>
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public int Year_car { get; set; }
        public int Cost_car { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateCarDto, CreateCarCommand>()
                .ForMember(carCommand => carCommand.Mark,
                    opt => opt.MapFrom(carDto => carDto.Mark))
                .ForMember(carCommand => carCommand.Model,
                    opt => opt.MapFrom(carDto => carDto.Model))
                .ForMember(carCommand => carCommand.Year_car,
                    opt => opt.MapFrom(carDto => carDto.Year_car))
                .ForMember(carCommand => carCommand.Cost_car,
                    opt => opt.MapFrom(carDto => carDto.Cost_car));
        }
    }
}
