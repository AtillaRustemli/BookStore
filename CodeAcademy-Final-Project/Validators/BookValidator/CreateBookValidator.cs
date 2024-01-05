using CodeAcademy_Final_Project.ViewModels.BookViewModel;
using FluentValidation;

namespace CodeAcademy_Final_Project.Validators.BookValidator
{
    public class CreateBookValidator:AbstractValidator<CreateBookVM>
    {
        public CreateBookValidator()
        {
            RuleFor(b=>b.Name)
                .NotEmpty().WithMessage("Bosh xana saxlamaq olmaz!")
                .MaximumLength(50).WithMessage("50 simvoldan artiq olmaz");
            RuleFor(b=>b.Price)
                .NotEmpty().WithMessage("Bosh xana saxlamaq olmaz!");
            RuleFor(b=>b.Photo)
                .NotEmpty().WithMessage("Bosh xana saxlamaq olmaz!");
            RuleFor(b=>b.Width)
                .NotEmpty().WithMessage("Bosh xana saxlamaq olmaz!");
            RuleFor(b=>b.Height)
                .NotEmpty().WithMessage("Bosh xana saxlamaq olmaz!");
            RuleFor(b=>b.Length)
                .NotEmpty().WithMessage("Bosh xana saxlamaq olmaz!");
            RuleFor(b=>b.PageCount)
                .NotEmpty().WithMessage("Bosh xana saxlamaq olmaz!");
        }
    }
}
