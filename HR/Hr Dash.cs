using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace C__project.HR
{
    public partial class Hr_Dash : Form
    {
        // keep a single instance so multiple clicks don't open multiple forms
        private Register_employee _regForm;

        // guard to prevent re-entrancy when logging out
        private bool _logoutInProgress;

        public Hr_Dash()
        {
            InitializeComponent();

            
        }
        private void LoadHome()
        {
            panelContent.Controls.Clear();

            Label lbl = new Label();
            lbl.Text = "Welcome to HR Dashboard";
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lbl.ForeColor = Color.Black;

            panelContent.Controls.Add(lbl);
        }


        private void RegForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Cleanup reference and show dashboard again
            _regForm = null;
            if (!this.IsDisposed)
                this.Show();
        }

       
        private void guna2Button2_Click(object sender, EventArgs e) 
        {
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e) { }

        private void guna2Button2_Click_1(object sender, EventArgs e) 
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e) { }

        private void guna2Button1_Click(object sender, EventArgs e) 
        {
            panelContent.Controls.Clear();

            UC_RegisterEmployee uc = new UC_RegisterEmployee();
            uc.Dock = DockStyle.Fill;

            panelContent.Controls.Add(uc);
        }

        private void guna2Button3_Click(object sender, EventArgs e) { }

        private void guna2Button4_Click(object sender, EventArgs e) 
        {
           
        }

        private void guna2Button5_Click(object sender, EventArgs e) { }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Hr_Dash_Load(object sender, EventArgs e)
        {
            LoadHome();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
