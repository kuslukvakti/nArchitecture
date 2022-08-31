namespace RentACar.Application.Features.Brands.Queries.GetListBrand
{
    using AutoMapper;
    using Core.Application.Requests;
    using Core.Persistence.Paging;
    using MediatR;
    using RentACar.Application.Features.Brands.Models;
    using RentACar.Application.Services.Repositories;
    using RentACar.Domain.Entities;
    using System.Threading;
    using System.Threading.Tasks;

    public class GetListBrandQuery : IRequest<BrandListModel>
    {
        public PageRequest PageRequest { get; set; }

        public class GetListBrandQueryHandler : IRequestHandler<GetListBrandQuery, BrandListModel>
        {
            private readonly IMapper _mapper;
            private readonly IBrandRepository _brandRepository;

            public GetListBrandQueryHandler(IBrandRepository brandRepository, IMapper mapper)
            {
                _brandRepository = brandRepository;
                _mapper = mapper;
            }

            public async Task<BrandListModel> Handle(GetListBrandQuery request, CancellationToken cancellationToken)
            {
                IPaginate<Brand> brands = await _brandRepository.GetListAsync(index: request.PageRequest.Page, size: request.PageRequest.PageSize);

                BrandListModel mappedBrandListModel = _mapper.Map<BrandListModel>(brands);

                return mappedBrandListModel;
            }
        }
    }
}
