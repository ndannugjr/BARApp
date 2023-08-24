using BAR.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAR.Core.Classes
{
    public static class RuntimeInfo
    {
        public static string UserName { get; set; }
        public static int UserId { get; set; }
        public static string Name { get; set; }
        public static bool isAdmin { get; set; }
        public static string Grade { get; set; }
        public static List<MenuNavigation> Menu { get; set; }
    }
}
