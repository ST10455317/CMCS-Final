using System;
using System.Windows.Forms;

namespace CyberAwarenessGUI
{
    partial class QuizPage : UserControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnStartQuiz;
        private System.Windows.Forms.Label lblQuizInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnStartQuiz = new System.Windows.Forms.Button();
            this.lblQuizInfo = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // lblQuizInfo
            this.lblQuizInfo.Location = new System.Drawing.Point(10, 10);
            this.lblQuizInfo.Size = new System.Drawing.Size(350, 50);
            this.lblQuizInfo.Text = "This is a sample cybersecurity quiz.";

            // btnStartQuiz
            this.btnStartQuiz.Location = new System.Drawing.Point(10, 70);
            this.btnStartQuiz.Size = new System.Drawing.Size(100, 25);
            this.btnStartQuiz.Text = "Start Quiz";
            this.btnStartQuiz.Click += new System.EventHandler(this.btnStartQuiz_Click);

            // QuizPage
            this.Controls.Add(this.lblQuizInfo);
            this.Controls.Add(this.btnStartQuiz);
            this.Size = new System.Drawing.Size(400, 200);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        { 
            MessageBox.Show("Quiz started! (Add your questions later)");
        }
    }
}
        