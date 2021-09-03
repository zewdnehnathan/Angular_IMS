using Inventory.API.Authentication;
using Inventory.Application;
using Inventory.Application.Dto;
using Inventory.Application.Features;
using Inventory.Application.Interfaces;
using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Facade;
using Inventory.Domain.Interfaces.Repository;
using Inventory.Domain.Model;
using Inventory.Domain.Seed;
using Inventory.Infrastructure;
using Inventory.Infrastructure.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

namespace Inventory.API
{
    public class Startup
    {
        private const string SECRETKEY = "TQvgjeABMPOwCycOqah5EQu5yyVjpmVGTQvgjeABMPOwCycOqah5Equ5yyVjpmVGTQvgjeABMPOwCycOqah5EQu5yyVjpmVG";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<InventoryContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddTransient<IIssuanceRepository, IssuanceRepository>();
            services.AddTransient<IService<IssuanceDto, IssuanceEntity>, IssuanceService>();
          
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Inventory.API", Version = "v1" });
            });


            services.RegisterApplicationService(Configuration);
            services.RegisterInfrastructureService(Configuration);

            services.AddControllers();

            services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = "JwtBearer";
                option.DefaultChallengeScheme = "JwtBearer";
            })
           .AddJwtBearer("JwtBearer", jwtOptions =>
           {
               jwtOptions.TokenValidationParameters = new TokenValidationParameters()
               {
                   IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(SECRETKEY)),
                   ValidateIssuer = false,
                   ValidateAudience = false,
                   ValidateLifetime = true

               };
           });
            services.AddSingleton<IJwtAuth>(new Auth(SECRETKEY));

        }
      
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Inventory.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseCors(builder => builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
