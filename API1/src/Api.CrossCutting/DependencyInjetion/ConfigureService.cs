using Microsoft.Extensions.DependencyInjection;
using Api.Domain.Interface;
using Api.Services;

namespace Api.CrossCutting.DependencyInjetion
{
    public class ConfigureService
    {
        public static void ConfigureDependencyServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ICorrecaoService, CorrecaoService>();
        }
    }
}
