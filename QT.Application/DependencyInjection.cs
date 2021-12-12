using Microsoft.Extensions.DependencyInjection;
using QT.Application.Interfaces;
using QT.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QT.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
