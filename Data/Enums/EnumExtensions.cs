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
            var prefixes = new[] { "M2", "CRM", "PCP" };
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
                _ => "badge bg-secondary"
            };
        }

        // Classe CSS para badges por módulo (gera variações simples)
        public static string GetModuloBadgeClass(this EnumModulos modulo)
        {
            var v = (int)modulo;
            if (v >= 1000 && v < 2000) return "badge bg-primary";
            if (v >= 2000 && v < 3000) return "badge bg-success";
            if (v >= 3000 && v < 4000) return "badge bg-warning text-dark";
            return "badge bg-secondary";
        }
    }
}
