using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__project.HR
{
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var username = textBox1.Text?.Trim();
            var password = textBox2.Text ?? string.Empty;

            // simple hard-coded credential check as requested
            if (string.Equals(username, "admin", StringComparison.Ordinal) &&
                password == "1234")
            {
                var dashboard = new Hr_Dash();
                // when dashboard closes, show login again
                dashboard.FormClosed += (s, args) => this.Show();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Clear();
                textBox1.Focus();
            }
        }
    }
}
