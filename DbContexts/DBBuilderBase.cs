using Microsoft.EntityFrameworkCore;
using TicketManager.Data.Casos;
using TicketManager.Data.Clientes;
using TicketManager.DbContexts.Base;

namespace TicketManager.DbContexts
{
    public class DBBuilderBase
    {
        public void ModelCreating(WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite($"Data Source=casos.db").UseLazyLoadingProxies());

            builder.Services.AddScoped<IRepCaso, RepCaso>();
            builder.Services.AddScoped<IRepCliente, RepCliente>();

            builder.Services.AddScoped(typeof(IBaseDbContext<>), typeof(BaseDbContext<>));
        }
    }
}
