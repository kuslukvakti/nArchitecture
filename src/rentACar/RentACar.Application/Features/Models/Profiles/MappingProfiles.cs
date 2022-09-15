namespace RentACar.Application.Features.Models.Profiles
{
    using AutoMapper;
    using Core.Persistence.Paging;
    using RentACar.Domain.Entities;
    using RentACar.Application.Features.Models.Dtos;
    using RentACar.Application.Features.Models.Models;

    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Model, ModelListDto>()
                .ForMember(c => c.BrandName, opt => opt.MapFrom(c => c.Brand.Name))
                .ReverseMap();

            CreateMap<IPaginate<Model>, ModelListModel>().ReverseMap();
        }
    }
}
