namespace WeddingPlanner
{
    partial class password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(password));
            this.tabreset = new System.Windows.Forms.TabControl();
            this.tabemail = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnadd = new WeddingPlanner.UButton();
            this.email = new WeddingPlanner.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabotp = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.uButton1 = new WeddingPlanner.UButton();
            this.o6 = new WeddingPlanner.RJTextBox();
            this.o5 = new WeddingPlanner.RJTextBox();
            this.o4 = new WeddingPlanner.RJTextBox();
            this.o3 = new WeddingPlanner.RJTextBox();
            this.o2 = new WeddingPlanner.RJTextBox();
            this.o1 = new WeddingPlanner.RJTextBox();
            this.tabrespwd = new System.Windows.Forms.TabPage();
            this.uButton2 = new WeddingPlanner.UButton();
            this.rjTextBox7 = new WeddingPlanner.RJTextBox();
            this.rjTextBox6 = new WeddingPlanner.RJTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabreset.SuspendLayout();
            this.tabemail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabotp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabrespwd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabreset
            // 
            this.tabreset.Controls.Add(this.tabemail);
            this.tabreset.Controls.Add(this.tabotp);
            this.tabreset.Controls.Add(this.tabrespwd);
            this.tabreset.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabreset.Location = new System.Drawing.Point(2, 0);
            this.tabreset.Name = "tabreset";
            this.tabreset.SelectedIndex = 0;
            this.tabreset.Size = new System.Drawing.Size(824, 478);
            this.tabreset.TabIndex = 0;
            this.tabreset.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Tabreset_DrawItem);
            // 
            // tabemail
            // 
            this.tabemail.BackColor = System.Drawing.Color.White;
            this.tabemail.Controls.Add(this.button1);
            this.tabemail.Controls.Add(this.btnadd);
            this.tabemail.Controls.Add(this.email);
            this.tabemail.Controls.Add(this.label4);
            this.tabemail.Controls.Add(this.label2);
            this.tabemail.Controls.Add(this.label1);
            this.tabemail.Controls.Add(this.pictureBox1);
            this.tabemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(58)))), ((int)(((byte)(122)))));
            this.tabemail.Location = new System.Drawing.Point(4, 33);
            this.tabemail.Name = "tabemail";
            this.tabemail.Padding = new System.Windows.Forms.Padding(3);
            this.tabemail.Size = new System.Drawing.Size(816, 441);
            this.tabemail.TabIndex = 0;
            this.tabemail.Text = "Verify Email";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(772, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 42);
            this.button1.TabIndex = 110;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Transparent;
            this.btnadd.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnadd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.btnadd.BorderRadius = 40;
            this.btnadd.BorderSize = 3;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.btnadd.Location = new System.Drawing.Point(333, 374);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(148, 40);
            this.btnadd.TabIndex = 109;
            this.btnadd.Text = "Send OTP";
            this.btnadd.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.Btnadd_Click);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.White;
            this.email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.email.BorderSize = 4;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.email.Location = new System.Drawing.Point(378, 303);
            this.email.Multiline = false;
            this.email.Name = "email";
            this.email.Padding = new System.Windows.Forms.Padding(7);
            this.email.PasswordChar = false;
            this.email.Size = new System.Drawing.Size(250, 31);
            this.email.TabIndex = 94;
            this.email.Texts = "";
            this.email.UnderlinedStyle = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(138, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(527, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "You\'ve entered email field as the email address for your account\r\n      please ve" +
    "rify this email address by clicking button below.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic Semilight", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Verify your email address";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(300, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabotp
            // 
            this.tabotp.BackColor = System.Drawing.Color.White;
            this.tabotp.Controls.Add(this.linkLabel1);
            this.tabotp.Controls.Add(this.label6);
            this.tabotp.Controls.Add(this.label5);
            this.tabotp.Controls.Add(this.label3);
            this.tabotp.Controls.Add(this.pictureBox2);
            this.tabotp.Controls.Add(this.uButton1);
            this.tabotp.Controls.Add(this.o6);
            this.tabotp.Controls.Add(this.o5);
            this.tabotp.Controls.Add(this.o4);
            this.tabotp.Controls.Add(this.o3);
            this.tabotp.Controls.Add(this.o2);
            this.tabotp.Controls.Add(this.o1);
            this.tabotp.Location = new System.Drawing.Point(4, 33);
            this.tabotp.Name = "tabotp";
            this.tabotp.Padding = new System.Windows.Forms.Padding(3);
            this.tabotp.Size = new System.Drawing.Size(816, 441);
            this.tabotp.TabIndex = 1;
            this.tabotp.Text = "Verify OTP";
            this.tabotp.Click += new System.EventHandler(this.Tabotp_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(58)))), ((int)(((byte)(122)))));
            this.linkLabel1.Location = new System.Drawing.Point(450, 399);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(85, 24);
            this.linkLabel1.TabIndex = 111;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Resend";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.label6.Location = new System.Drawing.Point(286, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 21);
            this.label6.TabIndex = 110;
            this.label6.Text = "Didn\'t get the OTP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(263, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 42);
            this.label5.TabIndex = 2;
            this.label5.Text = " We have sent OTP to your e-mail,\r\n        please type code in here";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic Semilight", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(58)))), ((int)(((byte)(122)))));
            this.label3.Location = new System.Drawing.Point(316, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "OTP Verification";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(341, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 139);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // uButton1
            // 
            this.uButton1.BackColor = System.Drawing.Color.Transparent;
            this.uButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.uButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.uButton1.BorderRadius = 40;
            this.uButton1.BorderSize = 3;
            this.uButton1.FlatAppearance.BorderSize = 0;
            this.uButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.uButton1.Location = new System.Drawing.Point(341, 347);
            this.uButton1.Name = "uButton1";
            this.uButton1.Size = new System.Drawing.Size(148, 40);
            this.uButton1.TabIndex = 109;
            this.uButton1.Text = "Verify OTP";
            this.uButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.uButton1.UseVisualStyleBackColor = false;
            this.uButton1.Click += new System.EventHandler(this.UButton1_Click);
            // 
            // o6
            // 
            this.o6.BackColor = System.Drawing.Color.White;
            this.o6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.o6.BorderSize = 4;
            this.o6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.o6.Location = new System.Drawing.Point(531, 269);
            this.o6.Multiline = false;
            this.o6.Name = "o6";
            this.o6.Padding = new System.Windows.Forms.Padding(7);
            this.o6.PasswordChar = false;
            this.o6.Size = new System.Drawing.Size(43, 54);
            this.o6.TabIndex = 94;
            this.o6.Texts = "";
            this.o6.UnderlinedStyle = true;
            // 
            // o5
            // 
            this.o5.BackColor = System.Drawing.Color.White;
            this.o5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.o5.BorderSize = 4;
            this.o5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.o5.Location = new System.Drawing.Point(473, 269);
            this.o5.Multiline = false;
            this.o5.Name = "o5";
            this.o5.Padding = new System.Windows.Forms.Padding(7);
            this.o5.PasswordChar = false;
            this.o5.Size = new System.Drawing.Size(43, 54);
            this.o5.TabIndex = 93;
            this.o5.Texts = "";
            this.o5.UnderlinedStyle = true;
            // 
            // o4
            // 
            this.o4.BackColor = System.Drawing.Color.White;
            this.o4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.o4.BorderSize = 4;
            this.o4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.o4.Location = new System.Drawing.Point(415, 269);
            this.o4.Multiline = false;
            this.o4.Name = "o4";
            this.o4.Padding = new System.Windows.Forms.Padding(7);
            this.o4.PasswordChar = false;
            this.o4.Size = new System.Drawing.Size(43, 54);
            this.o4.TabIndex = 92;
            this.o4.Texts = "";
            this.o4.UnderlinedStyle = true;
            // 
            // o3
            // 
            this.o3.BackColor = System.Drawing.Color.White;
            this.o3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.o3.BorderSize = 4;
            this.o3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.o3.Location = new System.Drawing.Point(357, 269);
            this.o3.Multiline = false;
            this.o3.Name = "o3";
            this.o3.Padding = new System.Windows.Forms.Padding(7);
            this.o3.PasswordChar = false;
            this.o3.Size = new System.Drawing.Size(43, 54);
            this.o3.TabIndex = 91;
            this.o3.Texts = "";
            this.o3.UnderlinedStyle = true;
            // 
            // o2
            // 
            this.o2.BackColor = System.Drawing.Color.White;
            this.o2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.o2.BorderSize = 4;
            this.o2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.o2.Location = new System.Drawing.Point(299, 269);
            this.o2.Multiline = false;
            this.o2.Name = "o2";
            this.o2.Padding = new System.Windows.Forms.Padding(7);
            this.o2.PasswordChar = false;
            this.o2.Size = new System.Drawing.Size(43, 54);
            this.o2.TabIndex = 90;
            this.o2.Texts = "";
            this.o2.UnderlinedStyle = true;
            // 
            // o1
            // 
            this.o1.BackColor = System.Drawing.Color.White;
            this.o1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.o1.BorderSize = 4;
            this.o1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.o1.Location = new System.Drawing.Point(239, 269);
            this.o1.Multiline = false;
            this.o1.Name = "o1";
            this.o1.Padding = new System.Windows.Forms.Padding(7);
            this.o1.PasswordChar = false;
            this.o1.Size = new System.Drawing.Size(44, 54);
            this.o1.TabIndex = 89;
            this.o1.Texts = "";
            this.o1.UnderlinedStyle = true;
            this.o1.Enter += new System.EventHandler(this.O1_Enter);
            // 
            // tabrespwd
            // 
            this.tabrespwd.BackColor = System.Drawing.Color.White;
            this.tabrespwd.Controls.Add(this.uButton2);
            this.tabrespwd.Controls.Add(this.rjTextBox7);
            this.tabrespwd.Controls.Add(this.rjTextBox6);
            this.tabrespwd.Controls.Add(this.label8);
            this.tabrespwd.Controls.Add(this.label7);
            this.tabrespwd.Controls.Add(this.pictureBox3);
            this.tabrespwd.Location = new System.Drawing.Point(4, 33);
            this.tabrespwd.Name = "tabrespwd";
            this.tabrespwd.Padding = new System.Windows.Forms.Padding(3);
            this.tabrespwd.Size = new System.Drawing.Size(816, 441);
            this.tabrespwd.TabIndex = 2;
            this.tabrespwd.Text = "Reset Password";
            // 
            // uButton2
            // 
            this.uButton2.BackColor = System.Drawing.Color.Transparent;
            this.uButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.uButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.uButton2.BorderRadius = 40;
            this.uButton2.BorderSize = 3;
            this.uButton2.FlatAppearance.BorderSize = 0;
            this.uButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.uButton2.Location = new System.Drawing.Point(340, 388);
            this.uButton2.Name = "uButton2";
            this.uButton2.Size = new System.Drawing.Size(115, 40);
            this.uButton2.TabIndex = 109;
            this.uButton2.Text = "Reset";
            this.uButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.uButton2.UseVisualStyleBackColor = false;
            this.uButton2.Click += new System.EventHandler(this.UButton2_Click);
            // 
            // rjTextBox7
            // 
            this.rjTextBox7.BackColor = System.Drawing.Color.White;
            this.rjTextBox7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.rjTextBox7.BorderSize = 3;
            this.rjTextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.rjTextBox7.Location = new System.Drawing.Point(272, 331);
            this.rjTextBox7.Multiline = false;
            this.rjTextBox7.Name = "rjTextBox7";
            this.rjTextBox7.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rjTextBox7.PasswordChar = true;
            this.rjTextBox7.Size = new System.Drawing.Size(281, 31);
            this.rjTextBox7.TabIndex = 90;
            this.rjTextBox7.Texts = "Confirm Password";
            this.rjTextBox7.UnderlinedStyle = true;
            this.rjTextBox7.Enter += new System.EventHandler(this.RjTextBox7_Enter);
            this.rjTextBox7.Leave += new System.EventHandler(this.RjTextBox7_Leave);
            // 
            // rjTextBox6
            // 
            this.rjTextBox6.BackColor = System.Drawing.Color.White;
            this.rjTextBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.rjTextBox6.BorderSize = 3;
            this.rjTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.rjTextBox6.Location = new System.Drawing.Point(272, 279);
            this.rjTextBox6.Multiline = false;
            this.rjTextBox6.Name = "rjTextBox6";
            this.rjTextBox6.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rjTextBox6.PasswordChar = true;
            this.rjTextBox6.Size = new System.Drawing.Size(281, 31);
            this.rjTextBox6.TabIndex = 89;
            this.rjTextBox6.Texts = "New Password";
            this.rjTextBox6.UnderlinedStyle = true;
            this.rjTextBox6.Enter += new System.EventHandler(this.RjTextBox6_Enter);
            this.rjTextBox6.Leave += new System.EventHandler(this.RjTextBox6_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(185, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(416, 42);
            this.label8.TabIndex = 2;
            this.label8.Text = "Please choose a new password and enter it once in\r\n\t                     each fie" +
    "ld below..";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic Semilight", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(58)))), ((int)(((byte)(122)))));
            this.label7.Location = new System.Drawing.Point(312, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "Reset Pasword";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(318, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(157, 139);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(824, 477);
            this.Controls.Add(this.tabreset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "password";
            this.Load += new System.EventHandler(this.Password_Load);
            this.tabreset.ResumeLayout(false);
            this.tabemail.ResumeLayout(false);
            this.tabemail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabotp.ResumeLayout(false);
            this.tabotp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabrespwd.ResumeLayout(false);
            this.tabrespwd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabreset;
        private System.Windows.Forms.TabPage tabemail;
        private System.Windows.Forms.TabPage tabotp;
        private System.Windows.Forms.TabPage tabrespwd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private RJTextBox email;
        private UButton btnadd;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private RJTextBox o6;
        private RJTextBox o5;
        private RJTextBox o4;
        private RJTextBox o3;
        private RJTextBox o2;
        private RJTextBox o1;
        private UButton uButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private UButton uButton2;
        private RJTextBox rjTextBox7;
        private RJTextBox rjTextBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
    }
}