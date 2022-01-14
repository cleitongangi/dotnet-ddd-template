using Microsoft.Extensions.DependencyInjection;

namespace Domain
{
    public class RegisterIoC
    {
        public static void DependencyRegisterDomainLayer(IServiceCollection services)
        {
            #region Registra todos os Validations
            //services.AddScoped<Domain.Interfaces.Validations.IPaymentMethodDirectDebitValidations, Domain.Validations.PaymentMethodDirectDebitValidations>();            
            #endregion Registra todos os Validations

            #region Registra todos os Serviços
            //var servicesAssembly = typeof(Interfaces.Services.IAlertAttendanceService).Assembly;
            //var serviceRegistrations =
            //    from type in servicesAssembly.GetExportedTypes()
            //    where type.Namespace == "Domain.Services"
            //    where type.GetInterfaces().Any()
            //    select new { Interface = type.GetInterfaces().Single(), Implementation = type };

            //foreach (var reg in serviceRegistrations)
            //    services.AddScoped(reg.Interface, reg.Implementation);
            #endregion
        }
    }
}
