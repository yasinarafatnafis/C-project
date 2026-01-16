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
    public partial class View_Order : Form
    {
        public View_Order()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Act like a "Back" button:
            // - If this form has an owner that was hidden, show it again.
            // - Close this form so control returns to the owner (or previous screen).
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
