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
    internal class useraccount_db_connection
    {
        public string useraccount_connectionString = null;
        public SqlConnection useraccount_sql_connection;
        public SqlCommand useraccount_sql_command;
        public DataSet useraccount_sql_dataset;
        public SqlDataAdapter useraccount_sql_dataadapter;
        public string useraccount_sql = null;

        public void useraccount_connString()
        {
            useraccount_sql_connection = new SqlConnection();
            useraccount_connectionString = "Data Source=LENOVO\\SQLEXPRESS; Initial Catalog=UserAccountDB; Integrated Security=True;";
            useraccount_sql_connection = new SqlConnection(useraccount_connectionString);
            useraccount_sql_connection.ConnectionString = useraccount_connectionString;
            useraccount_sql_connection.Open();
        }

        public void useraccount_cmd()
        {
            useraccount_sql_command = new SqlCommand(useraccount_sql, useraccount_sql_connection);
            useraccount_sql_command.CommandType = CommandType.Text;
        }

        public void useraccount_sqladapterSelect()
        {
            useraccount_sql_dataadapter = new SqlDataAdapter(useraccount_sql_command);
            useraccount_sql_dataadapter.SelectCommand = useraccount_sql_command;
            useraccount_sql_command.ExecuteNonQuery();
        }

        public void useraccount_sqladapterInsert()
        {
            useraccount_sql_dataadapter = new SqlDataAdapter(useraccount_sql_command);
            useraccount_sql_dataadapter.InsertCommand = useraccount_sql_command;
            useraccount_sql_command.ExecuteNonQuery();
        }

        public void useraccount_sqladapterDelete()
        {
            useraccount_sql_dataadapter = new SqlDataAdapter(useraccount_sql_command);
            useraccount_sql_dataadapter.DeleteCommand = useraccount_sql_command;
            useraccount_sql_command.ExecuteNonQuery();
        }

        public void useraccount_sqladapterUpdate()
        {
            useraccount_sql_dataadapter = new SqlDataAdapter(useraccount_sql_command);
            useraccount_sql_dataadapter.UpdateCommand = useraccount_sql_command;
            useraccount_sql_command.ExecuteNonQuery();
        }

        public void useraccount_sqldatasetSELECT()
        {
            useraccount_sql_dataset = new DataSet();
            useraccount_sql_dataadapter.Fill(useraccount_sql_dataset, "pos_empRegTbl");
        }

        public void useraccount_sqldatasetSELECT_Account()
        {
            useraccount_sql_dataset = new DataSet();
            useraccount_sql_dataadapter.Fill(useraccount_sql_dataset, "useraccountTbl");
        }


    }
}
