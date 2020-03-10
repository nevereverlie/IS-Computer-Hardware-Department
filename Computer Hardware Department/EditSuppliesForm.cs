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
    public partial class EditSuppliesForm : Form
    {
        public EditSuppliesForm()
        {
            InitializeComponent();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_Hardware_DepartmentDataSet.Delivery". При необходимости она может быть перемещена или удалена.
            this.deliveryTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Delivery);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_Hardware_DepartmentDataSet.Models". При необходимости она может быть перемещена или удалена.
            this.modelsTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Models);

            int IncrementedId = MainForm.LastId;
            IncrementedId++;
            textBox_SupplyId.Text = IncrementedId.ToString();
            textBox_SupplyId.Enabled = false;
        }

        public EditSuppliesForm(int supplyId, int modelId, decimal price, int amount, int toCityId)
        {
            InitializeComponent();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_Hardware_DepartmentDataSet.Delivery". При необходимости она может быть перемещена или удалена.
            this.deliveryTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Delivery);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_Hardware_DepartmentDataSet.Models". При необходимости она может быть перемещена или удалена.
            this.modelsTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Models);

            textBox_SupplyId.Text = supplyId.ToString();
            comboBox_Model.SelectedValue = modelId;
            textBox_Price.Text = price.ToString();
            textBox_Amount.Text = amount.ToString();
            comboBox_ToCity.SelectedValue = toCityId;

            textBox_SupplyId.Enabled = false;
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (Edit.isChanging)
                {
                    supplyTableAdapter1.UpdateQuery(Convert.ToInt32(comboBox_Model.SelectedValue),
                                                    Convert.ToDecimal(textBox_Price.Text),
                                                    Convert.ToInt32(textBox_Amount.Text),
                                                    Convert.ToInt32(comboBox_ToCity.SelectedValue),
                                                    Convert.ToInt32(textBox_SupplyId.Text));
                }
                else
                {
                    supplyTableAdapter1.Insert(Convert.ToInt32(textBox_SupplyId.Text),
                                               Convert.ToInt32(comboBox_Model.SelectedValue),
                                               Convert.ToDecimal(textBox_Price.Text),
                                               Convert.ToInt32(textBox_Amount.Text),
                                               Convert.ToInt32(comboBox_ToCity.SelectedValue));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
            Close();

        }

        private void EditSuppliesForm_Load(object sender, EventArgs e)
        {


        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
