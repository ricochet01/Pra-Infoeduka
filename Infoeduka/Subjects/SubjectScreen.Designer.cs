namespace Infoeduka
{
    partial class SubjectScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectScreen));
            this.lbSubjectName = new System.Windows.Forms.Label();
            this.flpLecturers = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSubjectName
            // 
            this.lbSubjectName.AutoSize = true;
            this.lbSubjectName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSubjectName.Location = new System.Drawing.Point(12, 16);
            this.lbSubjectName.Name = "lbSubjectName";
            this.lbSubjectName.Size = new System.Drawing.Size(104, 21);
            this.lbSubjectName.TabIndex = 0;
            this.lbSubjectName.Text = "Subject name";
            // 
            // flpLecturers
            // 
            this.flpLecturers.AutoScroll = true;
            this.flpLecturers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpLecturers.Location = new System.Drawing.Point(12, 46);
            this.flpLecturers.Name = "flpLecturers";
            this.flpLecturers.Size = new System.Drawing.Size(226, 101);
            this.flpLecturers.TabIndex = 1;
            this.flpLecturers.WrapContents = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Location = new System.Drawing.Point(153, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(32, 32);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(206, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(32, 32);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // SubjectScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.flpLecturers);
            this.Controls.Add(this.lbSubjectName);
            this.Name = "SubjectScreen";
            this.Size = new System.Drawing.Size(250, 155);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbSubjectName;
        private FlowLayoutPanel flpLecturers;
        private Button btnEdit;
        private Button btnDelete;
    }
}
