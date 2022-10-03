namespace RentACar.Persistence.Repositories
{
    using Core.Persistence.Repositories;
    using Core.Security.Entities;
    using Persistence.Contexts;
    using RentACar.Application.Services.Repositories;

    public class UserOperationClaimRepository : EfRepositoryBase<UserOperationClaim, BaseDbContext>, IUserOperationClaimRepository
    {
        public UserOperationClaimRepository(BaseDbContext context) : base(context)
        {
        }
    }

}
