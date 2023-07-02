using MadeFy.Services;
using MadeFy.Services.Interfaces;
using MadeFy.Services.InterfaceServices;
using MadeFy.Services.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace MadeFy.ConsoleApp
{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<ICategoriaService, CategoriaService>();
            services.AddScoped<IProdutoService, ProdutoService>();
        }
    }
}
