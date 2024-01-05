using CodeAcademy_Final_Project.ViewModels.AccountVM;
using FluentValidation;

namespace CodeAcademy_Final_Project.Validators.AccountValidators
{
    public class LoginVMValidator:AbstractValidator<LoginVM>
    {
        public LoginVMValidator()
        {
            RuleFor(l=>l.UserNameOrEmail)
                .NotEmpty().WithMessage("Bosh xana saxlamaq olmaz!")
                .MaximumLength(50).WithMessage("Simvol sayi 50-den ashagi olmalidir!");
            RuleFor(l => l.Password)
                .NotEmpty().WithMessage("Bosh xana saxlamaq olmaz!")
                .MaximumLength(50).WithMessage("Simvol sayi 50-den ashagi olmalidir!")
                .MinimumLength(8).WithMessage("Simvol sayi 8-den yuxari olmalidir!");
        }
    }
}
