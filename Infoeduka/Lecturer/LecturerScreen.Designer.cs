namespace Infoeduka.Lecturer
{
    partial class LecturerScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturerScreen));
            this.flpContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLecturerName = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpContainer
            // 
            this.flpContainer.AutoScroll = true;
            this.flpContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpContainer.Location = new System.Drawing.Point(12, 46);
            this.flpContainer.Name = "flpContainer";
            this.flpContainer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flpContainer.Size = new System.Drawing.Size(226, 101);
            this.flpContainer.TabIndex = 0;
            // 
            // lblLecturerName
            // 
            this.lblLecturerName.AutoSize = true;
            this.lblLecturerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLecturerName.Location = new System.Drawing.Point(12, 16);
            this.lblLecturerName.Name = "lblLecturerName";
            this.lblLecturerName.Size = new System.Drawing.Size(110, 21);
            this.lblLecturerName.TabIndex = 1;
            this.lblLecturerName.Text = "Lecturer name";
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Location = new System.Drawing.Point(146, 12);
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
            // LecturerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblLecturerName);
            this.Controls.Add(this.flpContainer);
            this.Name = "LecturerScreen";
            this.Size = new System.Drawing.Size(248, 153);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flpContainer;
        private Label lblLecturerName;
        private Button btnEdit;
        private Button btnDelete;
    }
}
