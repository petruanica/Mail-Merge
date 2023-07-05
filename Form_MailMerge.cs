using System;
using System.Linq;
using System.Windows.Forms;

namespace MailMerge
{
    public partial class Form_MailMerge : Form
    {
        public string TemplatePath { get; set; }

        public Form_MailMerge()
        {
            InitializeComponent();
            radioButtonSelectAll.Checked = true;
            numericUpDownLower.Minimum = 1;
            numericUpDownUpper.Minimum = 1;
            numericUpDownLower.Maximum = int.MaxValue;
            numericUpDownUpper.Maximum = int.MaxValue;

        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            var subject = textBoxSubject.Text;
            var bcc = textBoxBcc.Text;
            var cc = textBoxCc.Text;

            var attachments = listBoxAttachments.Items.Cast<string>().ToList();

            var addSignature = checkBoxSignature.Checked;
            var sendEmails = checkBoxSend.Checked;

            var lowerBound = radioButtonSelectRange.Checked
                ? Convert.ToInt32(numericUpDownLower.Text)
                : 1;
            var upperBound = radioButtonSelectRange.Checked
                ? Convert.ToInt32(numericUpDownUpper.Text)
                : int.MaxValue;

            MailMergeHandler.PerformMailMerge(TemplatePath, subject, bcc, cc, attachments, lowerBound, upperBound, addSignature, sendEmails);
            Close();
        }

        private void radioButtonSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownLower.Enabled = false;
            numericUpDownUpper.Enabled = false;
        }

        private void radioButtonSelectRange_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownLower.Enabled = true;
            numericUpDownUpper.Enabled = true;
        }

        private void buttonAddAttachment_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result != DialogResult.OK) return;
            listBoxAttachments.Items.Add(openFileDialog1.FileName);
        }

        private void buttonRemoveAttachment_Click(object sender, EventArgs e)
        {
            listBoxAttachments.Items.Remove(listBoxAttachments.SelectedItem);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSelectTemplate_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result != DialogResult.OK) return;
            textBoxTemplate.Text = openFileDialog1.FileName;
            TemplatePath = openFileDialog1.FileName;
        }
    }
}
