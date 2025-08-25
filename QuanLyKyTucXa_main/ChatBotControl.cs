using System;
using System.Windows.Forms;
using QuanLy_Assistant;

namespace QuanLyKyTucXa_main
{
    public partial class ChatBotControl : UserControl
    {
        private FAQService assistant = new FAQService();

        public ChatBotControl()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            txtAnswer.ReadOnly = true;
            txtAnswer.ScrollBars = ScrollBars.Vertical;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string question = txtQuestion.Text.Trim();
            if (string.IsNullOrEmpty(question))
            {
                MessageBox.Show("Vui lòng nhập câu hỏi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string answer = assistant.GetAnswer(question);
            txtAnswer.AppendText("Bạn: " + question + Environment.NewLine);
            txtAnswer.AppendText("Bot: " + answer + Environment.NewLine + Environment.NewLine);
            txtQuestion.Clear();
            txtQuestion.Focus();

            // Auto scroll to bottom
            txtAnswer.SelectionStart = txtAnswer.Text.Length;
            txtAnswer.ScrollToCaret();
        }
    }
}