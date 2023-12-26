﻿namespace Persistence.Repositories;

public class BrandRepository : EfRepositoryBase<Brand, BaseDbContext>, IBrandRepository
{
    public BrandRepository(BaseDbContext context) : base(context)
    {
    }
}
