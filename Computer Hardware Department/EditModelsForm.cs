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

namespace Computer_Hardware_Department
{
    public partial class EditModelsForm : Form
    {
        public EditModelsForm()
        {
            InitializeComponent();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_Hardware_DepartmentDataSet.Types_of_Products". При необходимости она может быть перемещена или удалена.
            this.types_of_ProductsTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Types_of_Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_Hardware_DepartmentDataSet.Suppliers". При необходимости она может быть перемещена или удалена.
            this.suppliersTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Suppliers);

            int IncrementedId = MainForm.LastId;
            IncrementedId++;
            textBox_ModelsId.Text = IncrementedId.ToString();
            textBox_ModelsId.Enabled = false;
        }

        public EditModelsForm(int id, string model, int supplier, int type)
        {
            InitializeComponent();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_Hardware_DepartmentDataSet.Types_of_Products". При необходимости она может быть перемещена или удалена.
            this.types_of_ProductsTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Types_of_Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_Hardware_DepartmentDataSet.Suppliers". При необходимости она может быть перемещена или удалена.
            this.suppliersTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Suppliers);
            textBox_ModelsId.Text = id.ToString();
            textBox_Model.Text = model;
            comboBox_Supplier.SelectedValue = supplier;
            comboBox_Type.SelectedValue = type;

            textBox_ModelsId.Enabled = false;
        }

        private void EditModelsForm_Load(object sender, EventArgs e)
        {


        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (Edit.isChanging)
                {
                    modelsTableAdapter1.UpdateQuery(textBox_Model.Text, 
                                                    Convert.ToInt32(comboBox_Supplier.SelectedValue), 
                                                    Convert.ToInt32(comboBox_Type.SelectedValue),
                                                    Convert.ToInt32(textBox_ModelsId.Text));
                }
                else
                {
                    modelsTableAdapter1.Insert(Convert.ToInt32(textBox_ModelsId.Text),
                                                    textBox_Model.Text,
                                                    Convert.ToInt32(comboBox_Supplier.SelectedValue),
                                                    Convert.ToInt32(comboBox_Type.SelectedValue));
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

        private void ComboBox_Supplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
