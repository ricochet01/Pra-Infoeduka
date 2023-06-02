namespace PRA_Notifications
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbDefault = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.btnLecturers = new System.Windows.Forms.Button();
            this.flpContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.ucNotification1 = new PRA_Notifications.ucNotification();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefault)).BeginInit();
            this.flpContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbDefault
            // 
            this.pbDefault.Image = global::PRA_Notifications.Properties.Resources.fotor_2023_5_29_1_27_8;
            this.pbDefault.Location = new System.Drawing.Point(748, 1);
            this.pbDefault.Name = "pbDefault";
            this.pbDefault.Size = new System.Drawing.Size(40, 58);
            this.pbDefault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDefault.TabIndex = 0;
            this.pbDefault.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.Location = new System.Drawing.Point(652, 18);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(90, 32);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Admin";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Image = global::PRA_Notifications.Properties.Resources.rsz_add_43;
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(36, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnSubject
            // 
            this.btnSubject.BackColor = System.Drawing.Color.White;
            this.btnSubject.FlatAppearance.BorderSize = 0;
            this.btnSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubject.Image = global::PRA_Notifications.Properties.Resources.rsz_open_book_icon_free_vector;
            this.btnSubject.Location = new System.Drawing.Point(129, 12);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(36, 36);
            this.btnSubject.TabIndex = 4;
            this.btnSubject.UseVisualStyleBackColor = false;
            // 
            // btnLecturers
            // 
            this.btnLecturers.AutoSize = true;
            this.btnLecturers.BackColor = System.Drawing.Color.White;
            this.btnLecturers.FlatAppearance.BorderSize = 0;
            this.btnLecturers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLecturers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLecturers.Image = global::PRA_Notifications.Properties.Resources.rsz_2815428;
            this.btnLecturers.Location = new System.Drawing.Point(192, 12);
            this.btnLecturers.Name = "btnLecturers";
            this.btnLecturers.Size = new System.Drawing.Size(36, 38);
            this.btnLecturers.TabIndex = 5;
            this.btnLecturers.UseVisualStyleBackColor = false;
            // 
            // flpContainer
            // 
            this.flpContainer.Controls.Add(this.ucNotification1);
            this.flpContainer.Location = new System.Drawing.Point(1, 95);
            this.flpContainer.Name = "flpContainer";
            this.flpContainer.Size = new System.Drawing.Size(798, 355);
            this.flpContainer.TabIndex = 6;
            // 
            // ucNotification1
            // 
            this.ucNotification1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ucNotification1.Location = new System.Drawing.Point(3, 3);
            this.ucNotification1.Name = "ucNotification1";
            this.ucNotification1.Size = new System.Drawing.Size(340, 188);
            this.ucNotification1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Notifications";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.White;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFilter.Image = global::PRA_Notifications.Properties.Resources.rsz_adjustbuttonicon;
            this.btnFilter.Location = new System.Drawing.Point(68, 12);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(36, 36);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpContainer);
            this.Controls.Add(this.btnLecturers);
            this.Controls.Add(this.btnSubject);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.pbDefault);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Infoeduka";
            ((System.ComponentModel.ISupportInitialize)(this.pbDefault)).EndInit();
            this.flpContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbDefault;
        private Label lblUserName;
        private Button btnAdd;
        private Button btnSubject;
        private Button btnLecturers;
        private FlowLayoutPanel flpContainer;
        private Label label1;
        private Button btnFilter;
        private ucNotification ucNotification1;
    }
}