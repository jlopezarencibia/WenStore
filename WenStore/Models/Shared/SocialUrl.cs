using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WenStore.Models.Store;

[Table("STORE.SocialUrls")]
public class SocialUrl
{
  [Key]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public long Id { get; set; }

  public string Name { get; set; } = "";
  public string Url { get; set; } = "";
}