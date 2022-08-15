namespace Persistence.Repositories
{
    using Application.Services.Repositories;
    using Core.Persistence.Repositories;
    using Domain.Entities;
    using Persistence.Contexts;

    public class BrandRepository : EfRepositoryBase<Brand, BaseDbContext>, IBrandRepository
    {
        public BrandRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
