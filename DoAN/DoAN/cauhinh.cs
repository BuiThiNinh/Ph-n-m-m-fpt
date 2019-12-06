using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAN
{
    public class cauhinh
    {
         public int check_config()
        {
            if (Properties.Settings.Default.FPT_SHOPConnectionString == string.Empty)
            {
                return 1;
            }
            else
            {
                SqlConnection sql = new SqlConnection(Properties.Settings.Default.FPT_SHOPConnectionString);
                try
                {
                    if (sql.State == System.Data.ConnectionState.Closed)
                    {
                        sql.Open();
                    }
                    return 0;
                }
                catch
                {
                    return 2;
                }
            }
        }

        public LoginResult Check_User(String pUser, String pPass)
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from QL_NGUOIDUNG where TENDN='" + pUser + "' and MATKHAU='" + pPass + "'", Properties.Settings.Default.FPT_SHOPConnectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
                return LoginResult.Invalid;
            else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() == "false")
                return LoginResult.Disable;
            return LoginResult.Success;

        }

        public DataTable GetServerName()
        {
            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt;
        }

        public DataTable GetDBName(String pServer)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases", "Data Source=" + pServer + "; Initial Catalog=master; Integrated Security=True");
            da.Fill(dt);
            return dt;

        }

        public void SaveConfig(String pServer, String pUser, String pPass, String pDBname)
        {
            Properties.Settings.Default.DoAN = @"Data Source=" + pServer + "; Initial Catalog=" + pDBname + "; Initial Catalog=master; User ID=" + pUser + ";Password=" + pPass + "";
            Properties.Settings.Default.Save();
        }
        public List<string> GetDatabaseName(string pServerName, string pUser, string pPass)
        {
            List<string> _list = new List<string>();
            DataTable dt = new DataTable();
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("SELECT name FROM sys.databases", "Data Source = " + pServerName + " ; Initial Catalog = " + "master" + "; User ID = " + pUser + "; Password = " + pPass + "");
                da.Fill(dt);
                foreach (System.Data.DataRow row in dt.Rows)
                {
                    foreach (System.Data.DataColumn col in dt.Columns)
                    {
                        _list.Add(row[col].ToString());
                    }
                }
            }
            catch
            {
                return null;
            }
            return _list;
        }
    }
    
    }
    
