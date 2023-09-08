﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Pipelines.Cache;

public interface ICachableRequest
{
	string CacheKey { get; }
	bool BypassCache { get; }

	TimeSpan? SlidingExpiration { get; }
}
