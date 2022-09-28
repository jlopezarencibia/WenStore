namespace WenStore.Models.Store;

public class ProductMin
{
  public string Name { get; set; } = "";
  public double CategoryId { get; set; }
  public float Price { get; set; } = 0;
  public bool HasDelivery { get; set; } = false;
  public bool HasPickUp { get; set; } = false;
  public string PickUpLocation { get; set; } = "";
  public string DeliversTo { get; set; } = "";
  public string ImageRelativePath { get; set; } = "";
}