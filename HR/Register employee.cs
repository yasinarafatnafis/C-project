using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__project
{
    public partial class Register_employee : Form
    {
        public Register_employee()
        {
            InitializeComponent();
        }

        private void Register_employee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["Hr_Dash"]?.Show();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Register_employee_Load(object sender, EventArgs e)
        {

        }
    }
}
