namespace RentACar.Persistence.Repositories
{
    using RentACar.Application.Services.Repositories;
    using Core.Persistence.Repositories;
    using RentACar.Domain.Entities;
    using RentACar.Persistence.Contexts;

    public class BrandRepository : EfRepositoryBase<Brand, BaseDbContext>, IBrandRepository
    {
        public BrandRepository(BaseDbContext context) : base(context)
        {
        }

    }
}