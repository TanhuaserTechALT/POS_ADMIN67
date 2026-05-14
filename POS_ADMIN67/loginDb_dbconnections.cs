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
        
    internal class loginDb_dbconnections
    {
        public string login_connectionString = null;
        public SqlConnection login_sql_connection;
        public SqlCommand login_sql_command;
        public DataSet login_sql_dataset;
        public SqlDataAdapter login_sql_dataadapter;
        public string login_sql = null;

        // pag nag rered sa sqlconnection or something download ka microsoft.data.sqlclient tsaka  system.data.sqlclient
        // steps sa pag download  = pindutin mo sa taas ung Project tas pindutin mo ung manage NuGet package tas punta ka browse tapos hanapin mo ung pinapa download ko 
        // skill issue nayan pag di nyo pa naiintindihan de jk WAHAHAHHA

        public void login_connString()
        {
            login_sql_connection = new SqlConnection();
                                               //palitan mo nlng toh ng database mo basta pag nakita mo ganto
            login_connectionString = "Data Source = \"LENOVO\\SQLEXPRESS\"; Initial Catalog = SampleDatabaseDb; Integrated Security = True";
            login_sql_connection = new SqlConnection(login_connectionString);
            login_sql_connection.ConnectionString = login_connectionString;
            login_sql_connection.Open();

        }

        public void login_cmd()
        {
            login_sql_command = new SqlCommand(login_sql, login_sql_connection);
            login_sql_command.CommandType = CommandType.Text;
        }

        public void login_sqladapterSelect()
        {
            login_sql_dataadapter = new SqlDataAdapter(login_sql_command);
            login_sql_dataadapter.SelectCommand = login_sql_command;
            login_sql_command.ExecuteNonQuery();
        }

        public void login_sqladapterInsert()
        {
            login_sql_dataadapter = new SqlDataAdapter(login_sql_command);
            login_sql_dataadapter.InsertCommand = login_sql_command;
            login_sql_command.ExecuteNonQuery();
        }

        public void login_sqladapterDelete()
        {
            login_sql_dataadapter = new SqlDataAdapter(login_sql_command);
            login_sql_dataadapter.DeleteCommand = login_sql_command;
            login_sql_command.ExecuteNonQuery();
        }

        public void login_sqladapterUpdate()
        {
            login_sql_dataadapter = new SqlDataAdapter(login_sql_command);
            login_sql_dataadapter.UpdateCommand = login_sql_command;
            login_sql_command.ExecuteNonQuery();
        }

        public void login_sqldatasetSELECT()
        {
            login_sql_dataset = new DataSet();
            login_sql_dataadapter.Fill(login_sql_dataset, "pos_empRegTbl");
        }

    }
}

