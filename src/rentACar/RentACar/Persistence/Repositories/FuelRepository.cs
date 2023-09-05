using Domain.Entities;
using Core.Persistence.Repositories;
using Persistence.Context;
using Application.Services.Repositories;

namespace Persistence.Repositories;

public class FuelRepository : EfRepositoryBase<Fuel, Guid, BaseDbContext>, IFuelRepository
{
	public FuelRepository(BaseDbContext context) : base(context)
	{
	}
}
