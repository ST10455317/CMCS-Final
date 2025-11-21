using System;
using System.Windows.Forms;

namespace CyberAwarenessGUI
{
    partial class TasksPage : UserControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTaskInput;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.ListBox listTasks;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtTaskInput = new System.Windows.Forms.TextBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.listTasks = new System.Windows.Forms.ListBox();

            this.SuspendLayout();

            
            this.txtTaskInput.Location = new System.Drawing.Point(10, 10);
            this.txtTaskInput.Size = new System.Drawing.Size(200, 25);

            
            this.btnAddTask.Location = new System.Drawing.Point(220, 10);
            this.btnAddTask.Size = new System.Drawing.Size(75, 25);
            this.btnAddTask.Text = "Add";
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);

            
            this.btnRemoveTask.Location = new System.Drawing.Point(300, 10);
            this.btnRemoveTask.Size = new System.Drawing.Size(75, 25);
            this.btnRemoveTask.Text = "Remove";
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);

            
            this.listTasks.Location = new System.Drawing.Point(10, 50);
            this.listTasks.Size = new System.Drawing.Size(365, 130);

            this.Controls.Add(this.txtTaskInput);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.btnRemoveTask);
            this.Controls.Add(this.listTasks);
            this.Size = new System.Drawing.Size(400, 200);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            if (listTasks.SelectedItem != null)
                listTasks.Items.Remove(listTasks.SelectedItem);
        }
    
        private void btnAddTask_Click(object sender, EventArgs e)
        {
           
            if (!string.IsNullOrWhiteSpace(txtTaskInput.Text))
            {
                listTasks.Items.Add(txtTaskInput.Text);
                txtTaskInput.Clear();
            }
        }
    }
}
