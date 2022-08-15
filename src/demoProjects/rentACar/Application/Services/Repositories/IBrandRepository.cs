namespace Application.Services.Repositories
{
    using Core.Persistence.Repositories;
    using Domain.Entities;

    public interface IBrandRepository : IAsyncRepository<Brand>, IRepository<Brand>
    {
    }
}
