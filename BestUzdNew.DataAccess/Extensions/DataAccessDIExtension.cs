using Microsoft.Extensions.DependencyInjection;

namespace BestUzdNew.DataAccess.Extensions
{
    public static class DataAccessDIExtension
    {
        public static void RegisterDataAccessDI(this IServiceCollection services)
        {
            services.AddSingleton<IUnitOfWorkFactory, UnitOfWorkFactory>();
        }
    }
}
