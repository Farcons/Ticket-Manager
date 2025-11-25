using Microsoft.EntityFrameworkCore;
using TicketManager.DbContexts.Base;

namespace TicketManager.Data.Casos
{
    public class RepCaso(AppDbContext dbContext) : BaseDbContext<Caso>(dbContext), IRepCaso
    {
        public Guid Adicionar(Caso caso)
        {
            caso.Id = Guid.NewGuid();

            _dbContext.Add(caso);
            SaveChanges();

            return caso.Id;
        }

        public void Excluir(Guid id)
        {
            var caso = Find(id);
            _dbContext.Remove(caso);

            SaveChanges();
        }

        public IQueryable<Caso> Recuperar()
        {
            return _dbSet.Include(p => p.Cliente);
        }

        public bool NumeroExiste(int numero) => _dbSet.Any(p => p.Numero == numero);
    }
}
