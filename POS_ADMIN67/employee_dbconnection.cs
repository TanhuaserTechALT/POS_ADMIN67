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


    internal class employee_dbconnection
    {
        public string employee_connectionString = null;
        public SqlConnection employee_sql_connection;
        public SqlCommand employee_sql_command;
        public DataSet employee_sql_dataset;
        public SqlDataAdapter employee_sql_dataadapter;
        public string employee_sql = null;


        public void employee_connString()
        {
            employee_sql_connection = new SqlConnection();
                                                       //palitan mo nlng toh ng database mo
            employee_connectionString = "Data Source = \"LENOVO\\SQLEXPRESS\"; Initial Catalog = SampleDatabaseDb; Integrated Security = True";
            employee_sql_connection = new SqlConnection(employee_connectionString);
            employee_sql_connection.ConnectionString = employee_connectionString;
            employee_sql_connection.Open();


        }

        public void employee_cmd()
        {
            employee_sql_command = new SqlCommand(employee_sql, employee_sql_connection);
            employee_sql_command.CommandType = CommandType.Text;
        }

        public void employee_sqladapterSelect()
        {
            employee_sql_dataadapter = new SqlDataAdapter(employee_sql_command);
            employee_sql_dataadapter.SelectCommand = employee_sql_command;
            employee_sql_command.ExecuteNonQuery();
        }

        public void employee_sqladapterInsert()
        {
            employee_sql_dataadapter = new SqlDataAdapter(employee_sql_command);
            employee_sql_dataadapter.InsertCommand = employee_sql_command;
            employee_sql_command.ExecuteNonQuery();
        }

        public void employee_sqladapterDelete()
        {
            employee_sql_dataadapter = new SqlDataAdapter(employee_sql_command);
            employee_sql_dataadapter.DeleteCommand = employee_sql_command;
            employee_sql_command.ExecuteNonQuery();

        }

        public void employee_sqladapterUpdate()
        {
            employee_sql_dataadapter = new SqlDataAdapter(employee_sql_command);
            employee_sql_dataadapter.UpdateCommand = employee_sql_command;
            employee_sql_command.ExecuteNonQuery();
        }
        
        public void employee_sqldatasetSELECT()
        {
            employee_sql_dataset = new DataSet();
            employee_sql_dataadapter.Fill(employee_sql_dataset, "pos_empRegTbl");
        }
    }
}

