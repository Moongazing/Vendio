using Moongazing.Kernel.Persistence.Repositories.Common;

namespace Moongazing.Vendio.Catalog.Domain.Entities;

public class ProductImageEntity : Entity<Guid>
{
    public Guid ProductId { get; set; }
    public string ImageUrl { get; set; } = default!;
    public bool IsMainImage { get; set; } = true;
    public virtual ProductEntity Product { get; set; } = default!;
}
