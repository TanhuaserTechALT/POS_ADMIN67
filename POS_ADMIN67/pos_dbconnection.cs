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
    internal class pos_dbconnection
    {
        public string pos_connectionString = null;
        public SqlConnection pos_sql_connection;
        public SqlCommand pos_sql_command;
        public DataSet pos_sql_dataset;
        public SqlDataAdapter pos_sql_dataadpter;
        public string pos_sql = null;


        public void pos_connString()
        {
            pos_sql_connection = new SqlConnection();
            pos_connectionString =
              "Data Source=LENOVO\\SQLEXPRESS;Initial Catalog=POSDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            pos_sql_connection = new SqlConnection(pos_connectionString);
            pos_sql_connection.ConnectionString = pos_connectionString;
            pos_sql_connection.Open();

        }
        public void pos_cmd()
        {
            pos_sql_command = new SqlCommand(pos_sql, pos_sql_connection);
            pos_sql_command.CommandType = CommandType.Text;
        }

        public void pos_sqladapterSelect()
        {
            pos_sql_dataadpter = new SqlDataAdapter();
            pos_sql_dataadpter.SelectCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();
        }

        public void pos_sqladapterInsert()
        {
            pos_sql_dataadpter = new SqlDataAdapter();
            pos_sql_dataadpter.InsertCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();
        }
        public void pos_sqladapterUpdate()
        {
            pos_sql_dataadpter = new SqlDataAdapter();
            pos_sql_dataadpter.UpdateCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();
        }
        public void pos_sqladapterDelete()
        {
            pos_sql_dataadpter = new SqlDataAdapter();
            pos_sql_dataadpter.DeleteCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();
        }

        public void pos_sqldatasetSELECT()
        {
            pos_sql_dataset = new DataSet();
            pos_sql_dataadpter.Fill(pos_sql_dataset, "pos_nameTbl");
        }

        public void pos_sqldatasetSELECTSALES()
        {
            pos_sql_dataset = new DataSet();
            pos_sql_dataadpter.Fill(pos_sql_dataset, "salesTbl");
        }

        public void pos_select()
        {
            pos_sql = "SELECT * FROM pos_nameTbl INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id INNER JOIN pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id";

        }

        public void pos_select_cashier()
        {
            pos_sql = "SELECT * FROM pos_nameTbl INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id INNER JOIN pos_priceTble ON pos_picTbl.pos_id = pos_priceTbl.pos_id WHERE pos_nameTbl.pos_id= 1";
        
        }
        public void pos_select_cashier1()
        {
            pos_sql = "SELECT * FROM pos_nameTbl INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id INNER JOIN pos_priceTble ON pos_picTbl.pos_id = pos_priceTbl.pos_id WHERE pos_nameTbl.pos_id= 2";
        }

        public void pos_select_cashier_display()
        {
            pos_sql = "SELECT pos_empRegTbl.emp_id, emp_name, emp_surname, pos_terminal_no, account_type, FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id WHERE account_type = 'Administrator'";
        }

        public void pos_select_cashier_SELECTdisplay()
        {
            pos_sql_dataset = new DataSet();
            pos_sql_dataadpter.Fill(pos_sql_dataset, "pos_empRegTbl");
        }

       
        }
    }
