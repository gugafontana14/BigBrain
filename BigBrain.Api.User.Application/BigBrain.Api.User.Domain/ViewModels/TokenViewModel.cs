using Microsoft.Graph.Auth;

namespace BigBrain.Api.User.Domain.ViewModels
{
    public class TokenViewModel
    {
        public ClientCredentialProvider AuthProvider { get; set; }
    }
}