using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WenStore.Models.Shared;

namespace WenStore.Models.Services;

[Table("STORE.OpenForWorks")]
public class OpenForWork
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    
    public string Type { get; set; } = "";
    public string Description { get; set; } = "";
    public string PreferredHours { get; set; } = "";
    public string WorkAuthorization { get; set; } = "";
    public string PreferredPaymentType { get; set; } = "";
    public string PreferredDays { get; set; } = "";
    public List<Skill> Skills {get; set; } = new List<Skill>();
}