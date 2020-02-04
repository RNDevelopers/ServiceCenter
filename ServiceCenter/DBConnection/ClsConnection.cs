using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter.DBConnection
{
    public class ClsConnection
    {
        public static SqlConnection OpenConnectiion()
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings.Get("ConnStr").ToString());


                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
                else
                    con.Close();
                return con;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static SqlConnection GetConnection()
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings.Get("ConnStr").ToString());

                return con;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}

