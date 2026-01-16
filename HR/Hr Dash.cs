using System;
using System.Linq;
using System.Windows.Forms;

namespace C__project
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

            // Unsubscribe first to avoid duplicate handlers (can happen if constructor
            // is called more than once during designer operations). Then subscribe.
            this.button1.Click -= this.button1_Click;
            this.button1.Click += this.button1_Click;

            this.button3.Click -= this.button3_Click;
            this.button3.Click += this.button3_Click;

            this.button4.Click -= this.button4_Click;
            this.button4.Click += this.button4_Click;

            this.button5.Click -= this.button5_Click;
            this.button5.Click += this.button5_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Register_employee: reuse instance, hide dashboard while it's open,
            // and show dashboard again when register form closes.
            if (_regForm != null && !_regForm.IsDisposed)
            {
                _regForm.BringToFront();
                return;
            }

            // Create a new Register_employee, hide the HR dashboard while it's open,
            // and show the dashboard again when the register form is closed.
            _regForm = new Register_employee();
            _regForm.FormClosed += (s, args) =>
            {
                _regForm = null;
                this.Show();
            };

            this.Hide();
            _regForm.Show(this); // non-modal, owned by HR dashboard
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Open Notice as a modal dialog so user returns to HR dashboard after closing
            using (var noticeForm = new Notice())
            {
                noticeForm.ShowDialog(this);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Open View_Order as a modal dialog so user returns to HR dashboard after closing
            using (var viewOrder = new View_Order())
            {
                viewOrder.ShowDialog(this);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Prevent re-entrancy / multiple message boxes
            if (_logoutInProgress)
                return;

            _logoutInProgress = true;
            this.button5.Enabled = false;

            try
            {
                var confirm = MessageBox.Show(
                    "Are you sure you want to log out?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (confirm == DialogResult.Yes)
                {
                    // Close any child windows owned by the dashboard to avoid orphan windows
                    try
                    {
                        if (_regForm != null && !_regForm.IsDisposed)
                            _regForm.FormClosed -= null; // no-op safe detach intent
                    }
                    catch { /* ignore cleanup errors */ }

                    // Try to find an existing Log_in form (reuse) to avoid creating multiples
                    var existingLogin = Application.OpenForms.OfType<Log_in>().FirstOrDefault();
                    if (existingLogin != null)
                    {
                        existingLogin.Show();
                        existingLogin.BringToFront();
                    }
                    else
                    {
                        var login = new Log_in();
                        login.Show();
                    }

                    // Close this dashboard (this will dispose it)
                    this.Close();
                }
            }
            finally
            {
                // If the form is still open (user said No), re-enable the button and clear guard.
                if (!this.IsDisposed)
                {
                    this.button5.Enabled = true;
                    _logoutInProgress = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
