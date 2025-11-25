using TicketManager.DbContexts.Base;

namespace TicketManager.Data.Clientes
{
    public interface IRepCliente : IBaseDbContext<Cliente>
    {
        Guid Adicionar(Cliente cliente);
        void Excluir(Guid id);
        bool NomeExiste(string nome);
    }
}
