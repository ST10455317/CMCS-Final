using System;
using System.Windows.Forms;

namespace CyberAwarenessGUI
{
    partial class SentimentPage : UserControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtSentimentInput;
        private System.Windows.Forms.Button btnAnalyse;
        private System.Windows.Forms.Label lblResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtSentimentInput = new System.Windows.Forms.TextBox();
            this.btnAnalyse = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // txtSentimentInput
            this.txtSentimentInput.Location = new System.Drawing.Point(10, 10);
            this.txtSentimentInput.Size = new System.Drawing.Size(200, 25);

            // btnAnalyse
            this.btnAnalyse.Location = new System.Drawing.Point(220, 10);
            this.btnAnalyse.Size = new System.Drawing.Size(75, 25);
            this.btnAnalyse.Text = "Analyse";
            this.btnAnalyse.Click += new System.EventHandler(this.btnAnalyse_Click);

            // lblResult
            this.lblResult.Location = new System.Drawing.Point(10, 50);
            this.lblResult.Size = new System.Drawing.Size(300, 25);
            this.lblResult.Text = "Sentiment Result";

            // SentimentPage
            this.Controls.Add(this.txtSentimentInput);
            this.Controls.Add(this.btnAnalyse);
            this.Controls.Add(this.lblResult);
            this.Size = new System.Drawing.Size(400, 200);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void btnAnalyse_Click(object sender, EventArgs e)
        {
            string input = txtSentimentInput.Text.ToLower();
            if (input.Contains("good") || input.Contains("safe"))
                lblResult.Text = "Positive sentiment";
            else
                lblResult.Text = "Negative/Neutral sentiment";
        }
    }
}
        
    

