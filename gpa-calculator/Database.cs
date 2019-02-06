using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace gpa_calculator
{
    class Database
    {
        private readonly string connectionString = "server=localhost;database=gpa_calculator;uid=root;";
        private MySqlConnection connection;
        public Database() {
            Connect();
        }

        private void Connect() => connection = new MySqlConnection(connectionString);

        public DataTable GetData(string query)
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter;
            try
            {
                if (connection.State.ToString() != "Open")
                    connection.Open();
                adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(ds, "data");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ds.Tables["data"];
        }

        public void Insert(string query)
        {
            MySqlCommand commandDatabase = new MySqlCommand(query, connection)
            {
                CommandTimeout = 60
            };
            try
            {
                if (connection.State.ToString() != "Open")
                    connection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                MessageBox.Show("Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}