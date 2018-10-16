namespace SignIn
{
    partial class StudentSignInWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentSignInWindow));
            this.txtEntryBox = new System.Windows.Forms.TextBox();
            this.lblSuccessMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEntryBox
            // 
            this.txtEntryBox.AcceptsReturn = true;
            this.txtEntryBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEntryBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEntryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntryBox.Location = new System.Drawing.Point(302, 578);
            this.txtEntryBox.Name = "txtEntryBox";
            this.txtEntryBox.Size = new System.Drawing.Size(471, 62);
            this.txtEntryBox.TabIndex = 0;
            this.txtEntryBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEntryBox.TextChanged += new System.EventHandler(this.txtEntryBox_TextChanged);
            // 
            // lblSuccessMessage
            // 
            this.lblSuccessMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSuccessMessage.AutoSize = true;
            this.lblSuccessMessage.BackColor = System.Drawing.Color.Cornsilk;
            this.lblSuccessMessage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccessMessage.Location = new System.Drawing.Point(306, 480);
            this.lblSuccessMessage.Name = "lblSuccessMessage";
            this.lblSuccessMessage.Size = new System.Drawing.Size(0, 55);
            this.lblSuccessMessage.TabIndex = 1;
            this.lblSuccessMessage.Visible = false;
            // 
            // StudentSignInWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.lblSuccessMessage);
            this.Controls.Add(this.txtEntryBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentSignInWindow";
            this.Text = "Student Sign In Window";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntryBox;
        private System.Windows.Forms.Label lblSuccessMessage;
    }
}

