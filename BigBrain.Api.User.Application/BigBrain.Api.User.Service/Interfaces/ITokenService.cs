using BigBrain.Api.User.Domain.ViewModels;

namespace BigBrain.Api.User.Service.Interfaces
{
    public interface ITokenService
    {
        TokenViewModel Get();
    }
}