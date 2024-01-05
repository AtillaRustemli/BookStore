using CodeAcademy_Final_Project.ViewModels.AccountVM;

namespace CodeAcademy_Final_Project.Services.AccountServices
{
    public interface IAccountService
    {
        public Task<ServiceResult> LoginService(LoginVM loginVM);
    }
}
