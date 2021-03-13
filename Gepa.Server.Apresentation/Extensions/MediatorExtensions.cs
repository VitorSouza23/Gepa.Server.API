using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Gepa.Server.Apresentation.Extensions
{
    public static class MediatorExtensions
    {
        public static void AddMediator(this IServiceCollection services)
        {
            services.AddMediatR(typeof(Application.AppModule));
        }
    }
}