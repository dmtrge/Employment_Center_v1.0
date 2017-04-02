namespace Employment_Center_v1._0
{
    partial class addvacantion
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
            this.addregbtn = new System.Windows.Forms.Button();
            this.addjobbox = new System.Windows.Forms.TextBox();
            this.addspecialitybox = new System.Windows.Forms.TextBox();
            this.addreqbox = new System.Windows.Forms.TextBox();
            this.addexpbox = new System.Windows.Forms.TextBox();
            this.addgraphbox = new System.Windows.Forms.TextBox();
            this.addsallarybox = new System.Windows.Forms.TextBox();
            this.addlocationbox = new System.Windows.Forms.TextBox();
            this.addaboutbox = new System.Windows.Forms.TextBox();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addregbtn
            // 
            this.addregbtn.Location = new System.Drawing.Point(106, 404);
            this.addregbtn.Name = "addregbtn";
            this.addregbtn.Size = new System.Drawing.Size(85, 23);
            this.addregbtn.TabIndex = 0;
            this.addregbtn.Text = "Регистрация";
            this.addregbtn.UseVisualStyleBackColor = true;
            this.addregbtn.Click += new System.EventHandler(this.addregbtn_Click);
            // 
            // addjobbox
            // 
            this.addjobbox.Location = new System.Drawing.Point(106, 12);
            this.addjobbox.Name = "addjobbox";
            this.addjobbox.Size = new System.Drawing.Size(210, 20);
            this.addjobbox.TabIndex = 1;
            // 
            // addspecialitybox
            // 
            this.addspecialitybox.Location = new System.Drawing.Point(106, 38);
            this.addspecialitybox.Name = "addspecialitybox";
            this.addspecialitybox.Size = new System.Drawing.Size(210, 20);
            this.addspecialitybox.TabIndex = 2;
            // 
            // addreqbox
            // 
            this.addreqbox.Location = new System.Drawing.Point(106, 64);
            this.addreqbox.Multiline = true;
            this.addreqbox.Name = "addreqbox";
            this.addreqbox.Size = new System.Drawing.Size(210, 56);
            this.addreqbox.TabIndex = 3;
            // 
            // addexpbox
            // 
            this.addexpbox.Location = new System.Drawing.Point(106, 126);
            this.addexpbox.Name = "addexpbox";
            this.addexpbox.Size = new System.Drawing.Size(210, 20);
            this.addexpbox.TabIndex = 4;
            // 
            // addgraphbox
            // 
            this.addgraphbox.Location = new System.Drawing.Point(106, 152);
            this.addgraphbox.Name = "addgraphbox";
            this.addgraphbox.Size = new System.Drawing.Size(210, 20);
            this.addgraphbox.TabIndex = 5;
            // 
            // addsallarybox
            // 
            this.addsallarybox.Location = new System.Drawing.Point(106, 178);
            this.addsallarybox.Name = "addsallarybox";
            this.addsallarybox.Size = new System.Drawing.Size(210, 20);
            this.addsallarybox.TabIndex = 6;
            // 
            // addlocationbox
            // 
            this.addlocationbox.Location = new System.Drawing.Point(106, 204);
            this.addlocationbox.Multiline = true;
            this.addlocationbox.Name = "addlocationbox";
            this.addlocationbox.Size = new System.Drawing.Size(210, 85);
            this.addlocationbox.TabIndex = 7;
            // 
            // addaboutbox
            // 
            this.addaboutbox.Location = new System.Drawing.Point(106, 295);
            this.addaboutbox.Multiline = true;
            this.addaboutbox.Name = "addaboutbox";
            this.addaboutbox.Size = new System.Drawing.Size(210, 84);
            this.addaboutbox.TabIndex = 8;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(197, 404);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 9;
            this.cancelbtn.Text = "Отмена";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // addvacantion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 568);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.addaboutbox);
            this.Controls.Add(this.addlocationbox);
            this.Controls.Add(this.addsallarybox);
            this.Controls.Add(this.addgraphbox);
            this.Controls.Add(this.addexpbox);
            this.Controls.Add(this.addreqbox);
            this.Controls.Add(this.addspecialitybox);
            this.Controls.Add(this.addjobbox);
            this.Controls.Add(this.addregbtn);
            this.Name = "addvacantion";
            this.Text = "addvacantion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addregbtn;
        private System.Windows.Forms.TextBox addjobbox;
        private System.Windows.Forms.TextBox addspecialitybox;
        private System.Windows.Forms.TextBox addreqbox;
        private System.Windows.Forms.TextBox addexpbox;
        private System.Windows.Forms.TextBox addgraphbox;
        private System.Windows.Forms.TextBox addsallarybox;
        private System.Windows.Forms.TextBox addlocationbox;
        private System.Windows.Forms.TextBox addaboutbox;
        private System.Windows.Forms.Button cancelbtn;
    }
}