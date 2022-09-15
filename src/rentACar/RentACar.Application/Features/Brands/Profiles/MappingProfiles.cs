namespace RentACar.Application.Features.Brands.Profiles
{
    using AutoMapper;
    using Core.Persistence.Paging;
    using RentACar.Domain.Entities;
    using RentACar.Application.Features.Brands.Commands.CreateBrand;
    using RentACar.Application.Features.Brands.Dtos;
    using RentACar.Application.Features.Brands.Models;

    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Brand, CreatedBrandDto>().ReverseMap();
            CreateMap<Brand, CreateBrandCommand>().ReverseMap();
            CreateMap<IPaginate<Brand>, BrandListModel>().ReverseMap();
            CreateMap<Brand, BrandListDto>().ReverseMap();
            CreateMap<Brand, BrandGetByIdDto>().ReverseMap();
        }
    }
}
