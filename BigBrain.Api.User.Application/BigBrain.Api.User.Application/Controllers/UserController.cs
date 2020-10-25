using BigBrain.Api.User.Domain.ViewModels;
using BigBrain.Api.User.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BigBrain.Api.User.Application.Controllers
{
    /// <summary>
    /// Users Big Brain
    /// </summary>
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        #region Fields

        private readonly IUserService _userService = null;

        #endregion

        #region Constructor

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        #endregion

        #region Controllers Methods

        /// <summary>
        /// Get Users
        /// </summary>
        /// <param name="search"></param>
        [Route("Get")]
        [HttpGet]
        [ProducesResponseType(typeof(UserViewModel), 200)]
        public object Get(string search)
        {
            return _userService.Get(search);
        }

        #endregion
    }
}
