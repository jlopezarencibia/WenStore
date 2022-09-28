using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WenStore.Models.Shared;

[Table("STORE.Rates")]
public class Rate
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    
    public int Score { get; set; } = 5;
    public Comment Comment { get; set; } = new Comment(); 
}