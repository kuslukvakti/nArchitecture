namespace RentACar.Persistence.Repositories
{
    using Core.Persistence.Repositories;
    using Core.Security.Entities;
    using Persistence.Contexts;
    using RentACar.Application.Services.Repositories;

    public class RefreshTokenRepository : EfRepositoryBase<RefreshToken, BaseDbContext>, IRefreshTokenRepository
    {
        public RefreshTokenRepository(BaseDbContext context) : base(context)
        {
        }
    }

}
