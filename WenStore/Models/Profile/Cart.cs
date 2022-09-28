using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WenStore.Models.Application;

namespace WenStore.Models.Store
{
  [Table("STORE.Carts")]
  public class Cart
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    public List<Product> Products { get; set; } = new List<Product>();

    [ForeignKey(nameof(ApplicationUser))] public int ApplicationUserId { get; set; }
  }
}