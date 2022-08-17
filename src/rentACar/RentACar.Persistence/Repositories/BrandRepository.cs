namespace RentACar.Persistence.Repositories
{
    using Core.Persistence.Repositories;
    using Domain.Entities;
    using RentACar.Application.Services.Repositories;
    using RentACar.Persistence.Contexts;

    public class BrandRepository : EfRepositoryBase<Brand, BaseDbContext>, IBrandRepository
    {
        public BrandRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
