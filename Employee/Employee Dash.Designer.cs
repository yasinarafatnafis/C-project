namespace C__project
{
    partial class Employee_Dash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bNotice = new System.Windows.Forms.Button();
            this.bApplication = new System.Windows.Forms.Button();
            this.bProfile = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bNotice
            // 
            this.bNotice.Location = new System.Drawing.Point(91, 86);
            this.bNotice.Margin = new System.Windows.Forms.Padding(4);
            this.bNotice.Name = "bNotice";
            this.bNotice.Size = new System.Drawing.Size(184, 55);
            this.bNotice.TabIndex = 0;
            this.bNotice.Text = "Notice Board";
            this.bNotice.UseVisualStyleBackColor = true;
            this.bNotice.Click += new System.EventHandler(this.bNotice_Click);
            // 
            // bApplication
            // 
            this.bApplication.Location = new System.Drawing.Point(91, 227);
            this.bApplication.Margin = new System.Windows.Forms.Padding(4);
            this.bApplication.Name = "bApplication";
            this.bApplication.Size = new System.Drawing.Size(184, 55);
            this.bApplication.TabIndex = 1;
            this.bApplication.Text = "Create an Application";
            this.bApplication.UseVisualStyleBackColor = true;
            // 
            // bProfile
            // 
            this.bProfile.Location = new System.Drawing.Point(91, 354);
            this.bProfile.Margin = new System.Windows.Forms.Padding(4);
            this.bProfile.Name = "bProfile";
            this.bProfile.Size = new System.Drawing.Size(184, 55);
            this.bProfile.TabIndex = 2;
            this.bProfile.Text = "Update Profile";
            this.bProfile.UseVisualStyleBackColor = true;
            this.bProfile.Click += new System.EventHandler(this.bProfile_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(947, 563);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 56);
            this.button4.TabIndex = 3;
            this.button4.Text = "Log Out";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Employee_Dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 686);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bProfile);
            this.Controls.Add(this.bApplication);
            this.Controls.Add(this.bNotice);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Employee_Dash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_Dash";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bNotice;
        private System.Windows.Forms.Button bApplication;
        private System.Windows.Forms.Button bProfile;
        private System.Windows.Forms.Button button4;
    }
}