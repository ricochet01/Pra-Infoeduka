namespace Infoeduka
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.horizontalLine = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnLecturers = new System.Windows.Forms.Button();
            this.btnSubjects = new System.Windows.Forms.Button();
            this.flpContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(735, 19);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(65, 25);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Subjects";
            // 
            // horizontalLine
            // 
            this.horizontalLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.horizontalLine.Location = new System.Drawing.Point(-61, 60);
            this.horizontalLine.Name = "horizontalLine";
            this.horizontalLine.Size = new System.Drawing.Size(931, 10);
            this.horizontalLine.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Location = new System.Drawing.Point(70, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 32);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFilter.BackgroundImage")));
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilter.Location = new System.Drawing.Point(133, 12);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(32, 32);
            this.btnFilter.TabIndex = 9;
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // btnLecturers
            // 
            this.btnLecturers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLecturers.BackgroundImage")));
            this.btnLecturers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLecturers.Location = new System.Drawing.Point(196, 12);
            this.btnLecturers.Name = "btnLecturers";
            this.btnLecturers.Size = new System.Drawing.Size(32, 32);
            this.btnLecturers.TabIndex = 10;
            this.btnLecturers.UseVisualStyleBackColor = true;
            // 
            // btnSubjects
            // 
            this.btnSubjects.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubjects.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubjects.BackgroundImage")));
            this.btnSubjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubjects.Location = new System.Drawing.Point(260, 12);
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.Size = new System.Drawing.Size(32, 32);
            this.btnSubjects.TabIndex = 11;
            this.btnSubjects.UseVisualStyleBackColor = false;
            // 
            // flpContainer
            // 
            this.flpContainer.AutoScroll = true;
            this.flpContainer.Location = new System.Drawing.Point(12, 140);
            this.flpContainer.Name = "flpContainer";
            this.flpContainer.Size = new System.Drawing.Size(788, 346);
            this.flpContainer.TabIndex = 12;
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(32, 32);
            this.btnHome.TabIndex = 13;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(812, 498);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.flpContainer);
            this.Controls.Add(this.btnSubjects);
            this.Controls.Add(this.btnLecturers);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.horizontalLine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsername);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Infoeduka 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblUsername;
        private Label label1;
        private Label horizontalLine;
        private Button btnAdd;
        private Button btnFilter;
        private Button btnLecturers;
        private Button btnSubjects;
        private FlowLayoutPanel flpContainer;
        private Button btnHome;
    }
}