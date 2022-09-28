using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WenStore.Models.Shared;

[Table("STORE.ContactsInformation")]
public class ContactInformation
{
  [Key]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public long Id { get; set; }

  public string PhoneNumber1 { get; set; } = "";
  public string PhoneNumber2 { get; set; } = "";
  public string Address1 { get; set; } = "";
  public string Address2 { get; set; } = "";
}