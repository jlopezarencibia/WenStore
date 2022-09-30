using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WenStore.Models.Store.Category;

[Table("STORE.Categories")]
public class Category
{
  [Key]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public long Id { get; set; }

  public string CategoryName { get; set; } = "";
  public string BackgroundColor { get; set; } = "#FFFFFF";
  public string BackgroundImageRelativePath { get; set; } = "";
  public bool IsDeleted { get; set; } = false;

  public Category(CategoryMin min)
  {
    CategoryName = min.CategoryName;
    BackgroundImageRelativePath = min.BackgroundImageRelativePath;
    BackgroundColor = min.BackgroundColor;
    IsDeleted = min.IsDeleted;
  }

  public Category()
  {
  }
}