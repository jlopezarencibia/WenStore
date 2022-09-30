namespace WenStore.Models.Store.Product;

public class ProductMin
{
  public string Name { get; set; } = "";
  public long CategoryId { get; set; }
  public float Price { get; set; } = 0.0f;
  public float DealPrice { get; set; } = 0.0f;
  public bool HasDelivery { get; set; } = false;
  public bool HasPickUp { get; set; } = false;
  public string PickUpLocation { get; set; } = "";
  public string DeliversTo { get; set; } = "";
  public string ImageRelativePath { get; set; } = "";
  public int Stock { get; set; } = 0;
}