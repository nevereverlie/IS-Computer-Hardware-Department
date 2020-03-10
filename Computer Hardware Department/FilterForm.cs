using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Computer_Hardware_Department
{
    public partial class FilterForm : Form
    {
        public FilterForm()
        {
            InitializeComponent();
            // TODO: This line of code loads data into the 'computer_Hardware_DepartmentDataSet.Issue' table. You can move, or remove it, as needed.
            this.issueTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Issue);
            // TODO: This line of code loads data into the 'computer_Hardware_DepartmentDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Employees);
            // TODO: This line of code loads data into the 'computer_Hardware_DepartmentDataSet.Delivery' table. You can move, or remove it, as needed.
            this.deliveryTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Delivery);
            // TODO: This line of code loads data into the 'computer_Hardware_DepartmentDataSet.Supply' table. You can move, or remove it, as needed.
            this.supplyTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Supply);
            // TODO: This line of code loads data into the 'computer_Hardware_DepartmentDataSet.Types_of_Products' table. You can move, or remove it, as needed.
            this.types_of_ProductsTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Types_of_Products);
            // TODO: This line of code loads data into the 'computer_Hardware_DepartmentDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Suppliers);
            // TODO: This line of code loads data into the 'computer_Hardware_DepartmentDataSet.Models' table. You can move, or remove it, as needed.
            this.modelsTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Models);
            labelSource.Text = "Таблиця: ";

            CurrentBindingSource = modelsBindingSource;

            TablesList.AddRange(new string[] { "Моделі", "Видача", "Поставки", "Компанії", "Види товарів", "Доставка", "Співробітники" });

            comboBoxSource.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (string s in TablesList)
            {
                comboBoxSource.Items.Add(s);
            }
        }

        public List<string> TablesList = new List<string>();

        public BindingSource CurrentBindingSource { get; set; }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentBindingSource == modelsBindingSource)
                {
                    if (textBoxFilter.Text != "")
                    {
                        SqlConnection sqlConn = new SqlConnection(MainForm.ConnectionString);
                        sqlConn.Open();
                        SqlDataAdapter oda = new SqlDataAdapter("SELECT * FROM Models WHERE Id = " + textBoxFilter.Text, sqlConn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        dataGridView1.DataSource = dt;
                        sqlConn.Close();
                    }
                }
                else if (CurrentBindingSource == issueBindingSource)
                {
                    if (textBoxFilter.Text != "")
                    {
                        SqlConnection sqlConn = new SqlConnection(MainForm.ConnectionString);
                        sqlConn.Open();
                        SqlDataAdapter oda = new SqlDataAdapter("SELECT * FROM Issue WHERE Id = " + textBoxFilter.Text, sqlConn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                else if (CurrentBindingSource == supplyBindingSource)
                {
                    if (textBoxFilter.Text != "")
                    {
                        SqlConnection sqlConn = new SqlConnection(MainForm.ConnectionString);
                        sqlConn.Open();
                        SqlDataAdapter oda = new SqlDataAdapter("SELECT * FROM Supply WHERE [Supply Code] = " + textBoxFilter.Text, sqlConn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                else if (CurrentBindingSource == suppliersBindingSource)
                {
                    SqlConnection sqlConn = new SqlConnection(MainForm.ConnectionString);
                    sqlConn.Open();
                    SqlDataAdapter oda = new SqlDataAdapter("SELECT * FROM Suppliers WHERE Id = " + comboBoxFilter.SelectedValue, sqlConn);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if (CurrentBindingSource == typesOfProductsBindingSource)
                {
                    SqlConnection sqlConn = new SqlConnection(MainForm.ConnectionString);
                    sqlConn.Open();
                    SqlDataAdapter oda = new SqlDataAdapter("SELECT * FROM [Types of Products] WHERE Id = " + comboBoxFilter.SelectedValue, sqlConn);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if (CurrentBindingSource == deliveryBindingSource)
                {
                    SqlConnection sqlConn = new SqlConnection(MainForm.ConnectionString);
                    sqlConn.Open();
                    SqlDataAdapter oda = new SqlDataAdapter("SELECT * FROM Delivery WHERE Id = " + comboBoxFilter.SelectedValue, sqlConn);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if (CurrentBindingSource == employeesBindingSource)
                {
                    if (textBoxFilter.Text != "")
                    {
                        SqlConnection sqlConn = new SqlConnection(MainForm.ConnectionString);
                        sqlConn.Open();
                        SqlDataAdapter oda = new SqlDataAdapter("SELECT * FROM Employees WHERE Id = " + textBoxFilter.Text, sqlConn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'computer_Hardware_DepartmentDataSet.Issue' table. You can move, or remove it, as needed.
            this.issueTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Issue);
            // TODO: This line of code loads data into the 'computer_Hardware_DepartmentDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Employees);
            // TODO: This line of code loads data into the 'computer_Hardware_DepartmentDataSet.Delivery' table. You can move, or remove it, as needed.
            this.deliveryTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Delivery);
            // TODO: This line of code loads data into the 'computer_Hardware_DepartmentDataSet.Supply' table. You can move, or remove it, as needed.
            this.supplyTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Supply);
            // TODO: This line of code loads data into the 'computer_Hardware_DepartmentDataSet.Types_of_Products' table. You can move, or remove it, as needed.
            this.types_of_ProductsTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Types_of_Products);
            // TODO: This line of code loads data into the 'computer_Hardware_DepartmentDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Suppliers);
            // TODO: This line of code loads data into the 'computer_Hardware_DepartmentDataSet.Models' table. You can move, or remove it, as needed.
            this.modelsTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Models);

            dataGridView1.DataSource = modelsBindingSource;
            labelFilter.Text = "ID моделі: ";
            comboBoxFilter.Visible = false;

        }

        private void ComboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxFilter.Text = "";
            switch (comboBoxSource.SelectedItem.ToString())
            {
                case "Моделі":
                    dataGridView1.DataSource = modelsBindingSource;
                    CurrentBindingSource = modelsBindingSource;
                    labelFilter.Text = "ID моделі: ";
                    comboBoxFilter.Visible = false;
                    textBoxFilter.Visible = true;
                    break;
                case "Видача":
                    dataGridView1.DataSource = issueBindingSource;
                    CurrentBindingSource = issueBindingSource;
                    labelFilter.Text = "Накладна №: ";
                    comboBoxFilter.Visible = false;
                    textBoxFilter.Visible = true;
                    break;
                case "Поставки":
                    dataGridView1.DataSource = supplyBindingSource;
                    CurrentBindingSource = supplyBindingSource;
                    labelFilter.Text = "Поставка №: ";
                    comboBoxFilter.Visible = false;
                    textBoxFilter.Visible = true;
                    break;
                case "Компанії":
                    dataGridView1.DataSource = suppliersBindingSource;
                    CurrentBindingSource = suppliersBindingSource;
                    labelFilter.Text = "Вид продукії: ";
                    comboBoxFilter.Visible = true;
                    textBoxFilter.Visible = false;
                    comboBoxFilter.DataSource = suppliersBindingSource;
                    comboBoxFilter.DisplayMember = "Name";
                    comboBoxFilter.ValueMember = "Id";
                    break;
                case "Види товарів":
                    dataGridView1.DataSource = typesOfProductsBindingSource;
                    CurrentBindingSource = typesOfProductsBindingSource;
                    labelFilter.Text = "Назва продукту: ";
                    comboBoxFilter.Visible = true;
                    textBoxFilter.Visible = false;
                    comboBoxFilter.DataSource = typesOfProductsBindingSource;
                    comboBoxFilter.DisplayMember = "Name of the Product";
                    comboBoxFilter.ValueMember = "Id";
                    break;
                case "Доставка":
                    dataGridView1.DataSource = deliveryBindingSource;
                    CurrentBindingSource = deliveryBindingSource;
                    labelFilter.Text = "До міста: ";
                    comboBoxFilter.Visible = true;
                    textBoxFilter.Visible = false;
                    comboBoxFilter.DataSource = deliveryBindingSource;
                    comboBoxFilter.DisplayMember = "City";
                    comboBoxFilter.ValueMember = "Id";
                    break;
                case "Співробітники":
                    dataGridView1.DataSource = employeesBindingSource;
                    CurrentBindingSource = employeesBindingSource;
                    labelFilter.Text = "№ співробітника: ";
                    comboBoxFilter.Visible = false;
                    textBoxFilter.Visible = true;
                    break;
            }
        }
    }
}
