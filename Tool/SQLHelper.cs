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
using SQL_Perf_Light;

namespace BIFramework
{
    public class SQLHelper
    {
        public SQLHelper()
        {
           
        }


        public static string source_sql_server = Properties.Settings.Default.source_sql_server;
        public static string source_sql_db = Properties.Settings.Default.source_sql_db;
        public static string source_sql_username = Properties.Settings.Default.source_username;
        public static string source_sql_password = Properties.Settings.Default.source_password;

        public static string target_sql_server = Properties.Settings.Default.target_sql_server;
        public static string target_sql_db = Properties.Settings.Default.target_sql_db;
        public static string target_sql_username = Properties.Settings.Default.target_username;
        public static string target_sql_password = Properties.Settings.Default.target_password;

        public static string target_sql_db_etlframework = Properties.Settings.Default.target_sql_db_etlframework;

        public static string source_connectionString = "";
        public static string target_connectionString = "";
        public static string target_connectionString_etlframework = "";


        //public static string fetch_user_databases = "SELECT name AS 'User Created Databases' FROM SYS.DATABASES WHERE name NOT IN   ('master', 'model', 'msdb', 'tempdb', 'Resource',  " +
        //    " 'distribution' , 'reportserver', 'reportservertempdb') ";

        public static string fetch_user_all_tables_bydatabase = "SELECT '['+TABLE_SCHEMA + '].[' + TABLE_NAME +']' TableName FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' order by 1 asc;";
        public static string fetch_tablename_if_exists = "select 1 TblCnt from INFORMATION_SCHEMA.TABLES where '['+TABLE_SCHEMA + '].[' + TABLE_NAME +']'='{0}'";

        public static string fetch_DataLoadDetails= "SELECT [ID]      ,[SourceServer]   ,  SourceDatabase ,[SourceTable]      ,[SourceQuery]" +
            "  ,SourceTableColumnNames    ,[LandingTargetTable]      ,[TargetTable]      ,[DataLoadType]      ,[HighWaterMarkColumn]" +
            "      ,[AutoIdentityColumn]      ,[KeyColumns]  FROM [ETL].[SourceTablesDataLoadDetails] ";

        public static string fecth_SourceTableColumns = "spr_fetch_TableQuery";

        public static void InitializeIcons()
        {
            source_connectionString = "Data Source=" + source_sql_server + ";Connection Timeout=6000;Initial Catalog=" + source_sql_db;
            if (source_sql_username != "")
            {
                source_connectionString = source_connectionString + " ; Integrated Security=false;user id=" + source_sql_username;
            }
            else
            {
                source_connectionString = source_connectionString + ";Integrated Security=true";
            }
            if (source_sql_password != "")
            {
                source_connectionString = source_connectionString + " ; password=" + source_sql_password;
            }

            target_connectionString = "Data Source=" + target_sql_server + ";Connection Timeout=6000;Initial Catalog=" + target_sql_db;
            target_connectionString_etlframework = "Data Source=" + target_sql_server + ";Connection Timeout=6000;Initial Catalog=" + target_sql_db_etlframework;
            if (target_sql_username != "")
            {
                target_connectionString = target_connectionString + " ; Integrated Security=false;user id=" + target_sql_username;
                target_connectionString_etlframework = target_connectionString_etlframework + " ; Integrated Security=false;user id=" + target_sql_username;
            }
            else
            {
                target_connectionString = target_connectionString + ";Integrated Security=true";
                target_connectionString_etlframework = target_connectionString_etlframework + ";Integrated Security=true";
            }
            if (target_sql_password != "")
            {
                target_connectionString = target_connectionString + " ; password=" + target_sql_password;
                target_connectionString_etlframework = target_connectionString_etlframework + " ; password=" + target_sql_password;
            }

        }
        public static DataSet getDataSet(string sqlqueryText,bool isTargetDBConnection, bool isETLFramework=false)
        {
            string lcfnlSQLConnection;
            if (isTargetDBConnection)
            {
                lcfnlSQLConnection = target_connectionString;
            }
            else
            {
                lcfnlSQLConnection = source_connectionString;
            }
            if (isETLFramework)
            {
                lcfnlSQLConnection = target_connectionString_etlframework;
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

        public static DataSet fetchTableColumns(string TableName, bool isTargetDBConnection)
        {

            string lcfnlSQLConnection ;
            if (isTargetDBConnection)
            {
                lcfnlSQLConnection = target_connectionString;
            }
            else
            {
                lcfnlSQLConnection = source_connectionString;
            }

            BaseDataAccess bd = new BaseDataAccess(lcfnlSQLConnection);

            try
            {
                TableName = TableName.Replace("[","");
                TableName = TableName.Replace("]", "");
                string sqlqueryText = "SELECT CASE WHEN DATA_TYPE='timestamp' THEN 'CAST(['+COLUMN_NAME+'] AS varbinary(8)) as ['+COLUMN_NAME+']' WHEN DATA_TYPE='xml' THEN 'CAST(['+COLUMN_NAME+'] AS xml) as ['+COLUMN_NAME+']'  ELSE 	'['+COLUMN_NAME+']' END ColumnName " +
               " FROM INFORMATION_SCHEMA.COLUMNS " +
               " WHERE [TABLE_SCHEMA]+'.'+[TABLE_NAME]='"+TableName+"' ORDER BY ORDINAL_POSITION";

                //if (DatabaseName =="")
                //{
                //    sqlqueryText = "SELECT COLUMN_NAME ColumnName " +
                //    " FROM INFORMATION_SCHEMA.COLUMNS " +
                //        " WHERE TABLE_SCHEMA+'.'+TABLE_NAME='" + TableName + "' ORDER BY ORDINAL_POSITION";
                //}
                if (TableName =="")
                {
                    return null;
                }

                DataSet ds = bd.GetDataSet(lcfnlSQLConnection, sqlqueryText);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static void InsertUpdateDataLoadTable(string SourceTable, string SourceQuery, string LandingTargetTable, string TargetTable,
            string HighWaterMarkColumn, string AutoIdentityColumn, string KeyColumns, string SourceTableColumnNames, bool isTargetDBConnection)
        {


            BaseDataAccess bd = new BaseDataAccess(target_sql_db_etlframework);
            bd.InsertUpdateSourceDataLoadDetails(source_sql_server, source_sql_db, SourceTable, SourceQuery, LandingTargetTable, TargetTable, "", HighWaterMarkColumn, AutoIdentityColumn, KeyColumns, SourceTableColumnNames);

        }
        public static void deleteFromDataLoadTable(string SourceTable)
        {

            BaseDataAccess bd = new BaseDataAccess(target_sql_db_etlframework);
            bd.deleteFromSourceDataLoadDetails(source_sql_server, source_sql_db, SourceTable);

        }
        public static DataSet fetchTableColumnsProperties(string TableName)
        {

            BaseDataAccess bd = new BaseDataAccess(source_connectionString);

            try
            {
                TableName = TableName.Replace("[", "");
                TableName = TableName.Replace("]", "");
                string sqlqueryText = " ";
                
                if (TableName != "")
                {
                    sqlqueryText = " SELECT * FROM( " +
                    " SELECT  " +
                    " ku.TABLE_SCHEMA     ,KU.table_name as TABLE_NAME    ,column_name as ColumnName 	,TC.CONSTRAINT_TYPE " +
                    " FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS AS TC  " +
                    " INNER JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE AS KU " +
                    " ON TC.CONSTRAINT_TYPE in( 'PRIMARY KEY' ,'UNIQUE')    AND TC.CONSTRAINT_NAME = KU.CONSTRAINT_NAME  " +
                    " union  " +
                    " SELECT     [Table_Schema] = s.name collate database_default,    [Table_Name] = t.name collate database_default,	ic.name collate database_default [ColumnName],	'Identity' [ConstraintType] " +
                    " FROM     sys.schemas AS s     INNER JOIN sys.tables AS t ON s.schema_id = t.schema_id " +
                    " INNER JOIN sys.columns AS c ON t.object_id = c.object_id " +
                    " INNER JOIN sys.identity_columns AS ic on c.object_id = ic.object_id AND c.column_id = ic.column_id " +
                    " " +
                    " union " +
                    " select TABLE_SCHEMA, TABLE_NAME,COLUMN_NAME,'timestamp' " +
                    " FROM INFORMATION_SCHEMA.COLUMNS " +
                    " where DATA_TYPE='timestamp' " +
                    " ) A " +
                    " where TABLE_SCHEMA+'.'+TABLE_NAME='" + TableName + "' ";
                }
               
                DataSet ds = bd.GetDataSet(source_connectionString, sqlqueryText);
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
