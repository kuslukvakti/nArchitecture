namespace RentACar.Application.Features.Brands.Profiles
{
    using AutoMapper;
    using Core.Persistence.Paging;
    using RentACar.Application.Features.Brands.Commands.CreateBrand;
    using RentACar.Application.Features.Brands.Dtos;
    using RentACar.Application.Features.Brands.Models;
    using RentACar.Application.Features.Brands.Queries.GetByIdBrand;
    using RentACar.Domain.Entities;

    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Brand, CreatedBrandDto>().ReverseMap(); // ReverseMap çift yönlü çalışır
            CreateMap<Brand, CreateBrandCommand>().ReverseMap();
            CreateMap<Brand, GetByIdBrandQuery>().ReverseMap();

            CreateMap<IPaginate<Brand>, BrandListModel>().ReverseMap();
            CreateMap<Brand, BrandListDto>().ReverseMap();
            CreateMap<Brand, BrandGetByIdDto>().ReverseMap();
        }
    }
}
