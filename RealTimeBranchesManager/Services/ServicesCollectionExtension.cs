using System;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RealTimeBranchesManager.Data;

namespace RealTimeBranchesManager.Services;

public static class ServicesCollectionExtension
{
    public static void AddServices(this IServiceCollection services, IConfiguration config) { }

    public static void AddDbServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContextPool<DataContext>(options =>
            options.UseNpgsql(config["DatabaseConnectionLink"])
        );
    }
}
