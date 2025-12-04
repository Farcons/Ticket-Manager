using TicketManager.DbContexts.Base;

namespace TicketManager.Data.Casos
{
    public interface IRepCaso : IBaseDbContext<Caso>
    {
        Guid Adicionar(Caso caso);
        void Excluir(Guid id);
        bool NumeroExiste(int numero);
        bool NumeroExiste(Guid idDesconsiderar, int numero);
        void PersistirTransacao();
        IQueryable<Caso> Recuperar();
    }
}
