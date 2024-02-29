using JWTLesson.Application.Services.AuthService;
using JWTLesson.Application.Services.UserServices;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTLesson.Application
{
    public static class ApplicationDI
    {
        public static IServiceCollection AddApplicationDI(this IServiceCollection services)
        {
            services.AddScoped<IAuthservice, AuthService>();
            services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}
