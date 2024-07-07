using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Security;
using System.Net;
using Tarker.Booking.Application.DataBase;
using Tarker.Booking.Persistence.DataBase;
using System.Security.Cryptography.X509Certificates;

namespace Tarker.Booking.Persistence
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services,
                                                        IConfiguration configuration)
        {
            //ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(AcceptAllCertificates);

            services.AddDbContext<DataBaseService>(opc => opc.UseSqlServer(configuration["SQLConnectionStrings"]));

            services.AddScoped<IDataBaseService, DataBaseService>();
            return services;
        }
        public static bool AcceptAllCertificates(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true; // Ignorar errores de certificado (solo para desarrollo)
        }
    }
}
