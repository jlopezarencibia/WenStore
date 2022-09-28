namespace WenStore.Models.Store;

public class CategoryDto
{
    public long Id { get; set; }
    public string CategoryName { get; set; }
    public ICollection<Product>? Products { get; set; }

    public CategoryDto(Category category, ICollection<Product>? products)
    {
        Id = category.Id;
        CategoryName = category.CategoryName;
        Products = products;
    }

    public CategoryDto()
    {
        
    }
}