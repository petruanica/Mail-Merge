namespace MailMerge
{
    partial class Form_MailMerge
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxSignature = new System.Windows.Forms.CheckBox();
            this.checkBoxSend = new System.Windows.Forms.CheckBox();
            this.numericUpDownLower = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownUpper = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddAttachment = new System.Windows.Forms.Button();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxBcc = new System.Windows.Forms.TextBox();
            this.textBoxCc = new System.Windows.Forms.TextBox();
            this.radioButtonSelectAll = new System.Windows.Forms.RadioButton();
            this.radioButtonSelectRange = new System.Windows.Forms.RadioButton();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.listBoxAttachments = new System.Windows.Forms.ListBox();
            this.buttonRemoveAttachment = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxTemplate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSelectTemplate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpper)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "BCC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "CC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Attachements";
            // 
            // checkBoxSignature
            // 
            this.checkBoxSignature.AutoSize = true;
            this.checkBoxSignature.Location = new System.Drawing.Point(664, 500);
            this.checkBoxSignature.Name = "checkBoxSignature";
            this.checkBoxSignature.Size = new System.Drawing.Size(112, 20);
            this.checkBoxSignature.TabIndex = 5;
            this.checkBoxSignature.Text = "Add signature";
            this.checkBoxSignature.UseVisualStyleBackColor = true;
            // 
            // checkBoxSend
            // 
            this.checkBoxSend.AutoSize = true;
            this.checkBoxSend.Location = new System.Drawing.Point(664, 540);
            this.checkBoxSend.Name = "checkBoxSend";
            this.checkBoxSend.Size = new System.Drawing.Size(97, 20);
            this.checkBoxSend.TabIndex = 6;
            this.checkBoxSend.Text = "Send email";
            this.checkBoxSend.UseVisualStyleBackColor = true;
            // 
            // numericUpDownLower
            // 
            this.numericUpDownLower.Location = new System.Drawing.Point(151, 538);
            this.numericUpDownLower.Name = "numericUpDownLower";
            this.numericUpDownLower.Size = new System.Drawing.Size(104, 22);
            this.numericUpDownLower.TabIndex = 9;
            // 
            // numericUpDownUpper
            // 
            this.numericUpDownUpper.Location = new System.Drawing.Point(285, 538);
            this.numericUpDownUpper.Name = "numericUpDownUpper";
            this.numericUpDownUpper.Size = new System.Drawing.Size(104, 22);
            this.numericUpDownUpper.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 541);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "to";
            // 
            // buttonAddAttachment
            // 
            this.buttonAddAttachment.Location = new System.Drawing.Point(539, 221);
            this.buttonAddAttachment.Name = "buttonAddAttachment";
            this.buttonAddAttachment.Size = new System.Drawing.Size(101, 27);
            this.buttonAddAttachment.TabIndex = 7;
            this.buttonAddAttachment.Text = "Add";
            this.buttonAddAttachment.UseVisualStyleBackColor = true;
            this.buttonAddAttachment.Click += new System.EventHandler(this.buttonAddAttachment_Click);
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(88, 92);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(322, 22);
            this.textBoxSubject.TabIndex = 1;
            // 
            // textBoxBcc
            // 
            this.textBoxBcc.Location = new System.Drawing.Point(88, 138);
            this.textBoxBcc.Name = "textBoxBcc";
            this.textBoxBcc.Size = new System.Drawing.Size(322, 22);
            this.textBoxBcc.TabIndex = 2;
            // 
            // textBoxCc
            // 
            this.textBoxCc.Location = new System.Drawing.Point(88, 185);
            this.textBoxCc.Name = "textBoxCc";
            this.textBoxCc.Size = new System.Drawing.Size(322, 22);
            this.textBoxCc.TabIndex = 3;
            // 
            // radioButtonSelectAll
            // 
            this.radioButtonSelectAll.AutoSize = true;
            this.radioButtonSelectAll.Location = new System.Drawing.Point(28, 500);
            this.radioButtonSelectAll.Name = "radioButtonSelectAll";
            this.radioButtonSelectAll.Size = new System.Drawing.Size(83, 20);
            this.radioButtonSelectAll.TabIndex = 4;
            this.radioButtonSelectAll.TabStop = true;
            this.radioButtonSelectAll.Text = "Select all";
            this.radioButtonSelectAll.UseVisualStyleBackColor = true;
            this.radioButtonSelectAll.CheckedChanged += new System.EventHandler(this.radioButtonSelectAll_CheckedChanged);
            // 
            // radioButtonSelectRange
            // 
            this.radioButtonSelectRange.AutoSize = true;
            this.radioButtonSelectRange.Location = new System.Drawing.Point(28, 538);
            this.radioButtonSelectRange.Name = "radioButtonSelectRange";
            this.radioButtonSelectRange.Size = new System.Drawing.Size(104, 20);
            this.radioButtonSelectRange.TabIndex = 18;
            this.radioButtonSelectRange.TabStop = true;
            this.radioButtonSelectRange.Text = "Select range";
            this.radioButtonSelectRange.UseVisualStyleBackColor = true;
            this.radioButtonSelectRange.CheckedChanged += new System.EventHandler(this.radioButtonSelectRange_CheckedChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(486, 620);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(128, 34);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(640, 620);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(128, 34);
            this.buttonFinish.TabIndex = 8;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // listBoxAttachments
            // 
            this.listBoxAttachments.FormattingEnabled = true;
            this.listBoxAttachments.ItemHeight = 16;
            this.listBoxAttachments.Location = new System.Drawing.Point(20, 258);
            this.listBoxAttachments.Name = "listBoxAttachments";
            this.listBoxAttachments.Size = new System.Drawing.Size(748, 196);
            this.listBoxAttachments.TabIndex = 21;
            // 
            // buttonRemoveAttachment
            // 
            this.buttonRemoveAttachment.Location = new System.Drawing.Point(667, 221);
            this.buttonRemoveAttachment.Name = "buttonRemoveAttachment";
            this.buttonRemoveAttachment.Size = new System.Drawing.Size(101, 27);
            this.buttonRemoveAttachment.TabIndex = 22;
            this.buttonRemoveAttachment.Text = "Remove";
            this.buttonRemoveAttachment.UseVisualStyleBackColor = true;
            this.buttonRemoveAttachment.Click += new System.EventHandler(this.buttonRemoveAttachment_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxTemplate
            // 
            this.textBoxTemplate.Location = new System.Drawing.Point(88, 38);
            this.textBoxTemplate.Name = "textBoxTemplate";
            this.textBoxTemplate.Size = new System.Drawing.Size(632, 22);
            this.textBoxTemplate.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Template";
            // 
            // buttonSelectTemplate
            // 
            this.buttonSelectTemplate.Location = new System.Drawing.Point(708, 33);
            this.buttonSelectTemplate.Name = "buttonSelectTemplate";
            this.buttonSelectTemplate.Size = new System.Drawing.Size(32, 32);
            this.buttonSelectTemplate.TabIndex = 24;
            this.buttonSelectTemplate.Text = "...";
            this.buttonSelectTemplate.UseVisualStyleBackColor = true;
            this.buttonSelectTemplate.Click += new System.EventHandler(this.buttonSelectTemplate_Click);
            // 
            // Form_MailMerge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 680);
            this.Controls.Add(this.buttonSelectTemplate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTemplate);
            this.Controls.Add(this.buttonRemoveAttachment);
            this.Controls.Add(this.listBoxAttachments);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.radioButtonSelectRange);
            this.Controls.Add(this.radioButtonSelectAll);
            this.Controls.Add(this.textBoxCc);
            this.Controls.Add(this.textBoxBcc);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.buttonAddAttachment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownUpper);
            this.Controls.Add(this.numericUpDownLower);
            this.Controls.Add(this.checkBoxSend);
            this.Controls.Add(this.checkBoxSignature);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_MailMerge";
            this.Text = "Form_MailMerge";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxSignature;
        private System.Windows.Forms.CheckBox checkBoxSend;
        private System.Windows.Forms.NumericUpDown numericUpDownLower;
        private System.Windows.Forms.NumericUpDown numericUpDownUpper;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAddAttachment;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBoxBcc;
        private System.Windows.Forms.TextBox textBoxCc;
        private System.Windows.Forms.RadioButton radioButtonSelectAll;
        private System.Windows.Forms.RadioButton radioButtonSelectRange;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.ListBox listBoxAttachments;
        private System.Windows.Forms.Button buttonRemoveAttachment;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxTemplate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSelectTemplate;
    }
}