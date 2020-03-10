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
    public partial class EditSuppliersForm : Form
    {
        public EditSuppliersForm()
        {
            InitializeComponent();
            this.suppliersTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Suppliers);

            int IncrementedId = MainForm.LastId;
            IncrementedId++;
            textBox_Id.Text = IncrementedId.ToString();
            textBox_Id.Enabled = false;
        }

        public EditSuppliersForm(int id, string name, string produces)
        {
            InitializeComponent();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_Hardware_DepartmentDataSet.Suppliers". При необходимости она может быть перемещена или удалена.
            this.suppliersTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Suppliers);

            textBox_Id.Text = id.ToString();
            textBox_Id.Enabled = false;
            textBoxName.Text = name;
            textBoxType.Text = produces;
        }

        private void EditSuppliersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_Hardware_DepartmentDataSet.Suppliers". При необходимости она может быть перемещена или удалена.
            this.suppliersTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Suppliers);

        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (Edit.isChanging)
                {
                    suppliersTableAdapter.UpdateQuery(textBoxName.Text, textBoxType.Text,
                                                      Convert.ToInt32(textBox_Id.Text));
                }
                else
                {
                    suppliersTableAdapter.Insert(Convert.ToInt32(textBox_Id.Text),
                                                 textBoxName.Text, textBoxType.Text);
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
