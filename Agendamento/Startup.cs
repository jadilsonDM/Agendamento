using Application.Servi�os;
using Core.Entity;
using Core.Interface;
using Infraestructure.Persistence;
using Infraestructure.Repositorio;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agendamento
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
            services.AddControllersWithViews();
            services.AddDbContext<AgendamentoDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Conexao")));
            services.AddScoped<IPacienteRepositorio, PacienteRepositorio>();
            services.AddScoped<IConsultaRepositorio, ConsultaRepositorio>();
            services.AddScoped<IGenericoRepository<Exame>, ExameRepositorio>();
            services.AddScoped<IGenericoRepository<TipoDeExame>, TipoDeExameRepositorio>();
            services.AddScoped<IPacienteServico, PacienteServico>();
            services.AddScoped<IConsultaServico, ConsultaServico>();
            services.AddScoped<IGenericoServico<Exame>, ExameServico>();
            services.AddScoped<IGenericoServico<TipoDeExame>, TipoDeExameServico>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
