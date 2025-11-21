namespace CyberAwarenessGUI
{
    partial class form
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
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.txtChatHistory = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnQuiz = new System.Windows.Forms.Button();
            this.btnSentiment = new System.Windows.Forms.Button();
            this.btnLogs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(212, 51);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(328, 20);
            this.txtUserInput.TabIndex = 0;
            // 
            // txtChatHistory
            // 
            this.txtChatHistory.Location = new System.Drawing.Point(61, 67);
            this.txtChatHistory.Name = "txtChatHistory";
            this.txtChatHistory.ReadOnly = true;
            this.txtChatHistory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtChatHistory.Size = new System.Drawing.Size(100, 96);
            this.txtChatHistory.TabIndex = 1;
            this.txtChatHistory.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(619, 51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(212, 96);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(328, 151);
            this.panelContainer.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(61, 297);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnTasks
            // 
            this.btnTasks.Location = new System.Drawing.Point(180, 296);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(75, 23);
            this.btnTasks.TabIndex = 5;
            this.btnTasks.Text = "Tasks";
            this.btnTasks.UseVisualStyleBackColor = true;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // btnQuiz
            // 
            this.btnQuiz.Location = new System.Drawing.Point(308, 297);
            this.btnQuiz.Name = "btnQuiz";
            this.btnQuiz.Size = new System.Drawing.Size(75, 23);
            this.btnQuiz.TabIndex = 6;
            this.btnQuiz.Text = "Quiz";
            this.btnQuiz.UseVisualStyleBackColor = true;
            this.btnQuiz.Click += new System.EventHandler(this.btnQuiz_Click);
            // 
            // btnSentiment
            // 
            this.btnSentiment.Location = new System.Drawing.Point(465, 296);
            this.btnSentiment.Name = "btnSentiment";
            this.btnSentiment.Size = new System.Drawing.Size(75, 23);
            this.btnSentiment.TabIndex = 7;
            this.btnSentiment.Text = "Sentiment";
            this.btnSentiment.UseVisualStyleBackColor = true;
            this.btnSentiment.Click += new System.EventHandler(this.btnSentiment_Click);
            // 
            // btnLogs
            // 
            this.btnLogs.Location = new System.Drawing.Point(644, 296);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(75, 23);
            this.btnLogs.TabIndex = 8;
            this.btnLogs.Text = "Logs";
            this.btnLogs.UseVisualStyleBackColor = true;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogs);
            this.Controls.Add(this.btnSentiment);
            this.Controls.Add(this.btnQuiz);
            this.Controls.Add(this.btnTasks);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtChatHistory);
            this.Controls.Add(this.txtUserInput);
            this.Name = "form";
            this.Text = "form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.RichTextBox txtChatHistory;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Button btnQuiz;
        private System.Windows.Forms.Button btnSentiment;
        private System.Windows.Forms.Button btnLogs;
    }
}

