using Microsoft.AspNetCore.Identity;

namespace WenStore.Models.Store.Category;

public class CategoryDto
{
  public long Id { get; set; }
  public string CategoryName { get; set; }
  public ICollection<Product.Product>? Products { get; set; }
  public string BackgroundColor { get; set; } = "#FFFFFF";
  public string BackgroundImageRelativePath { get; set; } = "";
  public bool IsDeleted { get; set; } = false;

  public CategoryDto(Category category, ICollection<Product.Product>? products)
  {
    Id = category.Id;
    CategoryName = category.CategoryName;
    Products = products;
    BackgroundColor = category.BackgroundColor;
    BackgroundImageRelativePath = category.BackgroundImageRelativePath;
    IsDeleted = category.IsDeleted;
  }

  public CategoryDto()
  {
  }
}