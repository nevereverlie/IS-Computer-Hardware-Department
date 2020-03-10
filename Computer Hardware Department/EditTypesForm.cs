using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Hardware_Department
{
    public partial class EditTypesForm : Form
    {
        public EditTypesForm()
        {
            InitializeComponent();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_Hardware_DepartmentDataSet.Types_of_Products". При необходимости она может быть перемещена или удалена.
            this.types_of_ProductsTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Types_of_Products);

            int IncrementedId = MainForm.LastId;
            IncrementedId++;
            textBox_Id.Text = IncrementedId.ToString();
            textBox_Id.Enabled = false;
        }

        public EditTypesForm(int id, string name)
        {
            InitializeComponent();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_Hardware_DepartmentDataSet.Types_of_Products". При необходимости она может быть перемещена или удалена.
            this.types_of_ProductsTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Types_of_Products);

            textBox_Id.Text = id.ToString();
            textBox_Id.Enabled = false;
            textBoxName.Text = name;
        }

        private void EditTypesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_Hardware_DepartmentDataSet.Types_of_Products". При необходимости она может быть перемещена или удалена.
            this.types_of_ProductsTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Types_of_Products);

        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (Edit.isChanging)
                {
                    types_of_ProductsTableAdapter.UpdateQuery(textBoxName.Text, 
                                                              Convert.ToInt32(textBox_Id.Text));
                }
                else
                {
                    types_of_ProductsTableAdapter.InsertQuery(Convert.ToInt32(textBox_Id.Text),
                                                              textBoxName.Text.ToString());
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
