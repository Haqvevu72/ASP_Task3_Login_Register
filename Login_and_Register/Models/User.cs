using Login_and_Register.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Login_and_Register.Models;

[ModelMetadataType(typeof(UserRegisterViewModel))]
public class User
{
    public string name { get; set; }
    public string surname { get; set; }
    public string age { get; set; }
    public string username { get; set; }
    public string password { get; set; }

    public User()
    {
        
    }
}