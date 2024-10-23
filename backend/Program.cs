using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Identity.Web;
using TravelBuddyAPI.Endpoints;

namespace TravelBuddyAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Load environment variables and set client secret
            if (builder.Environment.IsDevelopment())
            {
                DotNetEnv.Env.Load();
                builder.Configuration["CLIENT_SECRET"] = DotNetEnv.Env.GetString("CLIENT_SECRET");
            }

            builder.Services.Configure<MicrosoftIdentityOptions>(options =>
            {
                options.ClientSecret = builder.Configuration["CLIENT_SECRET"];
            });

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
            
            // Mapping endpoints
            app.MapTripsEndpoints();
            app.MapCategoryProfilesEndpoints();
            app.MapConditionProfilesEndpoints();
            app.MapTransferPointsEndpoints();
            app.MapTripPointsEndpoints();
            app.MapPlacesEndpoints();
            app.MapFavouriteProfilesEndpoints();

            app.Run();
        }
    }
}
