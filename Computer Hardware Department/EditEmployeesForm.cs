using System;
using System.Windows.Forms;

namespace Computer_Hardware_Department
{
    public partial class EditEmployeesForm : Form
    {
        public EditEmployeesForm()
        {
            InitializeComponent();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_Hardware_DepartmentDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Employees);

            int IncrementedId = MainForm.LastId;
            IncrementedId++;
            textBox_Id.Text = IncrementedId.ToString();
            textBox_Id.Enabled = false;
        }

        public EditEmployeesForm(int id, string surname, string name, string middleName, string phone, string adress)
        {
            InitializeComponent();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_Hardware_DepartmentDataSet.Suppliers". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Employees);

            textBox_Id.Text = id.ToString();
            textBox_Id.Enabled = false;
            textBox_Surname.Text = surname;
            textBox_Name.Text = name;
            textBox_MiddleName.Text = middleName;
            textBox_Phone.Text = phone;
            textBox_Adress.Text = adress;
        }

        private void EditEmployeesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_Hardware_DepartmentDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Employees);

        }

        private void Button_OK_Click(object sender, EventArgs e)
        {

            try
            {
                if (Edit.isChanging)
                {
                    employeesTableAdapter.UpdateQuery(textBox_Surname.Text,
                                                      textBox_Name.Text,
                                                      textBox_MiddleName.Text,
                                                      textBox_Phone.Text,
                                                      textBox_Adress.Text,
                                                      Convert.ToInt32(textBox_Id.Text));
                }
                else
                {
                    employeesTableAdapter.Insert(Convert.ToInt32(textBox_Id.Text),
                                                 textBox_Surname.Text,
                                                 textBox_Name.Text,
                                                 textBox_MiddleName.Text,
                                                 textBox_Phone.Text,
                                                 textBox_Adress.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
            Close();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
