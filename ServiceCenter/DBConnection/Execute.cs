using ServiceCenter.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter.DBConnection
{
    public class Execute
    {
        #region Private Variables
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAdp;
        #endregion

        public object Executes(string SelectQuery, ReturnType ReturnType, SqlParameter[] _SqlParameter, CommandType cmdType)
        {
            try
            {
                Object objValue = new object();
                switch (ReturnType)
                {
                    case (ReturnType.DataTable):
                        {
                            objValue = ReturnDataTable(SelectQuery, _SqlParameter, cmdType);
                        }
                        break;

                    case (ReturnType.DataSet):
                        {
                            objValue = ReturnDataSet(SelectQuery, _SqlParameter, cmdType);
                        }
                        break;

                    case (ReturnType.DataRow):
                        {
                            objValue = ReturnDataRow(SelectQuery, _SqlParameter, cmdType);
                        }
                        break;
                }
                return objValue;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object Executes(string SelectQuery, ReturnType ReturnType, CommandType cmdType)
        {
            try
            {
                Object objValue = new object();
                switch (ReturnType)
                {
                    case (ReturnType.DataTable):
                        {
                            objValue = ReturnDataTable(SelectQuery, cmdType);
                        }
                        break;

                    case (ReturnType.DataSet):
                        {
                            objValue = ReturnDataSet(SelectQuery, cmdType);
                        }
                        break;

                    case (ReturnType.DataRow):
                        {
                            objValue = ReturnDataRow(SelectQuery, cmdType);
                        }
                        break;
                }
                return objValue;
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }


        public int Executes(string cmdText, SqlParameter[] _SqlParameter, CommandType cmdType = CommandType.StoredProcedure)
        {
            int NoOfRowsEffected = 0;
            SqlCmd = new SqlCommand();
            SqlConnection conn = null;
            try
            {
                conn = ClsConnection.OpenConnectiion();
                SqlCmd.Connection = conn;
                SqlCmd.CommandType = cmdType;
                SqlCmd.CommandText = cmdText;
                SqlCmd.CommandTimeout = 600;
                for (int i = 0; i < _SqlParameter.Length; i++)
                    SqlCmd.Parameters.Add(_SqlParameter[i]);
                NoOfRowsEffected = SqlCmd.ExecuteNonQuery();
                return NoOfRowsEffected;
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Dispose();
                SqlCmd = null;
            }
        }

        public int ExecuteIdentity(string cmdText, SqlParameter[] _SqlParameter, CommandType cmdType = CommandType.StoredProcedure)
        {
            int linkID = 0;

            try
            {
                using (SqlConnection con = new SqlConnection(ClsConnection.GetConnection().ConnectionString))
                {
                    con.Open();
                    SqlCmd = new SqlCommand();
                    SqlCmd.Connection = con;

                    for (int i = 0; i < _SqlParameter.Length; i++)
                        SqlCmd.Parameters.Add(_SqlParameter[i]);


                    if (cmdType == CommandType.StoredProcedure)
                    {
                        SqlCmd.CommandType = CommandType.StoredProcedure;
                        SqlCmd.CommandText = cmdText;
                    }
                    else
                    {
                        cmdText += " SELECT CAST(scope_identity()as int)";
                        SqlCmd.CommandType = CommandType.Text;
                        SqlCmd.CommandText = cmdText;
                    }
                    linkID = (int)SqlCmd.ExecuteScalar();
                    return linkID;
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Return DataTable
        private DataTable ReturnDataTable(string SelectQuery, SqlParameter[] _SqlParameter, CommandType cmdType)
        {
            DataTable dt;
            SqlConnection conn = null;
            try
            {
                SqlCmd = new SqlCommand();
                dt = new DataTable();
                conn = ClsConnection.OpenConnectiion();
                SqlCmd.Connection = conn;
                SqlCmd.CommandText = SelectQuery;
                SqlCmd.CommandType = cmdType;
                SqlCmd.CommandTimeout = 60;
                for (int i = 0; i < _SqlParameter.Length; i++)
                {
                    SqlCmd.Parameters.Add(_SqlParameter[i]);
                }

                SqlAdp = new SqlDataAdapter(SqlCmd);
                SqlAdp.Fill(dt);

                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Dispose();
                SqlCmd = null;
            }
        }

        private DataTable ReturnDataTable(string SelectQuery, CommandType cmdType)
        {
            DataTable dt;
            SqlConnection conn = null;
            try
            {
                SqlCmd = new SqlCommand();
                dt = new DataTable();
                conn = ClsConnection.OpenConnectiion();
                SqlCmd.Connection = conn;
                SqlCmd.CommandText = SelectQuery;
                SqlCmd.CommandType = cmdType;
                SqlAdp = new SqlDataAdapter(SqlCmd);
                SqlAdp.Fill(dt);
                conn.Close();

                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Dispose();
                SqlCmd = null;
            }
        }

        #endregion

        #region Return DataSet

        private DataSet ReturnDataSet(string SelectQuery, SqlParameter[] _SqlParameter, CommandType cmdType)
        {
            DataSet ds;
            SqlConnection conn = null;
            try
            {
                SqlCmd = new SqlCommand();
                ds = new DataSet();

                conn = ClsConnection.OpenConnectiion();
                SqlCmd.Connection = conn;
                SqlCmd.CommandText = SelectQuery;
                SqlCmd.CommandType = cmdType;
                SqlCmd.CommandTimeout = 60;
                for (int i = 0; i < _SqlParameter.Length; i++)
                {
                    SqlCmd.Parameters.Add(_SqlParameter[i]);
                }

                SqlAdp = new SqlDataAdapter(SqlCmd);
                SqlAdp.Fill(ds);

                conn.Close();
                return ds;

            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Dispose();
                SqlCmd = null;
            }
        }

        private DataSet ReturnDataSet(string SelectQuery, CommandType cmdType)
        {
            DataSet ds;
            SqlConnection conn = ClsConnection.OpenConnectiion();
            try
            {
                SqlCmd = new SqlCommand();
                ds = new DataSet();

                SqlCmd.Connection = conn;
                SqlCmd.CommandText = SelectQuery;
                SqlCmd.CommandType = cmdType;
                SqlAdp = new SqlDataAdapter(SqlCmd);
                SqlAdp.Fill(ds);

                return ds;
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Dispose();
                SqlCmd = null;
            }
        }
        #endregion

        #region Return DataRow
        private DataRow ReturnDataRow(string SelectQuery, CommandType cmdType)
        {

            DataTable dt;
            SqlConnection conn = null;
            try
            {
                SqlCmd = new SqlCommand();
                dt = new DataTable();
                conn = ClsConnection.OpenConnectiion();

                SqlCmd.Connection = conn;
                SqlCmd.CommandText = SelectQuery;
                SqlCmd.CommandType = cmdType;
                SqlAdp = new SqlDataAdapter(SqlCmd);
                SqlAdp.Fill(dt);

                return dt.Rows[0];
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Dispose();
                SqlCmd = null;
            }



        }


        private DataRow ReturnDataRow(string SelectQuery, SqlParameter[] _SqlParameter, CommandType cmdType)
        {

            DataTable dt;
            SqlConnection conn = null;
            try
            {
                SqlCmd = new SqlCommand();
                dt = new DataTable();
                conn = ClsConnection.OpenConnectiion();

                SqlCmd.Connection = conn;
                SqlCmd.CommandText = SelectQuery;
                SqlCmd.CommandType = cmdType;
                SqlCmd.CommandTimeout = 60;
                for (int i = 0; i < _SqlParameter.Length; i++)
                {
                    SqlCmd.Parameters.Add(_SqlParameter[i]);
                }

                SqlAdp = new SqlDataAdapter(SqlCmd);
                SqlAdp.Fill(dt);
                if (dt.Rows.Count == 0)
                    return null;

                return dt.Rows[0];
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Dispose();
                SqlCmd = null;

            }
        }
        #endregion

        #region SQL Parameter
        public static SqlParameter AddParameter(string Name, object Value)
        {
            SqlParameter Parm;
            try
            {
                Parm = new SqlParameter();
                Parm.ParameterName = Name;
                Parm.Value = Value;

                return Parm;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}

