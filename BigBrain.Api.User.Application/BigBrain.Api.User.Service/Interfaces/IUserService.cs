using BigBrain.Api.User.Domain.ViewModels;
using System.Collections.Generic;

namespace BigBrain.Api.User.Service.Interfaces
{
    public interface IUserService
    {
        List<UserViewModel> Get(string search);
    }
}