namespace Infoeduka.Notifications
{
    partial class NotificationFilter
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
            this.tbSearchBar = new System.Windows.Forms.TextBox();
            this.clbSubjects = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // tbSearchBar
            // 
            this.tbSearchBar.Location = new System.Drawing.Point(-1, -1);
            this.tbSearchBar.MaxLength = 128;
            this.tbSearchBar.Name = "tbSearchBar";
            this.tbSearchBar.Size = new System.Drawing.Size(268, 23);
            this.tbSearchBar.TabIndex = 0;
            this.tbSearchBar.TextChanged += new System.EventHandler(this.tbSearchBar_TextChanged);
            // 
            // clbSubjects
            // 
            this.clbSubjects.CheckOnClick = true;
            this.clbSubjects.FormattingEnabled = true;
            this.clbSubjects.Location = new System.Drawing.Point(-1, 23);
            this.clbSubjects.Name = "clbSubjects";
            this.clbSubjects.ScrollAlwaysVisible = true;
            this.clbSubjects.Size = new System.Drawing.Size(268, 94);
            this.clbSubjects.TabIndex = 1;
            // 
            // NotificationFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.clbSubjects);
            this.Controls.Add(this.tbSearchBar);
            this.Name = "NotificationFilter";
            this.Size = new System.Drawing.Size(266, 118);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbSearchBar;
        private CheckedListBox clbSubjects;
    }
}
