using TicketManager.DbContexts.Base;

namespace TicketManager.Data.Clientes
{
    public class RepCliente(AppDbContext dbContext) : BaseDbContext<Cliente>(dbContext), IRepCliente
    {
        public Guid Adicionar(Cliente cliente)
        {
            cliente.Id = Guid.NewGuid();

            _dbContext.Add(cliente);
            SaveChanges();

            return cliente.Id;
        }

        public void Excluir(Guid id)
        {
            var cliente = Find(id);
            _dbContext.Remove(cliente);

            SaveChanges();
        }

        public bool NomeExiste(string nome) => _dbSet.Any(p => p.Nome == nome);
    }
}
