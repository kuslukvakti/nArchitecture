namespace RentACar.Application.Features.Brands.Rules
{
    using Application.Services.Repositories;
    using Core.CrossCuttingConcerns.Exceptions;
    using Core.Persistence.Paging;
    using Domain.Entities;
    using System.Linq;
    using System.Threading.Tasks;

    public class BrandBusinessRules
    {
        private readonly IBrandRepository _brandRepository;

        public BrandBusinessRules(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task BrandNameCanNotBeDuplicatedWhenInserted(string name)
        {
            IPaginate<Brand> result = await _brandRepository.GetListAsync(b => b.Name == name);

            if (result.Items.Any()) throw new BusinessException("Brand name exists.");
        }

        public async Task BrandShouldExistWhenRequested(int id)
        {
            Brand? brand = await _brandRepository.GetAsync(b => b.Id == id);

            if (brand ==  null) throw new BusinessException("Request brand does not exist.");
        }
    }
}
