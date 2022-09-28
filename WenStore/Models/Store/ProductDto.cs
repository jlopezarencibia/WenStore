namespace WenStore.Models.Store;

public class ProductDto
{
    public long Id { get; set; }
    public Category? Category { get; set; }
    public double Price { get; set; } = 0;
    public bool HasDelivery { get; set; } = false;
    public bool HasPickUp { get; set; } = false;
    public string PickUpLocation { get; set; } = "";
    public string DeliversTo { get; set; } = "";
    public string ImageRelativePath { get; set; } = "";

    public ProductDto(Product product, Category category)
    {
        Id = product.Id;
        Category = category;
        Price = product.Price;
        HasDelivery = product.HasDelivery;
        HasPickUp = product.HasPickUp;
        PickUpLocation = product.PickUpLocation;
        DeliversTo = product.DeliversTo;
        ImageRelativePath = product.ImageRelativePath;
    }

    public ProductDto()
    {
        
    }
}