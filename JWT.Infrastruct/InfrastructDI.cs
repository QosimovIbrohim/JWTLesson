using JWT.Infrastruct.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWT.Infrastruct
{
    public static class InfrastructDI
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(ops =>
            {
                ops.UseNpgsql(configuration.GetConnectionString("Cs"));
            });
            return services;
        }
    }
}
