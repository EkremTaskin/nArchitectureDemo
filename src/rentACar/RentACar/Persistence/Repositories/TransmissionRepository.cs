using Domain.Entities;
using Core.Persistence.Repositories;
using Persistence.Context;
using Application.Services.Repositories;

namespace Persistence.Repositories;

public class TransmissionRepository : EfRepositoryBase<Transmission, Guid, BaseDbContext>, ITransmissionRepository
{
	public TransmissionRepository(BaseDbContext context) : base(context)
	{
	}
}
