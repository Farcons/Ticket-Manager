using TicketManager.DbContexts.Base;

namespace TicketManager.Data.Clientes
{
    public class Cliente : SystemBaseIdentifier
    {
        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
