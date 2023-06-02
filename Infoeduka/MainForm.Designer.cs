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
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.btnFilter = new System.Windows.Forms.PictureBox();
            this.btnLecturers = new System.Windows.Forms.PictureBox();
            this.btnSubjects = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.horizontalLine = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLecturers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(35, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.uiButton_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.uiButton_MouseLeave);
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFilter.BackgroundImage")));
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFilter.Location = new System.Drawing.Point(93, 12);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(35, 32);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.TabStop = false;
            this.btnFilter.MouseEnter += new System.EventHandler(this.uiButton_MouseEnter);
            this.btnFilter.MouseLeave += new System.EventHandler(this.uiButton_MouseLeave);
            // 
            // btnLecturers
            // 
            this.btnLecturers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLecturers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLecturers.BackgroundImage")));
            this.btnLecturers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLecturers.Location = new System.Drawing.Point(190, 12);
            this.btnLecturers.Name = "btnLecturers";
            this.btnLecturers.Size = new System.Drawing.Size(35, 32);
            this.btnLecturers.TabIndex = 2;
            this.btnLecturers.TabStop = false;
            this.btnLecturers.MouseEnter += new System.EventHandler(this.uiButton_MouseEnter);
            this.btnLecturers.MouseLeave += new System.EventHandler(this.uiButton_MouseLeave);
            // 
            // btnSubjects
            // 
            this.btnSubjects.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubjects.BackgroundImage")));
            this.btnSubjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSubjects.Location = new System.Drawing.Point(279, 12);
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.Size = new System.Drawing.Size(35, 32);
            this.btnSubjects.TabIndex = 3;
            this.btnSubjects.TabStop = false;
            this.btnSubjects.MouseEnter += new System.EventHandler(this.uiButton_MouseEnter);
            this.btnSubjects.MouseLeave += new System.EventHandler(this.uiButton_MouseLeave);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(713, 19);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.horizontalLine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnSubjects);
            this.Controls.Add(this.btnLecturers);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnAdd);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLecturers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox btnAdd;
        private PictureBox btnFilter;
        private PictureBox btnLecturers;
        private PictureBox btnSubjects;
        private Label lblUsername;
        private Label label1;
        private Label horizontalLine;
    }
}