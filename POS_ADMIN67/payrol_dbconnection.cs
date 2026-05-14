using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace REGULLANO_OOPL01E_CPE_201
{
    internal class payrol_dbconnection
    {
        public string payrol_connectionString = null;
        public SqlConnection payrol_sql_connection;
        public SqlCommand payrol_sql_command;
        public DataSet payrol_db_connection;
        public SqlDataAdapter payrol_sql_dataadapter;
        public string payrol_sql = null;

        public void payrol_connString()
        {
            payrol_sql_connection = new SqlConnection();
            payrol_connectionString = "Data Source = \"LENOVO\\SQLEXPRESS\"; Initial Catalog = SampleDatabaseDb; Integrated Security = True";
            payrol_sql_connection = new SqlConnection(payrol_connectionString);
            payrol_sql_connection.ConnectionString = payrol_connectionString;
            payrol_sql_connection.Open();
        }

        public void payrol_cmd()
        {
            payrol_sql_command = new SqlCommand(payrol_sql, payrol_sql_connection);
            payrol_sql_command.CommandType = CommandType.Text;
        }

        public void payrol_sqladapterSelect()
        {
            payrol_sql_dataadapter = new SqlDataAdapter(payrol_sql_command);
            payrol_sql_dataadapter.SelectCommand = payrol_sql_command;
            payrol_sql_command.ExecuteNonQuery();
        }

        public void payrol_sqladapterInsert()
        {
            payrol_sql_dataadapter = new SqlDataAdapter(payrol_sql_command);
            payrol_sql_dataadapter.InsertCommand = payrol_sql_command;
            payrol_sql_command.ExecuteNonQuery();
        }

        public void payrol_sqladapterDelete()
        {
            payrol_sql_dataadapter = new SqlDataAdapter(payrol_sql_command);
            payrol_sql_dataadapter.DeleteCommand = payrol_sql_command;
            payrol_sql_command.ExecuteNonQuery();
        }

        public void payrol_sqladapterUpdate()
        {
            payrol_sql_dataadapter = new SqlDataAdapter(payrol_sql_command);
            payrol_sql_dataadapter.UpdateCommand = payrol_sql_command;
            payrol_sql_command.ExecuteNonQuery();
        }

        public void payrol_sqldatasetSELECT()
        {
            payrol_db_connection = new DataSet();
            payrol_sql_dataadapter.Fill(payrol_db_connection, "pos_empRegTbl");
        }
    }
}
