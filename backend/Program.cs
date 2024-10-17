using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web;
using TravelBuddyAPI.Data;
using Microsoft.OpenApi.Models;
using TravelBuddyAPI.Endpoints;
using Microsoft.Extensions.Options;

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


            builder.Services.Configure<JwtBearerOptions>(JwtBearerDefaults.AuthenticationScheme, options =>
            {
                options.TokenValidationParameters.ValidateIssuer = true;
                options.TokenValidationParameters.ValidAudience = builder.Configuration["AzureAd:ClientId"];
            });
            builder.Services.AddAuthorization();

            // Register NBPClient as a service
            builder.Services.AddScoped<Services.NBPClient>();

            builder.Services.AddEndpointsApiExplorer();

            // Register GeoapifyClient as a service
            builder.Services.AddScoped<Services.GeoapifyClient>();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "TravelBuddyAPI", Version = "v1" });

                // Add Bearer token authentication
                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please enter a valid token",
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    BearerFormat = "JWT",
                    Scheme = "Bearer"
                });

                options.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] {}
                    }
                });
            });

            // Adding secrets to the configuration from .env file
            if (builder.Environment.IsDevelopment())
            {
                DotNetEnv.Env.Load(); // For running app outside of Docker
                builder.Configuration["CLIENT_SECRET"] = DotNetEnv.Env.GetString("CLIENT_SECRET");
                builder.Configuration["MSSQL_SA_PASSWORD"] = DotNetEnv.Env.GetString("MSSQL_SA_PASSWORD");
                builder.Configuration["GEOAPIFY_KEY"] = DotNetEnv.Env.GetString("GEOAPIFY_KEY");
            }

            builder.Services.Configure<MicrosoftIdentityOptions>(options =>
            {
                options.ClientSecret = builder.Configuration["CLIENT_SECRET"];
            });

            builder.Services.AddDbContext<TravelBuddyDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("TravelBuddyDb")?.Replace("{MSSQL_SA_PASSWORD}", builder.Configuration["MSSQL_SA_PASSWORD"]));
                
            });

            var app = builder.Build();

            // Development configuration
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

            // Development enpoints
            if (app.Environment.IsDevelopment())
            {
                app.MapGeoapifyEndpoints();
            }

            // Set the culture to US
            var cultureInfo = new System.Globalization.CultureInfo("en-US");
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

            // Development enpoints
            if (app.Environment.IsDevelopment())
            {
                app.MapNBPEndpoints();
            }

             // Set the culture to US
            var cultureInfo = new System.Globalization.CultureInfo("en-US");
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;


            app.Run();
        }
    }
}
