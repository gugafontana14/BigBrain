using BigBrain.Api.User.Domain.ViewModels;
using BigBrain.Api.User.Service.Interfaces;
using Microsoft.Graph;
using System.Collections.Generic;

namespace BigBrain.Api.User.Service.Services
{
    public class UserService : IUserService
    {
        #region Fields
        
        private readonly ITokenService _tokenService;
        private readonly int _recordsLimit;

        #endregion

        #region Constructor

        public UserService(ITokenService tokenService)
        {
            _tokenService = tokenService;
            _recordsLimit = 20;
        }

        #endregion

        #region Methods

        public List<UserViewModel> Get(string search)
        {
            var viewModel = new List<UserViewModel>();
            var token = _tokenService.Get();

            GraphServiceClient graphClient = new GraphServiceClient(token.AuthProvider);

            IGraphServiceUsersCollectionPage users = graphClient.Users
                .Request()
                .Filter(search != null ? $"startswith(givenName, '{search}') or startswith(surName, '{search}') or startswith(displayName, '{search}') or startswith(mail, '{search}') or startswith(userPrincipalName, '{search}')" : "")
                .Top(_recordsLimit)
                .GetAsync().Result;

            foreach (var user in users.CurrentPage)
            {
                viewModel.Add(new UserViewModel
                {
                    Id = user.Id,
                    DisplayName = user.DisplayName,
                    BusinessPhones = user.BusinessPhones,
                    GivenName = user.GivenName,
                    JobTitle = user.JobTitle,
                    Mail = user.Mail,
                    MobilePhone = user.MobilePhone,
                    OfficeLocation = user.OfficeLocation,
                    PreferredLanguage = user.PreferredLanguage,
                    Surname = user.Surname,
                    UserPrincipalName = user.UserPrincipalName
                });
            }
            return viewModel;
        }

        #endregion

    }
}
