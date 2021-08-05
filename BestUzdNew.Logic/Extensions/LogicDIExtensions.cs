
using Microsoft.Extensions.DependencyInjection;

namespace BestUzdNew.Logic.Extensions
{
    public static class LogicDIExtensions
    {
        public static void RegisterLogicDI(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IServiceForServiceEntity, ServiceForServiceEntity>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IServiceForServiceGroupEntity, ServiceForServiceGroupEntity>();
        }
    }
}
