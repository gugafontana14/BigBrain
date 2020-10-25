using BigBrain.Api.User.Service.Interfaces;
using BigBrain.Api.User.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BigBrain.Api.User.CrossCutting
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Services
            services
                .AddScoped<IUserService, UserService>()
                .AddScoped<ITokenService, TokenService>();
        }
    }
}
