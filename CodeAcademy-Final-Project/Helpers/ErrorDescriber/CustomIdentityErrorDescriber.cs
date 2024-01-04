using Microsoft.AspNetCore.Identity;

namespace CodeAcademy_Final_Project.Helpers.ErrorDescriber
{
    public class CustomIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresUpper),
                Description = "Senhas devem conter ao menos um caracter em caixa alta ('A'-'Z')."
            };
        }
    }
}
