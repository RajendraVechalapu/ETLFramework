using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Perf_Light
{
    public class BaseDataAccess
    {
        protected string ConnectionString { get; set; }

        public BaseDataAccess()
        {
        }

        public BaseDataAccess(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private SqlConnection GetConnection(string connectionStringlc)
        {
            SqlConnection connection = new SqlConnection(connectionStringlc);
            if (connection.State != ConnectionState.Open)
                connection.Open();
            return connection;
        }

        public DbCommand GetCommand(DbConnection connection, string commandText, CommandType commandType)
        {
            SqlCommand command = new SqlCommand(commandText, connection as SqlConnection);
            command.CommandType = commandType;
            return command;
        }

        protected SqlParameter GetParameter(string parameter, object value)
        {
            SqlParameter parameterObject = new SqlParameter(parameter, value != null ? value : DBNull.Value);
            parameterObject.Direction = ParameterDirection.Input;
            return parameterObject;
        }

        protected SqlParameter GetParameterOut(string parameter, SqlDbType type, object value = null, ParameterDirection parameterDirection = ParameterDirection.InputOutput)
        {
            SqlParameter parameterObject = new SqlParameter(parameter, type); ;

            if (type == SqlDbType.NVarChar || type == SqlDbType.VarChar || type == SqlDbType.NText || type == SqlDbType.Text)
            {
                parameterObject.Size = -1;
            }

            parameterObject.Direction = parameterDirection;

            if (value != null)
            {
                parameterObject.Value = value;
            }
            else
            {
                parameterObject.Value = DBNull.Value;
            }

            return parameterObject;
        }
        /*
        public int ExecuteNonQuery(string procedureName, SqlParameter[] parameters, CommandType commandType = CommandType.StoredProcedure)
        {
            int returnValue = -1;

            try
            {
                using (SqlConnection connection = this.GetConnection())
                {
                    var cmd = this.GetCommand(connection, procedureName, commandType);

                    if (parameters != null && parameters.Count() > 0)
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());
                    }

                    returnValue = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                //LogException("Failed to ExecuteNonQuery for " + procedureName, ex, parameters);
                throw;
            }

            return returnValue;
        }
        */
        /*
        protected object ExecuteScalar(string procedureName, List<SqlParameter> parameters)
        {
            object returnValue = null;

            try
            {
                using (DbConnection connection = this.GetConnection())
                {
                    DbCommand cmd = this.GetCommand(connection, procedureName, CommandType.StoredProcedure);

                    if (parameters != null && parameters.Count > 0)
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());
                    }

                    returnValue = cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                //LogException("Failed to ExecuteScalar for " + procedureName, ex, parameters);
                throw;
            }

            return returnValue;
        }
        */
        //public DbDataReader GetDataReader(string procedureName, List<DbParameter> parameters, CommandType commandType = CommandType.StoredProcedure)
        //{
        //    DbDataReader ds;

        //    try
        //    {
        //        DbConnection connection = this.GetConnection();
        //        {
        //            DbCommand cmd = this.GetCommand(connection, procedureName, commandType);
        //            if (parameters != null && parameters.Count > 0)
        //            {
        //                cmd.Parameters.AddRange(parameters.ToArray());
        //            }

        //            ds = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //LogException("Failed to GetDataReader for " + procedureName, ex, parameters);
        //        throw;
        //    }

        //    return ds;
        //}
        public DataSet GetDataSet(string ConnectionString, string SQL)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = this.GetConnection(ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandTimeout = 0;
                    cmd.CommandText = SQL;
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                //LogException("Failed to ExecuteScalar for " + procedureName, ex, parameters);
                MessageBox.Show(ex.Message);
                return null;
            }

            return ds;
        }
        //public SqlDataReader GetDataReader(string ConnectionString, string SQL)
        //{
        //    DataSet ds = new DataSet();
        //    try
        //    {
        //        using (SqlConnection connection = this.GetConnection())
        //        {
                    
        //            SqlCommand cmd = connection.CreateCommand();
        //            cmd.CommandTimeout = 0;
        //            cmd.CommandText = SQL;
        //            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        //            return reader;
                    
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //LogException("Failed to ExecuteScalar for " + procedureName, ex, parameters);
        //        MessageBox.Show(ex.Message);
        //        return null;
        //    }

            
        //}
        public DataSet getAnswersByQuestionPaging(string ConnectionString, string procedureName,int QID,int pageno,string conn)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = this.GetConnection(conn))
                {
                   //SqlDataAdapter da = new SqlDataAdapter();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    cmd.CommandText = procedureName;
                    cmd.Parameters.Add(new SqlParameter("@pageno", SqlDbType.Int)).Value = pageno;
                    cmd.Parameters.Add(new SqlParameter("@QID", SqlDbType.Int)).Value = QID;

                    cmd.ExecuteNonQuery();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    // Fill the DataSet using default values for DataTable names, etc
                    da.Fill(ds);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ds;
        }
        /*
        public DataSet GetDataSetByQuestionProcedure(string ConnectionString, string procedureName,string question)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = this.GetConnection())
                {
                    //SqlDataAdapter da = new SqlDataAdapter();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.CommandText = procedureName;
                    cmd.Parameters.Add(new SqlParameter("@Question", SqlDbType.NVarChar)).Value = question;

                    cmd.ExecuteNonQuery();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    
                    da.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                //LogException("Failed to ExecuteScalar for " + procedureName, ex, parameters);
                throw;
            }


            return ds;
        }
        */
        public void executeScript(string ConnectionString, string script)
        {
            
            try
            {
                using (SqlConnection connection = this.GetConnection(ConnectionString))
                {
                    //SqlDataAdapter da = new SqlDataAdapter();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.CommandText = "spr_executeSQLObjectScript";
                    cmd.Parameters.Add(new SqlParameter("@ScriptQuery", SqlDbType.NVarChar)).Value = script;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                //LogException("Failed to ExecuteScalar for " + procedureName, ex, parameters);
                throw;
            }
        }

        public void InsertUpdateSourceDataLoadDetails(string SourceServer
           , string SourceDatabase
           , string SourceTable
           , string SourceQuery
           , string LandingTargetTable
           , string TargetTable
           , string HighWaterMarkColumn
           , string AutoIdentityColumn
           , string KeyColumns,string SourceTableColumnNames, string DataLoadType,string conn )
        {

            string[] LandingTablestr = LandingTargetTable.Split('.');

            try
            {
                using (SqlConnection connection = this.GetConnection(conn))
                {
                    //SqlDataAdapter da = new SqlDataAdapter();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.CommandText = "spr_InsertUpdateSourceDataLoadDetails";
                    cmd.Parameters.Add(new SqlParameter("@SourceServer", SqlDbType.NVarChar, -1)).Value = SourceServer;
                    cmd.Parameters.Add(new SqlParameter("@SourceDatabase", SqlDbType.NVarChar, -1)).Value = SourceDatabase;
                    cmd.Parameters.Add(new SqlParameter("@SourceTable", SqlDbType.NVarChar, -1)).Value = SourceTable;
                    cmd.Parameters.Add(new SqlParameter("@SourceQuery", SqlDbType.NVarChar, -1)).Value = SourceQuery;
                    cmd.Parameters.Add(new SqlParameter("@SourceTableColumnNames", SqlDbType.NVarChar, -1)).Value = SourceTableColumnNames;
                    cmd.Parameters.Add(new SqlParameter("@LandingTargetTableSchema", SqlDbType.NVarChar, -1)).Value = LandingTablestr[0].ToString();
                    cmd.Parameters.Add(new SqlParameter("@LandingTargetTable", SqlDbType.NVarChar, -1)).Value = LandingTablestr[1].ToString();
                    cmd.Parameters.Add(new SqlParameter("@TargetTable", SqlDbType.NVarChar, -1)).Value = TargetTable;
                    cmd.Parameters.Add(new SqlParameter("@HighWaterMarkColumn", SqlDbType.NVarChar, -1)).Value = HighWaterMarkColumn;
                    cmd.Parameters.Add(new SqlParameter("@AutoIdentityColumn", SqlDbType.NVarChar, -1)).Value = AutoIdentityColumn;
                    cmd.Parameters.Add(new SqlParameter("@KeyColumns", SqlDbType.NVarChar, -1)).Value = KeyColumns;
                    cmd.Parameters.Add(new SqlParameter("@DataLoadType", SqlDbType.VarChar, -1)).Value = DataLoadType;
                    //cmd.Parameters.Add(new SqlParameter("@LandingTargetQuery", SqlDbType.NVarChar)).Value = LandingTargetQuery;
                    //cmd.Parameters.Add(new SqlParameter("@TargetQuery", SqlDbType.NVarChar)).Value = TargetQuery;
                    cmd.ExecuteNonQuery();

                    //SqlDataAdapter da = new SqlDataAdapter(cmd);

                    //da.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                //LogException("Failed to ExecuteScalar for " + procedureName, ex, parameters);
                throw;
            }


            //return ds;
        }

        public void deleteFromSourceDataLoadDetails(string SourceServer
          , string SourceDatabase
          , string SourceTable   ,string conn       )
        {
            try
            {
                using (SqlConnection connection = this.GetConnection(conn))
                {
                    //SqlDataAdapter da = new SqlDataAdapter();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.CommandText = "spr_deleteFromSourceDataLoadDetails";
                    cmd.Parameters.Add(new SqlParameter("@SourceServer", SqlDbType.NVarChar)).Value = SourceServer;
                    cmd.Parameters.Add(new SqlParameter("@SourceDatabase", SqlDbType.NVarChar)).Value = SourceDatabase;
                    cmd.Parameters.Add(new SqlParameter("@SourceTable", SqlDbType.NVarChar)).Value = SourceTable;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                //LogException("Failed to ExecuteScalar for " + procedureName, ex, parameters);
                throw;
            }


            //return ds;
        }
    }
}
