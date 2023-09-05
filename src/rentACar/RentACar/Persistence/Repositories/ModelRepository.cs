﻿using Domain.Entities;
using Core.Persistence.Repositories;
using Persistence.Context;
using Application.Services.Repositories;

namespace Persistence.Repositories;

public class ModelRepository : EfRepositoryBase<Model, Guid, BaseDbContext>, IModelRepository
{
	public ModelRepository(BaseDbContext context) : base(context)
	{
	}
}
