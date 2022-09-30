namespace WenStore.Models.Store.Product;

public class ProductDto
{
  public long Id { get; set; }
  public Category.Category? Category { get; set; }
  public double Price { get; set; } = 0.0f;
  public double DealPrice { get; set; } = 0.0f;
  public bool HasDelivery { get; set; } = false;
  public bool HasPickUp { get; set; } = false;
  public string PickUpLocation { get; set; } = "";
  public string DeliversTo { get; set; } = "";
  public string ImageRelativePath { get; set; } = "";
  public int Stock { get; set; } = 0;

  public ProductDto(Product product, Category.Category category)
  {
    Id = product.Id;
    Category = category;
    Price = product.Price;
    DealPrice = product.DealPrice;
    HasDelivery = product.HasDelivery;
    HasPickUp = product.HasPickUp;
    PickUpLocation = product.PickUpLocation;
    DeliversTo = product.DeliversTo;
    ImageRelativePath = product.ImageRelativePath;
    Stock = product.Stock;
  }

  public ProductDto()
  {
  }
}