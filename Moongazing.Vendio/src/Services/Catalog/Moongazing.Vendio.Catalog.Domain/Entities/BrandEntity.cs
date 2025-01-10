using Moongazing.Kernel.Persistence.Repositories.Common;

namespace Moongazing.Vendio.Catalog.Domain.Entities;

public class BrandEntity : Entity<Guid>
{
    public string Name { get; set; } = default!;
    public string? Country { get; set; }
    public string? Description { get; set; }
    public virtual ICollection<ProductEntity> Products { get; set; } = new HashSet<ProductEntity>();
}
