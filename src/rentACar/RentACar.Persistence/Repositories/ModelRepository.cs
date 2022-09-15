﻿namespace RentACar.Persistence.Repositories
{
    using RentACar.Application.Services.Repositories;
    using Core.Persistence.Repositories;
    using RentACar.Domain.Entities;
    using RentACar.Persistence.Contexts;

    public class ModelRepository : EfRepositoryBase<Model, BaseDbContext>, IModelRepository
    {
        public ModelRepository(BaseDbContext context) : base(context)
        {
        }

    }
}