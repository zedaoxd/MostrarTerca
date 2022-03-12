using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrarTerca.Persistence
{
    public class Conn
    {
        private static string _server = @"(localdb)\MSSQLLocalDB";
        private static string _dataBase = "AgenciaAuto";
        private static string _user = "bruno";
        private static string _password = "";

        public static string StrConn => $"Data Source={_server}; integrated Security=true;Initial Catalog={_dataBase}; User Id={_user}; Password={_password}";
    }
}
