using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace WenStore.Models.Store
{
  [Table("STORE.Products")]
  [Index(nameof(Name))]
  public class Product
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    public string Name { get; set; } = "";
    public double CategoryId { get; set; }
    public float Price { get; set; } = 0;
    public bool HasDelivery { get; set; } = false;
    public bool HasPickUp { get; set; } = false;
    public string PickUpLocation { get; set; } = "";
    public string DeliversTo { get; set; } = "";
    public string ImageRelativePath { get; set; } = "";

    public Product(ProductMin min)
    {
      Name = min.Name;
      CategoryId = min.CategoryId;
      Price = min.Price;
      HasDelivery = min.HasDelivery;
      HasPickUp = min.HasPickUp;
      PickUpLocation = min.PickUpLocation;
      DeliversTo = min.DeliversTo;
      ImageRelativePath = min.ImageRelativePath;
    }

    public Product()
    {
    }
  }
}