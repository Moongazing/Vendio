﻿namespace Moongazing.Kernel.Persistence.Paging;

public interface IPagebale<T>
{
    int From { get; }
    int Index { get; }
    int Size { get; }
    int Count { get; }
    int Pages { get; }
    IList<T> Items { get; }
    bool HasPrevious { get; }
    bool HasNext { get; }
}