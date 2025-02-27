namespace WeddingPlanner
{
    partial class resetpassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(resetpassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.resetpass = new WeddingPlanner.RJTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.oldpass = new WeddingPlanner.RJTextBox();
            this.newpass = new WeddingPlanner.RJTextBox();
            this.uButton1 = new WeddingPlanner.UButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.usercomboboxcs1 = new WeddingPlanner.usercomboboxcs();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rjTextBox1 = new WeddingPlanner.RJTextBox();
            this.rjTextBox2 = new WeddingPlanner.RJTextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.rjTextBox3 = new WeddingPlanner.RJTextBox();
            this.uButton2 = new WeddingPlanner.UButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.usercomboboxcs1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(267, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 457);
            this.panel1.TabIndex = 1;
            // 
            // resetpass
            // 
            this.resetpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(236)))), ((int)(((byte)(242)))));
            this.resetpass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(145)))), ((int)(((byte)(204)))));
            this.resetpass.BorderSize = 5;
            this.resetpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(145)))), ((int)(((byte)(204)))));
            this.resetpass.Location = new System.Drawing.Point(78, 143);
            this.resetpass.Multiline = false;
            this.resetpass.Name = "resetpass";
            this.resetpass.Padding = new System.Windows.Forms.Padding(7);
            this.resetpass.PasswordChar = false;
            this.resetpass.Size = new System.Drawing.Size(187, 32);
            this.resetpass.TabIndex = 18;
            this.resetpass.Texts = "Reset PassWord";
            this.resetpass.UnderlinedStyle = true;
            this.resetpass.Enter += new System.EventHandler(this.Resetpass_Enter);
            this.resetpass.Leave += new System.EventHandler(this.Resetpass_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(26, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 31);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // oldpass
            // 
            this.oldpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(236)))), ((int)(((byte)(242)))));
            this.oldpass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(145)))), ((int)(((byte)(204)))));
            this.oldpass.BorderSize = 5;
            this.oldpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(145)))), ((int)(((byte)(204)))));
            this.oldpass.Location = new System.Drawing.Point(78, 25);
            this.oldpass.Multiline = false;
            this.oldpass.Name = "oldpass";
            this.oldpass.Padding = new System.Windows.Forms.Padding(7);
            this.oldpass.PasswordChar = false;
            this.oldpass.Size = new System.Drawing.Size(187, 32);
            this.oldpass.TabIndex = 16;
            this.oldpass.Texts = "Old PassWord";
            this.oldpass.UnderlinedStyle = true;
            this.oldpass.Enter += new System.EventHandler(this.Oldpass_Enter);
            this.oldpass.Leave += new System.EventHandler(this.Oldpass_Leave);
            // 
            // newpass
            // 
            this.newpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(236)))), ((int)(((byte)(242)))));
            this.newpass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(145)))), ((int)(((byte)(204)))));
            this.newpass.BorderSize = 5;
            this.newpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(145)))), ((int)(((byte)(204)))));
            this.newpass.Location = new System.Drawing.Point(78, 84);
            this.newpass.Multiline = false;
            this.newpass.Name = "newpass";
            this.newpass.Padding = new System.Windows.Forms.Padding(7);
            this.newpass.PasswordChar = false;
            this.newpass.Size = new System.Drawing.Size(187, 32);
            this.newpass.TabIndex = 14;
            this.newpass.Texts = "New PassWord";
            this.newpass.UnderlinedStyle = true;
            this.newpass.Enter += new System.EventHandler(this.Newpass_Enter);
            this.newpass.Leave += new System.EventHandler(this.Newpass_Leave);
            // 
            // uButton1
            // 
            this.uButton1.BackColor = System.Drawing.Color.Transparent;
            this.uButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.uButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(145)))), ((int)(((byte)(204)))));
            this.uButton1.BorderRadius = 40;
            this.uButton1.BorderSize = 3;
            this.uButton1.FlatAppearance.BorderSize = 0;
            this.uButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.uButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(145)))), ((int)(((byte)(204)))));
            this.uButton1.Location = new System.Drawing.Point(69, 198);
            this.uButton1.Name = "uButton1";
            this.uButton1.Size = new System.Drawing.Size(150, 34);
            this.uButton1.TabIndex = 9;
            this.uButton1.Text = "Submit";
            this.uButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(145)))), ((int)(((byte)(204)))));
            this.uButton1.UseVisualStyleBackColor = false;
            this.uButton1.Click += new System.EventHandler(this.UButton1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(26, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 31);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(26, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 31);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(157)))), ((int)(((byte)(213)))));
            this.label2.Location = new System.Drawing.Point(59, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Let\'s Plan Your Life Time Memory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(157)))), ((int)(((byte)(213)))));
            this.label1.Location = new System.Drawing.Point(84, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Change credentials";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.resetpass);
            this.panel2.Controls.Add(this.oldpass);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.newpass);
            this.panel2.Controls.Add(this.uButton1);
            this.panel2.Location = new System.Drawing.Point(52, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 241);
            this.panel2.TabIndex = 2;
            // 
            // usercomboboxcs1
            // 
            this.usercomboboxcs1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.usercomboboxcs1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.usercomboboxcs1.BorderSize = 2;
            this.usercomboboxcs1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.usercomboboxcs1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.usercomboboxcs1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.usercomboboxcs1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.usercomboboxcs1.ListBackColor = System.Drawing.Color.White;
            this.usercomboboxcs1.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.usercomboboxcs1.Location = new System.Drawing.Point(121, 146);
            this.usercomboboxcs1.MinimumSize = new System.Drawing.Size(200, 30);
            this.usercomboboxcs1.Name = "usercomboboxcs1";
            this.usercomboboxcs1.Padding = new System.Windows.Forms.Padding(2);
            this.usercomboboxcs1.Size = new System.Drawing.Size(200, 30);
            this.usercomboboxcs1.TabIndex = 50;
            this.usercomboboxcs1.Texts = "";
            this.usercomboboxcs1.UnderlinedStyle = true;
            this.usercomboboxcs1.OnSelectedIndexChanged += new System.EventHandler(this.Usercomboboxcs1_OnSelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.rjTextBox1);
            this.panel3.Controls.Add(this.rjTextBox2);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.pictureBox6);
            this.panel3.Controls.Add(this.rjTextBox3);
            this.panel3.Controls.Add(this.uButton2);
            this.panel3.Location = new System.Drawing.Point(52, 182);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(282, 241);
            this.panel3.TabIndex = 3;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(236)))), ((int)(((byte)(242)))));
            this.rjTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(145)))), ((int)(((byte)(204)))));
            this.rjTextBox1.BorderSize = 5;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(145)))), ((int)(((byte)(204)))));
            this.rjTextBox1.Location = new System.Drawing.Point(78, 143);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.Size = new System.Drawing.Size(187, 32);
            this.rjTextBox1.TabIndex = 18;
            this.rjTextBox1.Texts = "PassWord";
            this.rjTextBox1.UnderlinedStyle = true;
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(236)))), ((int)(((byte)(242)))));
            this.rjTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(145)))), ((int)(((byte)(204)))));
            this.rjTextBox2.BorderSize = 5;
            this.rjTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(145)))), ((int)(((byte)(204)))));
            this.rjTextBox2.Location = new System.Drawing.Point(78, 25);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.Size = new System.Drawing.Size(187, 32);
            this.rjTextBox2.TabIndex = 16;
            this.rjTextBox2.Texts = "Current Username";
            this.rjTextBox2.UnderlinedStyle = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(26, 25);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 31);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(26, 84);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 31);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(26, 143);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 31);
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // rjTextBox3
            // 
            this.rjTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(236)))), ((int)(((byte)(242)))));
            this.rjTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(145)))), ((int)(((byte)(204)))));
            this.rjTextBox3.BorderSize = 5;
            this.rjTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(145)))), ((int)(((byte)(204)))));
            this.rjTextBox3.Location = new System.Drawing.Point(78, 84);
            this.rjTextBox3.Multiline = false;
            this.rjTextBox3.Name = "rjTextBox3";
            this.rjTextBox3.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox3.PasswordChar = false;
            this.rjTextBox3.Size = new System.Drawing.Size(187, 32);
            this.rjTextBox3.TabIndex = 14;
            this.rjTextBox3.Texts = "New Username";
            this.rjTextBox3.UnderlinedStyle = true;
            // 
            // uButton2
            // 
            this.uButton2.BackColor = System.Drawing.Color.Transparent;
            this.uButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.uButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(145)))), ((int)(((byte)(204)))));
            this.uButton2.BorderRadius = 40;
            this.uButton2.BorderSize = 3;
            this.uButton2.FlatAppearance.BorderSize = 0;
            this.uButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.uButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(145)))), ((int)(((byte)(204)))));
            this.uButton2.Location = new System.Drawing.Point(69, 198);
            this.uButton2.Name = "uButton2";
            this.uButton2.Size = new System.Drawing.Size(150, 34);
            this.uButton2.TabIndex = 9;
            this.uButton2.Text = "Submit";
            this.uButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(145)))), ((int)(((byte)(204)))));
            this.uButton2.UseVisualStyleBackColor = false;
            // 
            // resetpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(201)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1316, 788);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "resetpassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RJTextBox newpass;
        private UButton uButton1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RJTextBox oldpass;
        private System.Windows.Forms.PictureBox pictureBox3;
        private RJTextBox resetpass;
        private System.Windows.Forms.Panel panel2;
        private usercomboboxcs usercomboboxcs1;
        private System.Windows.Forms.Panel panel3;
        private RJTextBox rjTextBox1;
        private RJTextBox rjTextBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private RJTextBox rjTextBox3;
        private UButton uButton2;
    }
}