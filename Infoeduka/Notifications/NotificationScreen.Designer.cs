namespace Infoeduka.Notifications
{
    partial class NotificationScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationScreen));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblBody = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblDatePublished = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Location = new System.Drawing.Point(153, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(32, 32);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(213, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(32, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(3, 39);
            this.lblBody.MaximumSize = new System.Drawing.Size(225, 100);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(28, 15);
            this.lblBody.TabIndex = 3;
            this.lblBody.Text = "Text";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubject.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSubject.Location = new System.Drawing.Point(-1, 173);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(76, 13);
            this.lblSubject.TabIndex = 4;
            this.lblSubject.Text = "Subject name";
            // 
            // lblDatePublished
            // 
            this.lblDatePublished.AutoSize = true;
            this.lblDatePublished.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDatePublished.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDatePublished.Location = new System.Drawing.Point(184, 173);
            this.lblDatePublished.Name = "lblDatePublished";
            this.lblDatePublished.Size = new System.Drawing.Size(61, 13);
            this.lblDatePublished.TabIndex = 5;
            this.lblDatePublished.Text = "01.02.2023";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuthor.Location = new System.Drawing.Point(153, 149);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(56, 13);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "John Doe";
            // 
            // NotificationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblDatePublished);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblTitle);
            this.Name = "NotificationScreen";
            this.Size = new System.Drawing.Size(248, 186);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Button btnEdit;
        private Button btnDelete;
        private Label lblBody;
        private Label lblSubject;
        private Label lblDatePublished;
        private Label lblAuthor;
    }
}
