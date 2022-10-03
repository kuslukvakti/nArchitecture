namespace RentACar.Persistence.Repositories
{
    using Core.Persistence.Repositories;
    using Core.Security.Entities;
    using Persistence.Contexts;
    using RentACar.Application.Services.Repositories;

    public class UserRepository : EfRepositoryBase<User, BaseDbContext>, IUserRepository
    {
        public UserRepository(BaseDbContext context) : base(context)
        {
        }
    }

}
