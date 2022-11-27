using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Reflection;
using System.Collections;

using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQL_Perf_Light
{
    public class SQLHelper
    {
        public SQLHelper()
        {
           
        }
      

        static string target_sql_server = SQL_Perf_Light.Properties.Settings.Default.target_sql_server;
        static string target_sql_db = SQL_Perf_Light.Properties.Settings.Default.target_sql_db;
        static string target_sql_username = SQL_Perf_Light.Properties.Settings.Default.target_username;
        static string target_sql_password = SQL_Perf_Light.Properties.Settings.Default.target_password;

        static string connectionString = "Data Source=.;Connection Timeout=6000;Initial Catalog=sqlperftool;Integrated Security=true";

        static string target_connectionString = "";


        public static string fetch_user_databases = "SELECT name AS 'User Created Databases' FROM SYS.DATABASES WHERE name NOT IN   ('master', 'model', 'msdb', 'tempdb', 'Resource',  " +
            " 'distribution' , 'reportserver', 'reportservertempdb') ";

        public static string fetch_user_all_tables_bydatabase = "SELECT '['+TABLE_SCHEMA + '].[' + TABLE_NAME +']' TableName FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' order by 1 asc;";
        public static string fetch_tablename_if_exists = "select 1 TblCnt from INFORMATION_SCHEMA.TABLES where '['+TABLE_SCHEMA + '].[' + TABLE_NAME +']'='{0}'";
                
        public static DataSet getDataSet(string sqlqueryText,string target_sql_db,bool isTargetDBConnection)
        {
            
            //if (sql_username != "")
            //{
            //    connectionString = connectionString+ " ;Integrated Security=false; user id=" + sql_username;
            //}
            //else{
            //    connectionString = connectionString + ";Integrated Security=true";
            //}
            //if (sql_password != "")
            //{
            //    connectionString = connectionString + " ; password=" + sql_password;
           // }

            target_connectionString = "Data Source=" + target_sql_server + ";Connection Timeout=6000;Initial Catalog=" + target_sql_db;
            if (target_sql_username != "")
            {
                target_connectionString = target_connectionString + " ; Integrated Security=false;user id=" + target_sql_username;
            }
            else
            {
                target_connectionString = target_connectionString + ";Integrated Security=true";
            }
            if (target_sql_password != "")
            {
                target_connectionString = target_connectionString + " ; password=" + target_sql_password;
            }

            string lcfnlSQLConnection = "";
            if (isTargetDBConnection)
            {
                lcfnlSQLConnection = target_connectionString;
            }
            else
            {
                lcfnlSQLConnection = connectionString;
            }
            
            BaseDataAccess bd = new BaseDataAccess(lcfnlSQLConnection);
            
            try
            {
                DataSet ds = bd.GetDataSet(lcfnlSQLConnection, sqlqueryText);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        
    }
}
