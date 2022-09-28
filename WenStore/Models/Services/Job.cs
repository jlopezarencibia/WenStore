using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WenStore.Models.Shared;

namespace WenStore.Models.Services;

[Table("STORE.Jobs")]
public class Job
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public string Salary { get; set; } = "";
    public string Frequency { get; set; } = "";
    public ContactInformation ContactInformation { get; set; } = new ContactInformation();
}