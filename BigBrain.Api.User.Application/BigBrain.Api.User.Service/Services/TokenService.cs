using BigBrain.Api.User.Domain.ViewModels;
using BigBrain.Api.User.Service.Interfaces;
using Microsoft.Graph.Auth;
using Microsoft.Identity.Client;

namespace BigBrain.Api.User.Service.Services
{
    public class TokenService : ITokenService
    {
        #region Fields

        private readonly string TenantId;
        private readonly string AppId;
        private readonly string Secret;

        #endregion

        #region Constructor

        public TokenService()
        {
            TenantId = "302de125-622a-4ac3-a029-4431603ffed3";
            AppId = "e8027724-a2e0-4b44-8c13-557d77af647f";
            Secret = "-vlv1P8H18.mDi.gXudAJkA_51Fr8zFQCL";
        }

        #endregion

        #region Methods

        public TokenViewModel Get()
        {
            var viewModel = new TokenViewModel();

            IConfidentialClientApplication confidentialClientApplication = ConfidentialClientApplicationBuilder
                                        .Create(AppId)
                                        .WithTenantId(TenantId)
                                        .WithClientSecret(Secret)
                                        .Build();

            ClientCredentialProvider authProvider = new ClientCredentialProvider(confidentialClientApplication);
            viewModel.AuthProvider = authProvider;
            return viewModel;
        }

        #endregion
    }
}
