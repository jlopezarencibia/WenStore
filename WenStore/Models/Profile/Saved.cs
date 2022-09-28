using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WenStore.Models.Services;

namespace WenStore.Models.Store;

[Table("STORE.Saves")]
public class Saved
{
  [Key]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public long Id { get; set; }

  public List<Product> Products { get; set; } = new List<Product>();
  public List<Service> Services { get; set; } = new List<Service>();
  public List<Job> Jobs { get; set; } = new List<Job>();
  public List<OpenForWork> OpenForWorks { get; set; } = new List<OpenForWork>();
}