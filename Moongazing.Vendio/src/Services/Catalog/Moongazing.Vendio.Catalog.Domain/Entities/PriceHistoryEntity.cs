using Moongazing.Kernel.Persistence.Repositories.Common;

namespace Moongazing.Vendio.Catalog.Domain.Entities;

public class PriceHistoryEntity : Entity<Guid>
{
    public Guid ProductId { get; set; }
    public decimal OldPrice { get; set; }
    public decimal NewPrice { get; set; }
    public virtual ProductEntity Product { get; set; } = default!;
}