using System.Text;

namespace TicketManager.Data.Exportador
{
    public static class CsvExporter
    {
        public static string ExportarParaCsv(IEnumerable<Casos.Caso> tickets)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Id;Numero;Cliente;Sistema;Modulo;Problema;Solucao;Data");

            foreach (var t in tickets)
            {
                // Escape simples de ponto-e-vírgula e quebras de linha
                static string Safe(string s) => string.IsNullOrEmpty(s) ? "" : s.Replace("\r", " ").Replace("\n", " ").Replace(";", ",");

                var line = string.Join(";",
                [
                    t.Id.ToString(),
                    t.Numero.ToString(),
                    Safe(t.Cliente.ToString()),
                    t.Sistema.GetDescription(),
                    t.Modulo.ToString(),
                    Safe(t.Problema),
                    Safe(t.Solucao),
                    t.Data.ToString("yyyy-MM-dd HH:mm:ss")
                ]);

                sb.AppendLine(line);
            }

            return sb.ToString();
        }
    }
}
