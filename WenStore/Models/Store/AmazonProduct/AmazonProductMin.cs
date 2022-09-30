namespace WenStore.Models.Store;

public class AmazonProductMin
{
  public string Name { get; set; } = "";
  public string Description { get; set; } = "";
  public string Url { get; set; } = "";
  public bool Deal { get; set; } = false;
  public string ImageRelativePath { get; set; } = "";
  public bool IsDeleted { get; set; } = false;
}