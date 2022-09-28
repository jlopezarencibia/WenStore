using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WenStore.Models.Store;
[Table("STORE.Categories")]
public class Category
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    public string CategoryName { get; set; } = "";

    public Category(CategoryMin min)
    {
        CategoryName = min.CategoryName;
    }

    public Category()
    {
        
    }
}