using Microsoft.EntityFrameworkCore;
using Moongazing.Vendio.Catalog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moongazing.Vendio.Catalog.Persistence.Contexts;

public class CatalogDbContext: DbContext
{
    public virtual DbSet<ProductEntity> Products { get; set; }
    public virtual DbSet<CategoryEntity> Categories { get; set; }
    public virtual DbSet<BrandEntity> Brands { get; set; }
    public virtual DbSet<ProductVariantEntity> ProductVariants { get; set; }
    public virtual DbSet<ProductImageEntity> ProductImages { get; set; }
    public virtual DbSet<PriceHistoryEntity> PriceHistories { get; set; }

}
