using CodeAcademy_Final_Project.ViewModels.AccountVM;
using FluentValidation;

namespace CodeAcademy_Final_Project.Validators.AccountValidators
{
    public class ResetPasswordVMValidator:AbstractValidator<ResetPasswordVM>
    {
        public ResetPasswordVMValidator()
        {
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Bosh Saxlamaq olmaz!")
                .MaximumLength(50).WithMessage("50 simvoldan artiq olmaz!")
                .MinimumLength(8).WithMessage("8 simvoldan az olmaz!");
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Bosh Saxlamaq olmaz!")
                .MaximumLength(50).WithMessage("50 simvoldan artiq olmaz!")
                .MinimumLength(8).WithMessage("8 simvoldan az olmaz!");
            RuleFor(x => x).Custom((x, context) =>
            {
                if(x.Password!= x.ConfirmPassword)
                {
                    context.AddFailure("ConfirmPassword","Password-e beraber olmalidir!");
                }
            });
        }
    }
}
