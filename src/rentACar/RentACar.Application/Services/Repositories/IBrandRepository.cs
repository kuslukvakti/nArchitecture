namespace RentACar.Application.Services.Repositories
{
    using Core.Persistence.Repositories;
    using RentACar.Domain.Entities;

    public interface IBrandRepository : IAsyncRepository<Brand>, IRepository<Brand>
    {
    }
}
