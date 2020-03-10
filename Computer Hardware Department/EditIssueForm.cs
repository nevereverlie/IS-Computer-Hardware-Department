using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Computer_Hardware_Department
{
    public partial class EditIssueForm : Form
    {

        public EditIssueForm()
        {
            InitializeComponent();
            issueTableAdapter1.Fill(computer_Hardware_DepartmentDataSet.Issue);
            types_of_ProductsTableAdapter.Fill(computer_Hardware_DepartmentDataSet.Types_of_Products);
            modelsTableAdapter1.Fill(computer_Hardware_DepartmentDataSet.Models);
            deliveryTableAdapter1.Fill(computer_Hardware_DepartmentDataSet.Delivery);
            employeesTableAdapter1.Fill(computer_Hardware_DepartmentDataSet.Employees);

            int IncrementedId = MainForm.LastId;
            IncrementedId++;
            textBox_IssueId.Text = IncrementedId.ToString();
            textBox_IssueId.Enabled = false;
        }

        public EditIssueForm(int issueId, string surname, string name, string middleName, int type_Of_Good_Id, int model_Id, string phone,
            DateTime issue_Date, int city, int employee) : this()
        {
            issueTableAdapter1.Fill(computer_Hardware_DepartmentDataSet.Issue);
            types_of_ProductsTableAdapter.Fill(computer_Hardware_DepartmentDataSet.Types_of_Products);
            modelsTableAdapter1.Fill(computer_Hardware_DepartmentDataSet.Models);
            deliveryTableAdapter1.Fill(computer_Hardware_DepartmentDataSet.Delivery);
            employeesTableAdapter1.Fill(computer_Hardware_DepartmentDataSet.Employees);

            textBox_IssueId.Text = issueId.ToString();
            textBox_IssueId.Enabled = false;
            textBox_Surname.Text = surname;
            textBox_Name.Text = name;
            textBox_MiddleName.Text = middleName;
            comboBox_GoodId.SelectedValue = type_Of_Good_Id;
            comboBox_ModelsId.SelectedValue = model_Id;
            textBox_Phone.Text = phone;
            dateTimePicker_IssueDate.Value = issue_Date;
            comboBox_City.SelectedValue = city;
            comboBox_Employee.SelectedValue = employee;
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (Edit.isChanging)
                {
                    issueTableAdapter1.UpdateQuery1(textBox_Surname.Text,
                                                    textBox_Name.Text,
                                                    textBox_MiddleName.Text,
                                                    Convert.ToInt32(comboBox_GoodId.SelectedValue),
                                                    Convert.ToInt32(comboBox_ModelsId.SelectedValue),
                                                    textBox_Phone.Text,
                                                    dateTimePicker_IssueDate.Value.ToString(),
                                                    Convert.ToInt32(comboBox_City.SelectedValue),
                                                    Convert.ToInt32(comboBox_Employee.SelectedValue),
                                                    Convert.ToInt32(textBox_IssueId.Text));
                }
                else
                {
                    issueTableAdapter1.Insert(Convert.ToInt32(textBox_IssueId.Text),
                                              textBox_Surname.Text,
                                              textBox_Name.Text,
                                              textBox_MiddleName.Text,
                                              Convert.ToInt32(comboBox_GoodId.SelectedValue),
                                              Convert.ToInt32(comboBox_ModelsId.SelectedValue),
                                              textBox_Phone.Text,
                                              dateTimePicker_IssueDate.Value,
                                              Convert.ToInt32(comboBox_City.SelectedValue),
                                              Convert.ToInt32(comboBox_Employee.SelectedValue));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ComboBox_ModelsId_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*SqlConnection sqlConn = new SqlConnection(MainForm.ConnectionString);
            sqlConn.Open();
            SqlDataAdapter oda = new SqlDataAdapter("SELECT [Types of Products].[Name of the Product] " +
                                                    "FROM [Types of Products] " +
                                                    "WHERE [Types of Products].Id = " + comboBox_ModelsId.SelectedValue, sqlConn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            comboBox_ModelsId.DataSource = dt;
            comboBox_ModelsId.ValueMember = "Model";*/
        }

        private void ComboBox_GoodId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox_Name.Text != "")
            {
                SqlConnection sqlConn = new SqlConnection(MainForm.ConnectionString);
                sqlConn.Open();
                SqlDataAdapter oda = new SqlDataAdapter("SELECT Id, Model " +
                                                        "FROM Models " +
                                                        "WHERE Models.[Product's Id] = " + comboBox_GoodId.SelectedValue, sqlConn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                comboBox_ModelsId.DataSource = dt;
                comboBox_ModelsId.DisplayMember = "Model";
                comboBox_ModelsId.ValueMember = "Id";
                sqlConn.Close();
            }
        }
    }
}
