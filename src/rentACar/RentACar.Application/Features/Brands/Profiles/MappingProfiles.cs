namespace RentACar.Application.Features.Brands.Profiles
{
    using AutoMapper;
    using RentACar.Application.Features.Brands.Commands.CreateBrand;
    using RentACar.Application.Features.Brands.Dtos;
    using RentACar.Domain.Entities;

    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Brand, CreatedBrandDto>().ReverseMap(); // ReverseMap çift yönlü çalışır
            CreateMap<Brand, CreateBrandCommand>().ReverseMap();
        }
    }
}
