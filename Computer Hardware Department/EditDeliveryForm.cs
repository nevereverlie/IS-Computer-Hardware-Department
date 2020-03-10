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
    public partial class EditDeliveryForm : Form
    {
        public EditDeliveryForm()
        {
            InitializeComponent();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_Hardware_DepartmentDataSet.Delivery". При необходимости она может быть перемещена или удалена.
            this.deliveryTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Delivery);

            int IncrementedId = MainForm.LastId;
            IncrementedId++;
            textBox_Id.Text = IncrementedId.ToString();
            textBox_Id.Enabled = false;
        }

        public EditDeliveryForm(int id, string city, int speed, int price)
        {
            InitializeComponent();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_Hardware_DepartmentDataSet.Delivery". При необходимости она может быть перемещена или удалена.
            this.deliveryTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Delivery);

            textBox_Id.Text = id.ToString();
            textBox_Id.Enabled = false;
            textBox_City.Text = city;
            textBox_Speed.Text = speed.ToString();
            textBox_Price.Text = price.ToString();
        }

        private void EditDeliveryForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_Hardware_DepartmentDataSet.Delivery". При необходимости она может быть перемещена или удалена.
            this.deliveryTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Delivery);
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (Edit.isChanging)
                {
                    deliveryTableAdapter.UpdateQuery(textBox_City.Text,
                                                     Convert.ToInt32(textBox_Speed.Text),
                                                     Convert.ToDecimal(textBox_Price.Text),
                                                     Convert.ToInt32(textBox_Id.Text));
                }
                else
                {
                    deliveryTableAdapter.Insert(Convert.ToInt32(textBox_Id.Text),
                                                textBox_City.Text,
                                                Convert.ToInt32(textBox_Speed.Text),
                                                Convert.ToDecimal(textBox_Price.Text));
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
