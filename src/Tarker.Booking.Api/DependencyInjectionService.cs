﻿namespace Tarker.Booking.Api
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddWebApi(this IServiceCollection services)
        {
            
            return services;
        }

        //public static IServiceCollection AddWebApi(this IServiceCollection services)
        //{
        //    services.AddSwaggerGen(options =>
        //    {
        //        options.SwaggerDoc("v1", new OpenApiInfo
        //        {
        //            Version = "v1",
        //            Title = "Tarker Booking API",
        //            Description = "Administración de APIs para Booking App"

        //        });
        //        options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        //        {
        //            In = ParameterLocation.Header,
        //            Description = "Ingrese un token válido",
        //            Name = "Authorization",
        //            Type = SecuritySchemeType.Http,
        //            BearerFormat = "JWT",
        //            Scheme = "Bearer"
        //        });

        //        options.AddSecurityRequirement(new OpenApiSecurityRequirement
        //        {
        //            {
        //                new OpenApiSecurityScheme
        //                {
        //                    Reference = new OpenApiReference
        //                    {
        //                        Type = ReferenceType.SecurityScheme,
        //                        Id = "Bearer"
        //                    }
        //                },
        //                new string[]{}
        //            }
        //        });
        //        var fileName = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        //        options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, fileName));
        //    });
        //    return services;
        //}
    }
}
