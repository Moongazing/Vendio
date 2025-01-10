using Moongazing.Kernel.Persistence.Repositories.Common;

namespace Moongazing.Vendio.Catalog.Domain.Entities;

public class ProductVariantEntity : Entity<Guid>
{
    public Guid ProductId { get; set; }
    public string Name { get; set; } = default!;
    public string Value { get; set; } = default!;
    public virtual ProductEntity Product { get; set; } = default!;
}
