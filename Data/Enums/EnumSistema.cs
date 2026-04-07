using System.ComponentModel;

namespace TicketManager.Data.Enums
{
    public enum EnumSistema
    {
        [Description("M2")]
        M2 = 0,

        [Description("PCP")]
        PCP = 1,

        [Description("CRM")]
        CRM = 2,

        [Description("Serviços")]
        SERVICOS = 3,

        [Description("Contratos")]
        CONTRATOS = 4,

        [Description("Loja")]
        LOJA = 5,

        [Description("DF-E")]
        DFE = 6,
    }
}
