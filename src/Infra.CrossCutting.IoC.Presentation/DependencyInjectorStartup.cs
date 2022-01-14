using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.CrossCutting.IoC.Presentation
{
    public class DependencyInjectorStartup
    {
        public static void RegisterServicesForUI(IServiceCollection services, IConfiguration configuration)
        {
            if (services is null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (configuration is null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            var ConnectionString = configuration.GetConnectionString("Db");            
            var commandTimeout = configuration.GetSection("AppSettings:commandTimeout").Value;
            if (string.IsNullOrEmpty(commandTimeout))
                commandTimeout = "60";
            //Data.RegisterIoC.DependencyRegisterDataLayer(services, ConnectionString, int.Parse(commandTimeout));

            //Domain.RegisterIoC.DependencyRegisterDomainLayer(services);
            //App.Portal.RegisterIoC.DependencyRegisterAppLayer(services);
        }
    }
}