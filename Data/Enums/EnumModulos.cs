using TicketManager.Data.Enums.Modulos;

namespace TicketManager.Data.Enums
{
    public enum EnumModulos
    {
        // Sistema M2
        M2Compras = EnumModuloM2.Compras,
        M2Contabil = EnumModuloM2.Contabil,
        M2Estoque = EnumModuloM2.Estoque,
        M2Expedicao = EnumModuloM2.Expedicao,
        M2Outros = EnumModuloM2.Outros,
        M2Pagar = EnumModuloM2.Pagar,
        M2Personalizacao = EnumModuloM2.Personalizacao,
        M2Receber = EnumModuloM2.Receber,
        M2Tesouraria = EnumModuloM2.Tesouraria,
        M2Vendas = EnumModuloM2.Vendas,


        // Sistema CRM
        CRMCaso = EnumModuloCRM.Caso,
        CRMConta = EnumModuloCRM.Conta,
        CRMOportunidade = EnumModuloCRM.Oportunidade,
        CRMPersonalizacao = EnumModuloCRM.Personalizacao,
        CRMOutros = EnumModuloCRM.Outros,

        // Sistema PCP
        PCPApontamento = EnumModuloPCP.Apontamento,
        PCPOp = EnumModuloPCP.Op,
        PCPProducao = EnumModuloPCP.Producao,
        PCPOutros = EnumModuloPCP.Outros,
        PCPPersonalizacaoPCP = EnumModuloPCP.PersonalizacaoPCP
    }
}
