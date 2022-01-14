using Microsoft.Extensions.DependencyInjection;

namespace App.Presentation
{
    public class RegisterIoC
    {
        public static void DependencyRegisterAppLayer(IServiceCollection services)
        {
            #region Registra todos os App Services
            //var appServiceAssembly = typeof(Interfaces.IAlertAttendanceAppService).Assembly;
            //var appServiceRegistrations =
            //    from type in appServiceAssembly.GetExportedTypes()
            //    where type.Namespace == "EMT.App.Portal.AppServices"
            //    where type.GetInterfaces().Any()
            //    select new { Interface = type.GetInterfaces().FirstOrDefault(), Implementation = type };

            //foreach (var reg in appServiceRegistrations)
            //    services.AddScoped(reg.Interface, reg.Implementation);
            #endregion

            //services.AddSingleton<Domain.Interfaces.GlobalSettings.IConfigSettings, GlobalSettings.ConfigSettings>();
            //services.AddSingleton<Domain.Interfaces.GlobalSettings.IDomainGlobalSettings, GlobalSettings.DomainGlobalSettings>();

            //services.AddScoped<Interfaces.IAppStartupService, AppStartupService>();
        }
    }
}
