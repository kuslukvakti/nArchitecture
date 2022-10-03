namespace RentACar.Persistence.Repositories
{
    using Application.Services.Repositories;
    using Core.Persistence.Repositories;
    using Core.Security.Entities;
    using Persistence.Contexts;

    public class OperationClaimRepository : EfRepositoryBase<OperationClaim, BaseDbContext>, IOperationClaimRepository
    {
        public OperationClaimRepository(BaseDbContext context) : base(context)
        {
        }
    }

}
