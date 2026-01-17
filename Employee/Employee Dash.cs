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
    public partial class Employee_Dash : Form
    {
        public Employee_Dash()
        {
            InitializeComponent();
        }

        private void bNotice_Click(object sender, EventArgs e)
        {
            Notice_Board nb = new Notice_Board();   
            nb.Show();
            this.Hide();
        }

        private void bProfile_Click(object sender, EventArgs e)
        {
            UpdateProfile up = new UpdateProfile();
            up.Show();
            this.Hide();
        }
    }
}
