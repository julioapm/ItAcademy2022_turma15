using Okta.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services
        .AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = OktaDefaults.ApiAuthenticationScheme;
            options.DefaultChallengeScheme = OktaDefaults.ApiAuthenticationScheme;
            options.DefaultSignInScheme = OktaDefaults.ApiAuthenticationScheme;
        })
        .AddOktaWebApi(new OktaWebApiOptions()
        {
            OktaDomain = builder.Configuration["Okta:OktaDomain"]
        });

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}