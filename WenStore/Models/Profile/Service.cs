using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WenStore.Models.Store;

[Table("STORE.Services")]
public class Service
{
  [Key]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public long Id { get; set; }

  public string Name { get; set; } = "";
  public string Description { get; set; } = "";
  public SocialUrl SocialUrl { get; set; } = new SocialUrl();
}