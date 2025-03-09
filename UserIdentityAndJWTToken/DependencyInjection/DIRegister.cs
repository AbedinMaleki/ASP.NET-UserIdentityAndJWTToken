using Application;
using Infrastructure.Repository;
using Infrastructure.UnitOfWork;

namespace UserIdentityAndJWTToken.DependencyInjection
{
    public static class DIRegister
    {
        public static IServiceCollection UserService(this IServiceCollection services)
        {
            services.AddScoped<UserService, UserService>(); 
            services.AddScoped<IUserRepository, UserRepository>(); 
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;

        }
    }
}
