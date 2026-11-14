using System;
using System.IO;
using System.Windows.Forms;

namespace ReminderMessageService
{
    public partial class Form1 : Form
    {
        private int messageIndex = 0;

        private string[] reminders =
        {
            "Reminder: Take a short break.",
            "Reminder: Drink some water.",
            "Reminder: Check your pending tasks.",
            "Reminder: Keep working on your project.",
            "Reminder: Save your work."
        };

        private string logFile = "reminder_log.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();

            lblStatus.Text = "Status: Running";

            lstLog.Items.Add(
                DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")
                + " - Reminder service started."
            );

            WriteLog("Reminder service started.");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            lblStatus.Text = "Status: Stopped";

            lstLog.Items.Add(
                DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")
                + " - Reminder service stopped."
            );

            WriteLog("Reminder service stopped.");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string message = reminders[messageIndex];

            lstLog.Items.Add(
                DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")
                + " - " + message
            );

            WriteLog(message);

            MessageBox.Show(
                message,
                "Reminder Message",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            messageIndex++;

            if (messageIndex >= reminders.Length)
            {
                messageIndex = 0;
            }
        }

        private void WriteLog(string message)
        {
            string logMessage =
                DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")
                + " - " + message;

            File.AppendAllText(
                logFile,
                logMessage + Environment.NewLine
            );
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }
    }
}