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
    public partial class Notice : Form
    {
        public Notice()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Owner != null && !this.Owner.IsDisposed)
            {
                try
                {
                    this.Owner.Show();
                    this.Owner.BringToFront();
                }
                catch
                {
                    // ignore any error restoring owner
                }
            }

            this.Close();
        }
    }
}
