using TicketManager.Data.Clientes;
using TicketManager.Data.Enums;
using TicketManager.DbContexts.Base;

namespace TicketManager.Data.Casos;

public class Caso : SystemBaseIdentifier
{
    public int Numero { get; set; }
    public Guid CodigoCliente { get; set; } = Guid.Empty;
    public EnumSistema Sistema { get; set; }
    public EnumModulos Modulo { get; set; }
    public string Problema { get; set; }
    public string Solucao { get; set; }
    public DateTime Data { get; set; } = DateTime.Now;

    public virtual Cliente Cliente { get; set; }
}