using MadeFy.Services;
using MadeFy.Services.InterfaceServices;
using Microsoft.Extensions.DependencyInjection;

namespace MadeFy.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddScoped<ICategoriaService, CategoriaService>()
                .AddScoped<IProdutoService, ProdutoService>();
        }
    }
}
