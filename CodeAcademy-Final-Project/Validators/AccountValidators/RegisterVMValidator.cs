using CodeAcademy_Final_Project.ViewModels.AccountVM;
using FluentValidation;

namespace CodeAcademy_Final_Project.Validators.AccountValidators
{
    public class RegisterVMValidator:AbstractValidator<RegisterVM>
    {
        public RegisterVMValidator()
        {
            RuleFor(r=>r.FullName)
                .NotEmpty().WithMessage("Bosh xana saxlamaq olmaz!")
                .MaximumLength(50).WithMessage("Chox uzundur!Simvol sayi 50-den yuxari olmamalidir!");
            RuleFor(r=>r.UserName)
                .NotEmpty().WithMessage("Bosh xana saxlamaq olmaz!")
                .MaximumLength(50).WithMessage("Chox uzundur!Simvol sayi 50-den yuxari olmamalidir!");
            RuleFor(r=>r.Email)
                .NotEmpty().WithMessage("Bosh xana saxlamaq olmaz!")
                .MaximumLength(100).WithMessage("Chox uzundur!Simvol sayi 100-den yuxari olmamalidir!")
                .EmailAddress().WithMessage("Yalniz email yazmaq olar!");
            RuleFor(r => r.Password)
                .NotEmpty().WithMessage("Bosh xana saxlamaq olmaz!")
                .MinimumLength(8).WithMessage("Shifre minimum 8 simvoldan ibaret olmalidir!")
                .MaximumLength(50).WithMessage("Chox uzundur!Simvol sayi 50-den yuxari olmamalidir!");

            RuleFor(r => r.RepeatPassword)
                .NotEmpty().WithMessage("Bosh xana saxlamaq olmaz!")
                .MaximumLength(50).WithMessage("Chox uzundur!Simvol sayi 50-den yuxari olmamalidir!")
                .MinimumLength(8).WithMessage("Minimal simvol sayi 8-dir!");
            RuleFor(r => r).Custom((r, context) =>
            {
                if (r.Password != r.RepeatPassword)
                {
                    context.AddFailure("RepeatPassword", "Password ile eyni olmalidir!");
                }
            });
        }
    }
}
