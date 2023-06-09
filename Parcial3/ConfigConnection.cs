using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace Parcial3
{
    public static class ConfigConnection
    {
        public static string connectionString =
            ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
    }
}
