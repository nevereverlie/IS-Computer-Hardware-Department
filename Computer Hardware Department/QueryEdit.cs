using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Computer_Hardware_Department
{
    public partial class QueryEdit : Form
    {
        public QueryEdit()
        {
            InitializeComponent();
        }

        const string ConnectionString = MainForm.ConnectionString;

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                SqlDataAdapter openDataAdapter = new SqlDataAdapter(testInput.Text, sqlConnection);
                DataTable dataTable = new DataTable();
                openDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        { 
            testInput.Text = "SELECT";
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            testInput.Text = "SELECT";
        }
    }
}
