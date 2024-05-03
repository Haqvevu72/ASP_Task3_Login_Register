using FluentValidation;
using Login_and_Register.Models;

namespace Login_and_Register.ViewModels;

public class Fluent: AbstractValidator<UserLoginViewModel>
{
    public Fluent()
    {
        RuleFor(u => u.username)
            .MaximumLength(50)
            .MinimumLength(5);

        RuleFor(u => u.password)
            .MaximumLength(50)
            .MinimumLength(5);
    }
}