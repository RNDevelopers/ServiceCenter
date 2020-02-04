using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter.DBConnection
{
    public class ClsConnection
    {

        private static string connetionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;

    }
}
