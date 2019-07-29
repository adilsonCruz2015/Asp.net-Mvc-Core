using AppModelo.Site.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace AppModelo.Site
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Mudando a pasta de Areas para Modulos
            MudarDeAreaParaModulo.Configurar(services);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddTransient<IPedidoRepository, PedidoRepository>();

            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvc(routes => 
            {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");

                //routes.MapRoute("areas", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                routes.MapAreaRoute("AreaProdutos", "Produtos", "Produtos/{controller=Cadastro}/{action=Index}/{id?}");
                routes.MapAreaRoute("AreaVendas", "Vendas", "Vendas/{controller=Pedidos}/{action=Index}/{id?}");
            });
        }
    }
}
