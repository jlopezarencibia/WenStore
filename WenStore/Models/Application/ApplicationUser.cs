using Microsoft.AspNetCore.Identity;
using WenStore.Models.Store;

namespace WenStore.Models.Application;

public class ApplicationUser : IdentityUser
{
	public string Name { get; set; } = "";
	public string LastName { get; set; } = "";
	public string PhoneNumber2 { get; set; } = "";
	public string City { get; set; } = "";
	public string State { get; set; } = "";
	public string Country { get; set; } = "";
	public string Pronoun { get; set; } = "";
	
	public Cart Cart { get; set; } = new Cart();
}	

