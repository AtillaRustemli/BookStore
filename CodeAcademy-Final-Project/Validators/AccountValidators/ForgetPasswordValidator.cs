using CodeAcademy_Final_Project.ViewModels.AccountVM;
using FluentValidation;

namespace CodeAcademy_Final_Project.Validators.AccountValidators
{
    public class ForgetPasswordValidator:AbstractValidator<ForgetPasswordVM>
    {
        public ForgetPasswordValidator()
        {
            RuleFor(f => f.Email)
                .NotEmpty().WithMessage("Bosh saxlamaq olmaz")
                ;

        }
    }
}
