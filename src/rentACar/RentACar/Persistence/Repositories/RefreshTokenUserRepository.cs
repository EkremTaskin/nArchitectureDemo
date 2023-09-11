using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Core.Security.Entities;
using Persistence.Context;

namespace Persistence.Repositories;

public class RefreshTokenUserRepository : EfRepositoryBase<RefreshToken, Guid, BaseDbContext>, IRefreshTokenRepository
{
	public RefreshTokenUserRepository(BaseDbContext context) : base(context)
	{
	}
}