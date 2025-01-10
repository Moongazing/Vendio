using Moongazing.Kernel.Persistence.Repositories.Common;

namespace Moongazing.Vendio.Catalog.Domain.Entities;

public class CategoryEntity : Entity<Guid>
{
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public Guid? ParentCategoryId { get; set; }
    public virtual ICollection<CategoryEntity> SubCategories { get; set; } = new HashSet<CategoryEntity>();
}
