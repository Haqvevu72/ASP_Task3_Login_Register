using System.ComponentModel.DataAnnotations;

namespace Login_and_Register.ViewModels;

public class UserRegisterViewModel
{
    [Required]
    [MinLength(5)]
    [MaxLength(50)]
    public string name { get; set; }

    [Required]
    [MinLength(5)]
    [MaxLength(50)]
    public string surname { get; set; }
    
    [Required]
    [MinLength(2)]
    [MaxLength(3)]
    public string age { get; set; }
    
    [Required]
    [MinLength(5)]
    [MaxLength(50)]
    public string username { get; set; }
    
    [Required]
    [MinLength(5)]
    [MaxLength(50)]
    public string password { get; set; }
}