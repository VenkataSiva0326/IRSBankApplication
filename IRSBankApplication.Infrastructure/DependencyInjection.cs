﻿using System.Text;
using IRSBankApplication.Application.Common.Interfaces.Authentication;
using IRSBankApplication.Application.Common.Interfaces.Persistence;
using IRSBankApplication.Application.Common.Interfaces.Services;
using IRSBankApplication.Infrastructure.Authentication;
using IRSBankApplication.Infrastructure.DbContext;
using IRSBankApplication.Infrastructure.Persistence;
using IRSBankApplication.Infrastructure.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace IRSBankApplication.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
        {
            services
                .AddAuth(configuration)
                .AddContext(configuration)
                .AddPersistence();
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

            return services;
        }


        public static IServiceCollection AddPersistence(
            this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAdminstratorRepository, AdminstratorRepository>();
            services.AddScoped<IAccountsRepository, AccountsRepository>();
            services.AddScoped<ICustomerRepository, CustomersRepository>();
            services.AddScoped<ITransactionsRepository, TransactionsRepository>();
            services.AddScoped<IDispositionRepository, DispositionRepository>();

            return services;
        }

        public static IServiceCollection AddContext(
            this IServiceCollection services, ConfigurationManager configuration)
        {
            var dapperSettings = new DapperSettings();
            configuration.Bind(DapperSettings.SectionName, dapperSettings);
            services.AddSingleton(Options.Create(dapperSettings));
            services.AddSingleton<DapperContext>();

            return services;
        }

        public static IServiceCollection AddAuth(
        this IServiceCollection services, ConfigurationManager configuration)
        {
            var JwtSettings = new JwtSettings();
            configuration.Bind(JwtSettings.SectionName, JwtSettings);

            services.AddSingleton(Options.Create(JwtSettings));
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();

            services.AddAuthentication(defaultScheme: JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options => options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = JwtSettings.Issuer,
                    ValidAudience = JwtSettings.Audience,
                    IssuerSigningKey = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(JwtSettings.Secret))
                });
            return services;
        }
    }
}
