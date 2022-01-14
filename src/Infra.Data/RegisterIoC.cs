using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Data
{
    public class RegisterIoC
    {
        public static void DependencyRegisterDataLayer(IServiceCollection services, string adminDbConnectionString, int? commandTimeout)
        {
            if (!commandTimeout.HasValue)
                commandTimeout = 60;

            services.AddDbContext<Data.Context.AdminDbContext>(options =>
            {
                options
                    .UseSqlServer(adminDbConnectionString, sqlServerOptions => sqlServerOptions.CommandTimeout(commandTimeout))
                    .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });

            services.AddScoped<Context.AdminDbContext>();
            services.AddScoped<Domain.Interfaces.Data.IUnitOfWork, Data.Context.UnitOfWork>();

            #region Register Repositories
            //var repositoriesAssembly = typeof(Repositories.DBExternalMonitoring.AlertAttendanceRepository).Assembly;
            //var repositoriesRegistrations =
            //    from type in repositoriesAssembly.GetExportedTypes()
            //    where type.Namespace == "EMT.Infra.Data.Repositories.DBExternalMonitoring"
            //    where type.GetInterfaces().Any()
            //    select new { Interface = type.GetInterfaces().FirstOrDefault(), Implementation = type };

            //foreach (var reg in repositoriesRegistrations)
            //    services.AddScoped(reg.Interface, reg.Implementation);
            #endregion
        }
    }
}
