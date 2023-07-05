using System;
using System.Windows.Forms;


namespace MailMerge
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void tsmiMailMerge_Click(object sender, EventArgs e)
        {
            var form = new Form_MailMerge();
            form.Show();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

