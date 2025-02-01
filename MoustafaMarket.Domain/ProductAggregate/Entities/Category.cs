
using MoustafaMarket.Domain.Common.Models;
using MoustafaMarket.Domain.ProductAggregate.ValueObjects;

namespace MoustafaMarket.Domain.ProductAggregate.Entities;

public class Category : Entity<CategoryId>
{
    public string Name { get; private set; }
    public string? Description { get; private set; }
    public CategoryId? ParentCategoryId { get; private set; }
    public Category? ParentCategory { get; private set; }
    public List<Category> SubCategories { get; private set; } = new();
    public List<Product> Products { get; private set; } = new();
#pragma warning disable CS8618
    private Category() { }
#pragma warning restore CS8618
    private Category(CategoryId id, string name, string? description, Category? parentCategory = null)
      :base(id)
    {
        Name = name;
        Description = description;
        ParentCategory = parentCategory;
        if(parentCategory is not null)
            ParentCategoryId = parentCategory.Id;
    }
    public static Category Create(CategoryId id, string name, string? description, Category? parentCategory = null)
      =>new Category(id, name, description, parentCategory);
}
