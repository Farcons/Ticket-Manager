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
        PCPPersonalizacaoPCP = EnumModuloPCP.PersonalizacaoPCP,

        //Sistema Serviços
        SERVPropostas = EnumModuloServicos.Propostas,
        SERVServicos = EnumModuloServicos.Servicos,
        SERVSolicitacaoServicos = EnumModuloServicos.SolicitacaoServicos,
        SERVOrdemServico = EnumModuloServicos.OrdemServico,
        SERVFaturamento = EnumModuloServicos.Faturamento,
        SERVPainelControle = EnumModuloServicos.PainelControle,
        SERVAgendaRecursos = EnumModuloServicos.AgendaRecursos,
        SERVGeral = EnumModuloServicos.Geral,
        SERVOutros = EnumModuloServicos.Outros,
        SERVPersonalizacao = EnumModuloServicos.Personalizacao,

        //Sistema Contratos
        CTContratos = EnumModuloContratos.Contratos,
        CTGeral = EnumModuloContratos.Geral,
        CTOutros = EnumModuloContratos.Outros,
        CTPersonalizacao = EnumModuloContratos.Personalizacao,

        //Sistema Loja
        LJBalcao = EnumModuloLoja.Balcao,
        LJCaixa = EnumModuloLoja.Caixa,
        LJEntrega = EnumModuloLoja.Entrega,
        LJIntegracao = EnumModuloLoja.Integracao,
        LJGeral = EnumModuloLoja.Geral,
        LJOutros = EnumModuloLoja.Outros,
        LJPersonalizacao = EnumModuloLoja.Personalizacao,

        //Sistema DF-E
        DFECredenciamento = EnumModuloDFE.Credenciamento,
        DFEServicos = EnumModuloDFE.Servicos,
        DFENFe = EnumModuloDFE.NFe,
        DFENFSe = EnumModuloDFE.NFSe,
        DFEMDFe = EnumModuloDFE.MDFe,
        DFECTe = EnumModuloDFE.CTe,
        DFEGeral = EnumModuloDFE.Geral,
        DFEOutros = EnumModuloDFE.Outros,
        DFEPersonalizacao = EnumModuloDFE.Personalizacao,
    }
}
