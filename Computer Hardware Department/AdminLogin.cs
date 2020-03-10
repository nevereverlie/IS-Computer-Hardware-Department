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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void ButtonSignIn_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "admin" && textBoxPassword.Text == "icodeforfun")
            {
                this.Hide();
                Automation automation = new Automation();
                automation.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect login or password, try again", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
