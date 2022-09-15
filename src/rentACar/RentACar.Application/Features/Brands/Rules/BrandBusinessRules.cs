namespace RentACar.Application.Features.Brands.Rules
{
    using Core.CrossCuttingConcerns.Exceptions;
    using Core.Persistence.Paging;
    using RentACar.Domain.Entities;
    using RentACar.Application.Services.Repositories;
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

        public void BrandShouldExistWhenRequested(Brand brand)
        {
            if (brand == null) throw new BusinessException("Requested brand does not exist");
        }
    }
}
