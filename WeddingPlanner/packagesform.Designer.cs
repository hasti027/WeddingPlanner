namespace WeddingPlanner
{
    partial class packagesform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(packagesform));
            this.image = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labletxt = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.uButton3 = new WeddingPlanner.UButton();
            this.uButton2 = new WeddingPlanner.UButton();
            this.uButton1 = new WeddingPlanner.UButton();
            this.nametxt = new WeddingPlanner.RJTextBox();
            this.pricetxt = new WeddingPlanner.RJTextBox();
            this.typestxt = new WeddingPlanner.RJTextBox();
            this.distxt = new WeddingPlanner.RJTextBox();
            this.usercomboboxcs1 = new WeddingPlanner.usercomboboxcs();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.image.Location = new System.Drawing.Point(515, 370);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(250, 162);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 39;
            this.image.TabStop = false;
            this.image.Click += new System.EventHandler(this.image_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(362, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 38;
            this.label6.Text = "Image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(362, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 37;
            this.label5.Text = "Discount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(360, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 36;
            this.label4.Text = "Package Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(359, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "Wedding Types";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(359, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Package Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(360, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Package Name";
            // 
            // labletxt
            // 
            this.labletxt.AutoSize = true;
            this.labletxt.BackColor = System.Drawing.Color.Transparent;
            this.labletxt.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labletxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.labletxt.Location = new System.Drawing.Point(375, 60);
            this.labletxt.Name = "labletxt";
            this.labletxt.Size = new System.Drawing.Size(380, 37);
            this.labletxt.TabIndex = 32;
            this.labletxt.Text = "OUR PACKAGES SERVICES.....";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // uButton3
            // 
            this.uButton3.BackColor = System.Drawing.Color.Transparent;
            this.uButton3.BackgroundColor = System.Drawing.Color.Transparent;
            this.uButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.uButton3.BorderRadius = 40;
            this.uButton3.BorderSize = 3;
            this.uButton3.FlatAppearance.BorderSize = 0;
            this.uButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.uButton3.Location = new System.Drawing.Point(650, 570);
            this.uButton3.Name = "uButton3";
            this.uButton3.Size = new System.Drawing.Size(115, 40);
            this.uButton3.TabIndex = 8;
            this.uButton3.Text = "Delete";
            this.uButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.uButton3.UseVisualStyleBackColor = false;
            this.uButton3.Click += new System.EventHandler(this.uButton3_Click);
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
            this.uButton2.Location = new System.Drawing.Point(515, 570);
            this.uButton2.Name = "uButton2";
            this.uButton2.Size = new System.Drawing.Size(115, 40);
            this.uButton2.TabIndex = 7;
            this.uButton2.Text = "Update";
            this.uButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.uButton2.UseVisualStyleBackColor = false;
            this.uButton2.Click += new System.EventHandler(this.uButton2_Click);
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
            this.uButton1.Location = new System.Drawing.Point(375, 570);
            this.uButton1.Name = "uButton1";
            this.uButton1.Size = new System.Drawing.Size(115, 40);
            this.uButton1.TabIndex = 6;
            this.uButton1.Text = "Insert";
            this.uButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.uButton1.UseVisualStyleBackColor = false;
            this.uButton1.Click += new System.EventHandler(this.uButton1_Click);
            // 
            // nametxt
            // 
            this.nametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.nametxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.nametxt.BorderSize = 5;
            this.nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.nametxt.Location = new System.Drawing.Point(515, 175);
            this.nametxt.Multiline = false;
            this.nametxt.Name = "nametxt";
            this.nametxt.Padding = new System.Windows.Forms.Padding(7);
            this.nametxt.PasswordChar = false;
            this.nametxt.Size = new System.Drawing.Size(250, 31);
            this.nametxt.TabIndex = 45;
            this.nametxt.Texts = "";
            this.nametxt.UnderlinedStyle = true;
            this.nametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nametxt_KeyPress);
            // 
            // pricetxt
            // 
            this.pricetxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.pricetxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.pricetxt.BorderSize = 5;
            this.pricetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.pricetxt.Location = new System.Drawing.Point(515, 228);
            this.pricetxt.Multiline = false;
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Padding = new System.Windows.Forms.Padding(7);
            this.pricetxt.PasswordChar = false;
            this.pricetxt.Size = new System.Drawing.Size(250, 31);
            this.pricetxt.TabIndex = 46;
            this.pricetxt.Texts = "";
            this.pricetxt.UnderlinedStyle = true;
            this.pricetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pricetxt_KeyPress);
            // 
            // typestxt
            // 
            this.typestxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.typestxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.typestxt.BorderSize = 5;
            this.typestxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typestxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.typestxt.Location = new System.Drawing.Point(515, 276);
            this.typestxt.Multiline = false;
            this.typestxt.Name = "typestxt";
            this.typestxt.Padding = new System.Windows.Forms.Padding(7);
            this.typestxt.PasswordChar = false;
            this.typestxt.Size = new System.Drawing.Size(250, 31);
            this.typestxt.TabIndex = 47;
            this.typestxt.Texts = "";
            this.typestxt.UnderlinedStyle = true;
            this.typestxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Typestxt_KeyPress);
            // 
            // distxt
            // 
            this.distxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.distxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.distxt.BorderSize = 5;
            this.distxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.distxt.Location = new System.Drawing.Point(515, 320);
            this.distxt.Multiline = false;
            this.distxt.Name = "distxt";
            this.distxt.Padding = new System.Windows.Forms.Padding(7);
            this.distxt.PasswordChar = false;
            this.distxt.Size = new System.Drawing.Size(250, 31);
            this.distxt.TabIndex = 48;
            this.distxt.Texts = "";
            this.distxt.UnderlinedStyle = true;
            this.distxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Distxt_KeyPress);
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
            this.usercomboboxcs1.Location = new System.Drawing.Point(515, 136);
            this.usercomboboxcs1.MinimumSize = new System.Drawing.Size(200, 30);
            this.usercomboboxcs1.Name = "usercomboboxcs1";
            this.usercomboboxcs1.Padding = new System.Windows.Forms.Padding(2);
            this.usercomboboxcs1.Size = new System.Drawing.Size(250, 30);
            this.usercomboboxcs1.TabIndex = 49;
            this.usercomboboxcs1.Texts = "";
            this.usercomboboxcs1.UnderlinedStyle = true;
            this.usercomboboxcs1.OnSelectedIndexChanged += new System.EventHandler(this.usercomboboxcs1_OnSelectedIndexChanged);
            // 
            // packagesform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.usercomboboxcs1);
            this.Controls.Add(this.distxt);
            this.Controls.Add(this.typestxt);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.uButton3);
            this.Controls.Add(this.uButton2);
            this.Controls.Add(this.uButton1);
            this.Controls.Add(this.image);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labletxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "packagesform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "packagesform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.packagesform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labletxt;
        private UButton uButton1;
        private UButton uButton2;
        private UButton uButton3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private RJTextBox nametxt;
        private RJTextBox pricetxt;
        private RJTextBox typestxt;
        private RJTextBox distxt;
        private usercomboboxcs usercomboboxcs1;

    }
}