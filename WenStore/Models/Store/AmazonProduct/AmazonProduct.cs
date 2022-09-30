using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WenStore.Models.Store;

[Table("STORE.AmazonProducts")]
public class AmazonProduct
{
  [Key]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public long Id { get; set; }

  public string Name { get; set; } = "";
  public string Description { get; set; } = "";
  public string Url { get; set; } = "";
  public bool Deal { get; set; } = false;
  public string ImageRelativePath { get; set; } = "";
  public bool IsDeleted { get; set; }

  public AmazonProduct(AmazonProductMin min)
  {
    Name = min.Name;
    Description = min.Description;
    Url = min.ImageRelativePath;
    Deal = min.Deal;
    ImageRelativePath = min.ImageRelativePath;
    IsDeleted = min.IsDeleted;
  }
  public AmazonProduct()
  {
  }
}