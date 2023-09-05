using Domain.Entities;
using Core.Persistence.Repositories;
using Persistence.Context;
using Application.Services.Repositories;

namespace Persistence.Repositories;

public class CarRepository : EfRepositoryBase<Car, Guid, BaseDbContext>, ICarRepository
{
	public CarRepository(BaseDbContext context) : base(context)
	{
	}
}
