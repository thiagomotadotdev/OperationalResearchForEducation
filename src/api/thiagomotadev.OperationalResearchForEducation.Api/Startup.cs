using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerUI;
using Microsoft.AspNetCore.Mvc;
using thiagomotadev.OperationalResearchForEducation.Api.CustomizedAutoMapper;

namespace thiagomotadev.OperationalResearchForEducation.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSingleton(new CustomizedMapperConfiguration().CreateMapper());

            services.AddSwaggerGen();

            services.Configure<CorsPolicy>(Configuration.GetSection("CorsPolicy"));

            services.Configure<JsonOptions>(Configuration.GetSection("JsonOptions"));
            
            services.Configure<SwaggerOptions>(Configuration.GetSection("SwaggerOptions"));

            services.Configure<SwaggerGenOptions>(Configuration.GetSection("SwaggerGenOptions"));

            services.Configure<SwaggerUIOptions>(Configuration.GetSection("SwaggerUIOptions"));

            new OperationalResearchForEducation.Startup.Startup().ConfigureServices(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UsePathBase("/api/v1");

            app.UseSwagger();

            if (env.IsDevelopment())
            {
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
