﻿namespace Moongazing.Kernel.Application.Pipelines.Caching;

public interface ICachableRequest
{
    string CacheKey { get; }
    bool BypassCache { get; }
    string? CacheGroupKey { get; }
    TimeSpan? SlidingExpiration { get; }
}