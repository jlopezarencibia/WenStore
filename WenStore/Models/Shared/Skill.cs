using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WenStore.Models.Shared;

[Table("STORE.Skills")]
public class Skill
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    
    public string Name { get; set; } = "";
    public string Score { get; set; } = "";
}