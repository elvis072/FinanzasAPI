using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanzasAPI.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace FinanzasAPI
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<FinanzasDB>(options => options.UseSqlServer(Configuration.GetConnectionString("FinanzasDB")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            //using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            //{
            //    var context = serviceScope.ServiceProvider.GetRequiredService<FinanzasDB>();
            //    context.Database.EnsureDeleted();          
            //    context.Database.EnsureCreated();
            //    context.TasaCambio.AddRange(new TasaCambio[] {
            //        new TasaCambio { CodigoMoneda = "USD", Cambio = 53.95f, Fecha = DateTime.Now },
            //        new TasaCambio { CodigoMoneda = "EUR", Cambio = 60.92f, Fecha = DateTime.Now },
            //        new TasaCambio { CodigoMoneda = "GBP", Cambio = 69.04f, Fecha = DateTime.Now },
            //    });
            //    context.Inflacion.AddRange(new Inflacion[] {
            //        new Inflacion { Indice = 6.4f, Fecha = DateTime.Now },
            //        new Inflacion { Indice = 4.7f, Fecha = DateTime.Now.AddYears(1) },
            //        new Inflacion { Indice = 3.5f, Fecha = DateTime.Now.AddYears(2) },
            //        new Inflacion { Indice = 10.4f, Fecha = DateTime.Now.AddYears(3) }
            //    });
            //    context.SaludFinanciera.AddRange(new SaludFinanciera[] {
            //        new SaludFinanciera { Cedula = "40210356743", Indicador = true, TotalAdeudado = 20000, Comentario = "Prestamo" },
            //        new SaludFinanciera { Cedula = "00145674345", Indicador = true, TotalAdeudado = 30000f, Comentario = "Avance de salario" },
            //        new SaludFinanciera { Cedula = "40245564780", Indicador = false }
            //    });
            //    context.HistorialCrediticio.AddRange(new HistorialCrediticio[] {
            //        new HistorialCrediticio { Cedula = "40210356743", ConceptoDeuda = "Pago nomina", RncEmpresa = "123456789", TotalAdeudado = 200000, Fecha = DateTime.Now },
            //        new HistorialCrediticio { Cedula = "00145674345", ConceptoDeuda = "Capacitacion", RncEmpresa = "123456789", TotalAdeudado = 200000, Fecha = DateTime.Now }
            //    });
            //    context.SaveChanges();
            //}

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
