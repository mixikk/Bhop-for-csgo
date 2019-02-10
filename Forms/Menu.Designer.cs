namespace Bhop
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.BunnyhopCheck = new System.Windows.Forms.CheckBox();
            this.GithubBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BunnyhopCheck
            // 
            this.BunnyhopCheck.AutoSize = true;
            this.BunnyhopCheck.ForeColor = System.Drawing.Color.Snow;
            this.BunnyhopCheck.Location = new System.Drawing.Point(12, 18);
            this.BunnyhopCheck.Name = "BunnyhopCheck";
            this.BunnyhopCheck.Size = new System.Drawing.Size(119, 17);
            this.BunnyhopCheck.TabIndex = 2;
            this.BunnyhopCheck.Text = "Bunny Hop (Space)";
            this.BunnyhopCheck.UseVisualStyleBackColor = true;
            // 
            // GithubBTN
            // 
            this.GithubBTN.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.GithubBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GithubBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GithubBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GithubBTN.Location = new System.Drawing.Point(330, 18);
            this.GithubBTN.Name = "GithubBTN";
            this.GithubBTN.Size = new System.Drawing.Size(57, 26);
            this.GithubBTN.TabIndex = 4;
            this.GithubBTN.Text = "Github";
            this.GithubBTN.UseVisualStyleBackColor = false;
            this.GithubBTN.Click += new System.EventHandler(this.GithubBTN_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(389, 50);
            this.Controls.Add(this.GithubBTN);
            this.Controls.Add(this.BunnyhopCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Bunny Hop";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox BunnyhopCheck;
        private System.Windows.Forms.Button GithubBTN;
        private System.Windows.Forms.CheckBox ESPCheck;
    }
}

