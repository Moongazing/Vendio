using Moongazing.Kernel.Persistence.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moongazing.Vendio.Catalog.Domain.Entities;

public class ProductEntity : Entity<Guid>
{
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public decimal Price { get; set; } = default!;
    public int Stock { get; set; } = default!;
    public Guid CategoryId { get; set; } = default!;
    public Guid BrandId { get; set; } = default!;
    public virtual CategoryEntity Category { get; set; } = default!;
    public virtual BrandEntity Brand { get; set; } = default!;
    public virtual ICollection<ProductVariantEntity> Variants { get; set; } = new HashSet<ProductVariantEntity>();
    public virtual ICollection<ProductImageEntity> Images { get; set; } = new HashSet<ProductImageEntity>();
    public virtual ICollection<PriceHistoryEntity> PriceHistories { get; set; } = new HashSet<PriceHistoryEntity>();
}
