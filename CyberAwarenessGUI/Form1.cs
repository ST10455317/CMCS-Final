using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberAwarenessGUI
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            string userMessage = txtUserInput.Text.Trim();

            if (string.IsNullOrEmpty(userMessage))
            {
                MessageBox.Show("Please type something.");
                return;
            }


            txtChatHistory.AppendText("You: " + userMessage + Environment.NewLine);


            string botReply = GetBotReply(userMessage);
            txtChatHistory.AppendText("Bot: " + botReply + Environment.NewLine + Environment.NewLine);

            txtUserInput.Clear();
        }


        private string GetBotReply(string message)
        {
            string lower = message.ToLower();

            if (lower.Contains("hello") || lower.Contains("hi"))
                return "Hello! How can I help you stay cyber safe today?";

            if (lower.Contains("phishing"))
                return "Phishing is when criminals try to steal personal information.";

            if (lower.Contains("password"))
                return "Use strong passwords with numbers and symbols.";

            if (lower.Contains("scam"))
                return "Do not trust messages asking for money or personal info.";

            return "I'm not sure about that yet, but I'm learning!";
        }

        // NAVIGATION BUTTONS
        private void btnTasks_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            TasksPage page = new TasksPage();
            page.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(page);
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            QuizPage page = new QuizPage();
            page.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(page);
        }

        private void btnSentiment_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            SentimentPage page = new SentimentPage();
            page.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(page);
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            LogsPage page = new LogsPage();
            page.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(page);
        }
    }
}
