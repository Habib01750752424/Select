using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Select.Model;

namespace Select
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server = HABIB; Database = Practice; Integrated Security = true";
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //For DataTable "--Select--" Selection
            //DataTable dataTable = new DataTable();
            //dataTable = LoadItem();
            //DataRow row = dataTable.NewRow();
            ////row[0] = -1;
            //row[1] = "--Select--";
            //dataTable.Rows.InsertAt(row,0);
            //itemComboBox.DataSource = dataTable;


            //For sqlDataReader "--Select--" Selection
            Item item = new Item();
           // item.Id = -1;
            item.Name = "--Select--";
            List<Item> items = LoadItem();
            items.Insert(0,item);

            itemComboBox.DataSource = items;

        }

        //For DataTable "--Select--" Selection
        //public DataTable LoadItem()
        //{
        //    SqlConnection sqlConnection = new SqlConnection(connectionString);
        //    string query = "SELECT Id,Name FROM Item";
        //    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
        //    DataTable dataTable = new DataTable();
        //    int isFill = sqlDataAdapter.Fill(dataTable);
        //    return dataTable;
        //}

        //For sqlDataReader "--Select--" Selection
        public List<Item> LoadItem()
        {
            List<Item> items = new List<Item>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT Id,Name FROM Item";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Item item = new Item();
                item.Id = Convert.ToInt32(sqlDataReader["Id"]);
                item.Name = sqlDataReader["Name"].ToString();

                items.Add(item);
            }
            sqlConnection.Close();

            return items;
        }
    }
}
