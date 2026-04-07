using System.ComponentModel;
using System.Reflection;
using TicketManager.Data.Enums;

namespace TicketManager.Data
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            if (value == null) return string.Empty;
            var field = value.GetType().GetField(value.ToString());
            if (field == null) return value.ToString();
            var attr = field.GetCustomAttribute<DescriptionAttribute>();
            return attr?.Description ?? value.ToString();
        }

        public static string GetFriendlyModuleName(this EnumModulos modulo)
        {
            var name = modulo.ToString();
            var prefixes = new[] { "SERV", "CRM", "PCP", "M2", "CT", "LJ", "DFE" };
            foreach (var p in prefixes)
            {
                if (name.StartsWith(p, StringComparison.OrdinalIgnoreCase))
                    return name.Substring(p.Length);
            }
            return name;
        }

        // Classe CSS para badges por sistema (você pode ajustar as classes)
        public static string GetSistemaBadgeClass(this EnumSistema sistema)
        {
            return sistema switch
            {
                EnumSistema.M2 => "badge bg-primary",
                EnumSistema.CRM => "badge bg-success",
                EnumSistema.PCP => "badge bg-warning text-dark",
                EnumSistema.SERVICOS => "badge",
                EnumSistema.LOJA => "badge",
                EnumSistema.CONTRATOS => "badge",
                EnumSistema.DFE => "badge bg-secondary",
                _ => "badge bg-secondary"
            };
        }

        // Estilo inline para badges com cores customizadas por sistema
        public static string GetSistemaBadgeStyle(this EnumSistema sistema)
        {
            return sistema switch
            {
                EnumSistema.SERVICOS => "background-color:#191970;color:#fff;",
                EnumSistema.LOJA => "background-color:#D2691E;color:#fff;",
                EnumSistema.CONTRATOS => "background-color:#FA8072;color:#fff;",
                _ => ""
            };
        }

        // Classe CSS para badges por módulo (gera variações simples)
        public static string GetModuloBadgeClass(this EnumModulos modulo)
        {
            var v = (int)modulo;
            if (v >= 1000 && v < 2000) return "badge bg-primary";        // M2
            if (v >= 2000 && v < 3000) return "badge bg-success";        // CRM
            if (v >= 3000 && v < 4000) return "badge bg-warning text-dark"; // PCP
            if (v >= 4000 && v < 5000) return "badge";                   // Serviços
            if (v >= 5000 && v < 6000) return "badge";                   // Contratos
            if (v >= 6000 && v < 7000) return "badge";                   // Loja
            if (v >= 7000 && v < 8000) return "badge bg-secondary";      // DFE
            return "badge bg-secondary";
        }

        // Estilo inline para badges com cores customizadas por módulo
        public static string GetModuloBadgeStyle(this EnumModulos modulo)
        {
            var v = (int)modulo;
            if (v >= 4000 && v < 5000) return "background-color:#191970;color:#fff;"; // Serviços
            if (v >= 5000 && v < 6000) return "background-color:#FA8072;color:#fff;"; // Contratos
            if (v >= 6000 && v < 7000) return "background-color:#D2691E;color:#fff;"; // Loja
            return "";
        }

    }
}
