using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace ProductSystem;

public class ProductSystemWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<ProductSystemWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
