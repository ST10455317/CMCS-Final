using System;
using System.Windows.Forms;

namespace CyberAwarenessGUI
{
    partial class LogsPage : UserControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtLogInput;
        private System.Windows.Forms.Button btnAddLog;
        private System.Windows.Forms.ListBox listLogs;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtLogInput = new System.Windows.Forms.TextBox();
            this.btnAddLog = new System.Windows.Forms.Button();
            this.listLogs = new System.Windows.Forms.ListBox();

            this.SuspendLayout();

            
            this.txtLogInput.Location = new System.Drawing.Point(10, 10);
            this.txtLogInput.Size = new System.Drawing.Size(200, 25);

            
            this.btnAddLog.Location = new System.Drawing.Point(220, 10);
            this.btnAddLog.Size = new System.Drawing.Size(75, 25);
            this.btnAddLog.Text = "Add Log";
            this.btnAddLog.Click += new System.EventHandler(this.btnAddLog_Click);

            
            this.listLogs.Location = new System.Drawing.Point(10, 50);
            this.listLogs.Size = new System.Drawing.Size(365, 130);

           
            this.Controls.Add(this.txtLogInput);
            this.Controls.Add(this.btnAddLog);
            this.Controls.Add(this.listLogs);
            this.Size = new System.Drawing.Size(400, 200);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void btnAddLog_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtLogInput.Text))
            {
                listLogs.Items.Add(txtLogInput.Text);
                txtLogInput.Clear();
            }
        }
    }
}
        