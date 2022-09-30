namespace WenStore.Models.Store;

public class AmazonProductDto
{
  public long Id { get; set; }

  public string Name { get; set; } = "";
  public string Description { get; set; } = "";
  public string Url { get; set; } = "";
  public bool Deal { get; set; } = false;
  public string ImageRelativePath { get; set; } = "";
  public bool IsDeleted { get; set; } = false;
  
  public AmazonProductDto(AmazonProduct product)
  {
    Id = product.Id;
    Name = product.Name;
    Description = product.Description;
    Url = product.Url;
    Deal = product.Deal;
    ImageRelativePath = product.ImageRelativePath;
    IsDeleted = product.IsDeleted;
  }
  
  public AmazonProductDto()
  {
  }

  
}