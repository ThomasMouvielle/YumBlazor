using System.ComponentModel.DataAnnotations;

namespace YumBlazor.Data;

public class Category
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Please enter the name of the category")]
    public string Name { get; set; }
}