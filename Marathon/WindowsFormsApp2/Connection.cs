using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 

namespace WindowsFormsApp2
{
    class Connection
    {
        //internal static string ConnectionStr = @"Data Source=MSSQLSTUD;Initial Catalog=Marathon_Revkin;User ID=9po11-18-18;Password=cefooK4co;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        internal static string ConnectionStr = @"Data Source=DESKTOP-HE0CRVU\SQLEXP;Initial Catalog=Marathon_Revkin;User ID=Ilya;Password=1;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        internal static SqlConnection connection = new SqlConnection(ConnectionStr);

        internal static string userLogin = "";
    }
}
