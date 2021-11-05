using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Sennin.API.Infraestrutura;
using Sennin.API.Interfaces;
using Sennin.API.Model;
using Sennin.API.Repository;

namespace Sennin.API
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
            var databaseOptions = new DatabaseOptions();
            Configuration.Bind(nameof(DatabaseOptions), databaseOptions);
            services.AddSingleton(databaseOptions);

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Sennin.API", Version = "v1" });
                c.EnableAnnotations();
            });

            services.AddScoped<DbSession>();

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IRepository<Pais>, PaisRepository>();
            services.AddTransient<IRepository<Estado>, EstadoRepository>();
            services.AddTransient<IRepository<Cidade>, CidadeRepository>();
            services.AddTransient<IRepository<Bairro>, BairroRepository>();
            services.AddTransient<IRepository<Endereco>, EnderecoRepository>();
            services.AddTransient<IRepository<Cliente>, ClienteRepository>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Sennin.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
