using HotChocolate.AspNetCore;

namespace HC_7572;

public class Startup
{
    private readonly IHostEnvironment _environment;

    public Startup(IConfiguration configuration, IHostEnvironment env)
    {
        _environment = env;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services
            .AddGraphQLServer()
            .ModifyOptions(opt => opt.StrictValidation = false)
            .AddHC_7572Types()
            .AddProjections()
            .AddFiltering()
            .AddSorting();
    }

    public void Configure(IApplicationBuilder app)
    {
        if (!_environment.IsDevelopment())
            app.UseHttpsRedirection();

        app
            .UseRouting()
            .UseWebSockets()
            .UseEndpoints(endpoint =>
                endpoint
                    .MapGraphQL()
                    .WithOptions(new GraphQLServerOptions
                    {
                        Tool = { Enable = _environment.IsDevelopment() }
                    })
            );
    }
}