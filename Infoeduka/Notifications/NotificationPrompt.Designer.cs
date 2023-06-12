namespace Infoeduka.notifications
{
    partial class NotificationPrompt
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
            label1 = new Label();
            cbSubjects = new ComboBox();
            label2 = new Label();
            tbTitle = new TextBox();
            label3 = new Label();
            rtbBody = new RichTextBox();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Choose a subject";
            // 
            // cbSubjects
            // 
            cbSubjects.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSubjects.FormattingEnabled = true;
            cbSubjects.Location = new Point(12, 37);
            cbSubjects.Name = "cbSubjects";
            cbSubjects.Size = new Size(361, 23);
            cbSubjects.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 2;
            label2.Text = "Title";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(12, 95);
            tbTitle.MaxLength = 96;
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(361, 23);
            tbTitle.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 159);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 4;
            label3.Text = "Body";
            // 
            // rtbBody
            // 
            rtbBody.Location = new Point(12, 177);
            rtbBody.Name = "rtbBody";
            rtbBody.Size = new Size(361, 194);
            rtbBody.TabIndex = 5;
            rtbBody.Text = "";
            // 
            // btnOk
            // 
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(34, 415);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 6;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(263, 415);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // NotificationPrompt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(rtbBody);
            Controls.Add(label3);
            Controls.Add(tbTitle);
            Controls.Add(label2);
            Controls.Add(cbSubjects);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "NotificationPrompt";
            Text = "NotificationPrompt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbSubjects;
        private Label label2;
        private TextBox tbTitle;
        private Label label3;
        private RichTextBox rtbBody;
        private Button btnOk;
        private Button btnCancel;
    }
}