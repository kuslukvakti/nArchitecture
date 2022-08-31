namespace RentACar.Application.Features.Brands.Queries.GetByIdBrand
{
    using AutoMapper;
    using Core.Persistence.Paging;
    using MediatR;
    using RentACar.Application.Features.Brands.Dtos;
    using RentACar.Application.Features.Brands.Models;
    using RentACar.Application.Features.Brands.Queries.GetListBrand;
    using RentACar.Application.Features.Brands.Rules;
    using RentACar.Application.Services.Repositories;
    using RentACar.Domain.Entities;
    using System.Threading;
    using System.Threading.Tasks;

    public class GetByIdBrandQuery : IRequest<BrandGetByIdDto>
    {
        public int Id { get; set; }

        public class GetByIdBrandQueryHandler : IRequestHandler<GetByIdBrandQuery, BrandGetByIdDto>
        {
            private readonly IMapper _mapper;
            private readonly IBrandRepository _brandRepository;
            private readonly BrandBusinessRules _brandBusinessRules;

            public GetByIdBrandQueryHandler(IBrandRepository brandRepository, IMapper mapper, BrandBusinessRules brandBusinessRules = null)
            {
                _brandRepository = brandRepository;
                _mapper = mapper;
                _brandBusinessRules = brandBusinessRules;
            }

            public async Task<BrandGetByIdDto> Handle(GetByIdBrandQuery request, CancellationToken cancellationToken)
            {
                await _brandBusinessRules.BrandShouldExistWhenRequested(request.Id);

                Brand brand = await _brandRepository.GetAsync(b=> b.Id == request.Id);

                BrandGetByIdDto brandGetByIdDto = _mapper.Map<BrandGetByIdDto>(brand);  

                return brandGetByIdDto;
            }
        }
    }
}
