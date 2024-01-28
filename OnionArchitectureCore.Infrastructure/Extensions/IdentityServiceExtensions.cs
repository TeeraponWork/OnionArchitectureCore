﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using OnionArchitectureCore.Application.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace OnionArchitectureCore.Infrastructure.Extensions
{
    public static class IdentityServiceExtensions
    {
        //public static IServiceCollection AddIdentityServices(this IServiceCollection services,
        //    IConfiguration config)
        //{
        //    services.AddIdentityCore<AppUserModel>(opt =>
        //    {
        //        opt.Password.RequireNonAlphanumeric = false;
        //        opt.User.RequireUniqueEmail = true;
        //    })
        //    .AddEntityFrameworkStores<DataContext>();

        //    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["TokenKey"]));

        //    services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        //        .AddJwtBearer(opt =>
        //        {
        //            opt.TokenValidationParameters = new TokenValidationParameters
        //            {
        //                ValidateIssuerSigningKey = true,
        //                IssuerSigningKey = key,
        //                ValidateIssuer = false,
        //                ValidateAudience = false,
        //                ValidateLifetime = true,
        //                ClockSkew = TimeSpan.Zero
        //            };
        //            opt.Events = new JwtBearerEvents
        //            {
        //                OnMessageReceived = context =>
        //                {
        //                    var accessToken = context.Request.Query["access_token"];
        //                    var path = context.HttpContext.Request.Path;
        //                    if (!string.IsNullOrEmpty(accessToken) && (path.StartsWithSegments("/chat")))
        //                    {
        //                        context.Token = accessToken;
        //                    }
        //                    return Task.CompletedTask;
        //                }
        //            };
        //        });

        //    services.AddAuthorization(opt =>
        //    {
        //        opt.AddPolicy("IsActivityHost", policy =>
        //        {
        //            policy.Requirements.Add(new IsHostRequirement());
        //        });
        //    });

        //    services.AddTransient<IAuthorizationHandler, IsHostRequirementHandler>();
        //    services.AddScoped<TokenService>();

        //    return services;
        //}
    }
}