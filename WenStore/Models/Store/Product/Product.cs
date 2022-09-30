using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WenStore.Models.Store.Product
{
  [Table("STORE.Products")]
  [Index(nameof(Name))]
  public class Product
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    public string Name { get; set; } = "";
    public long CategoryId { get; set; }
    public long UserId { get; set; } 
    public float Price { get; set; } = 0.0f;
    public float DealPrice { get; set; } = 0.0f;
    public bool HasDelivery { get; set; } = false;
    public bool HasPickUp { get; set; } = false;
    public string PickUpLocation { get; set; } = "";
    public string DeliversTo { get; set; } = "";
    public string ImageRelativePath { get; set; } = "";
    public int Stock { get; set; } = 0;

    public Product(ProductMin min)
    {
      Name = min.Name;
      CategoryId = min.CategoryId;
      Price = min.Price;
      DealPrice = min.DealPrice;
      HasDelivery = min.HasDelivery;
      HasPickUp = min.HasPickUp;
      PickUpLocation = min.PickUpLocation;
      DeliversTo = min.DeliversTo;
      ImageRelativePath = min.ImageRelativePath;
      Stock = min.Stock;
    }

    public Product()
    {
    }
  }
}