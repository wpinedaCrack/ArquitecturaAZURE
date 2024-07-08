﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tarker.Booking.Application.External.SendGridEmail;
using Tarker.Booking.External.SendGridEmail;

namespace Tarker.Booking.External
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddExternal(this IServiceCollection services,
                                                        IConfiguration configuration)
        {
            services.AddSingleton<ISendGridEmailService, SendGridEmailService>();

            return services;
        }
    }
}
