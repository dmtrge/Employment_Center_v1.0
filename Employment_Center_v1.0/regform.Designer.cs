namespace Employment_Center_v1._0
{
    partial class regform
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
            this.addloginbox = new System.Windows.Forms.TextBox();
            this.addpasswdbox = new System.Windows.Forms.TextBox();
            this.addfiobox = new System.Windows.Forms.TextBox();
            this.addcompanybox = new System.Windows.Forms.TextBox();
            this.addregbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addloginbox
            // 
            this.addloginbox.Location = new System.Drawing.Point(92, 33);
            this.addloginbox.Name = "addloginbox";
            this.addloginbox.Size = new System.Drawing.Size(100, 20);
            this.addloginbox.TabIndex = 0;
            // 
            // addpasswdbox
            // 
            this.addpasswdbox.Location = new System.Drawing.Point(92, 59);
            this.addpasswdbox.Name = "addpasswdbox";
            this.addpasswdbox.Size = new System.Drawing.Size(100, 20);
            this.addpasswdbox.TabIndex = 1;
            // 
            // addfiobox
            // 
            this.addfiobox.Location = new System.Drawing.Point(92, 85);
            this.addfiobox.Name = "addfiobox";
            this.addfiobox.Size = new System.Drawing.Size(100, 20);
            this.addfiobox.TabIndex = 2;
            // 
            // addcompanybox
            // 
            this.addcompanybox.Location = new System.Drawing.Point(92, 111);
            this.addcompanybox.Name = "addcompanybox";
            this.addcompanybox.Size = new System.Drawing.Size(100, 20);
            this.addcompanybox.TabIndex = 3;
            // 
            // addregbtn
            // 
            this.addregbtn.Location = new System.Drawing.Point(41, 166);
            this.addregbtn.Name = "addregbtn";
            this.addregbtn.Size = new System.Drawing.Size(84, 23);
            this.addregbtn.TabIndex = 4;
            this.addregbtn.Text = "Регистрация";
            this.addregbtn.UseVisualStyleBackColor = true;
            this.addregbtn.Click += new System.EventHandler(this.addregbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ФИО";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Предприятие";
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(131, 166);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 9;
            this.cancelbtn.Text = "Отмена";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // regform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 225);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addregbtn);
            this.Controls.Add(this.addcompanybox);
            this.Controls.Add(this.addfiobox);
            this.Controls.Add(this.addpasswdbox);
            this.Controls.Add(this.addloginbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "regform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "regform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addloginbox;
        private System.Windows.Forms.TextBox addpasswdbox;
        private System.Windows.Forms.TextBox addfiobox;
        private System.Windows.Forms.TextBox addcompanybox;
        private System.Windows.Forms.Button addregbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelbtn;
    }
}