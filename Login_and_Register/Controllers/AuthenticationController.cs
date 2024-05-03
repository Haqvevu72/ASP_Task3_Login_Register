using Login_and_Register.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Login_and_Register.Models;
using Login_and_Register.Services;

namespace Login_and_Register.Controllers;

public class AuthenticationController: Controller
{
    private List<User> users = Users.users;
        
    [HttpGet]
    public IActionResult LogIn()
    {
        return View();
    }

    [HttpPost]
    public IActionResult LogIn(UserLoginViewModel viewModel)
    {
        if (!ModelState.IsValid == true)
            return View();
        
        foreach (User user in users)
        {
            if (user.username == viewModel.username && user.password == viewModel.password)
            {
                TempData["Found"] = true;
                return RedirectToAction("Success");
            }
        }

        TempData["Found"] = false;
        return RedirectToAction("Success");
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(UserRegisterViewModel user)
    {
        if(!ModelState.IsValid)
            return View(user);
        User newuser = new()
        {
            name = user.name,
            surname = user.surname,
            age = user.age,
            username = user.username,
            password = user.password
        };
        
        users.Add(newuser);
        return RedirectToAction("LogIn");
    }

    public IActionResult Success()
    {
        return View();
    }
}