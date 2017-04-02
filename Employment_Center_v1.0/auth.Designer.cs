namespace Employment_Center_v1._0
{
    partial class auth
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
            this.authbtn = new System.Windows.Forms.Button();
            this.regbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authbtn
            // 
            this.authbtn.Location = new System.Drawing.Point(21, 182);
            this.authbtn.Name = "authbtn";
            this.authbtn.Size = new System.Drawing.Size(75, 23);
            this.authbtn.TabIndex = 0;
            this.authbtn.Text = "button1";
            this.authbtn.UseVisualStyleBackColor = true;
            this.authbtn.Click += new System.EventHandler(this.authbtn_Click);
            // 
            // regbtn
            // 
            this.regbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.regbtn.Location = new System.Drawing.Point(102, 182);
            this.regbtn.Name = "regbtn";
            this.regbtn.Size = new System.Drawing.Size(75, 23);
            this.regbtn.TabIndex = 1;
            this.regbtn.Text = "button2";
            this.regbtn.UseVisualStyleBackColor = true;
            this.regbtn.Click += new System.EventHandler(this.regbtn_Click);
            // 
            // auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.regbtn);
            this.Controls.Add(this.authbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "auth";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button authbtn;
        private System.Windows.Forms.Button regbtn;
    }
}