using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WeddingPlanner
{
    public partial class LoginForm : Form
    {
        SqlConnection conn = new SqlConnection(connect.constr);
        public LoginForm()
        {
            InitializeComponent();
        }
      
        private void rjTextBox1_Enter_1(object sender, EventArgs e)
        {
            if (rjTextBox1.Texts == "Username")
            {
                Color rgbColor = Color.FromArgb(168, 126, 176);
                rjTextBox1.Texts = "";
                rjTextBox1.ForeColor = rgbColor;
            }

        }
        private void rjTextBox2_Enter_1(object sender, EventArgs e)
        {
            if (rjTextBox2.Texts == "PassWord")
            {
                Color rgbColor = Color.FromArgb(168, 126, 176);
                rjTextBox2.Texts = "";
                rjTextBox2.ForeColor = rgbColor;
            }

        }

        private void rjTextBox1_Leave_1(object sender, EventArgs e)
        {
            if (rjTextBox1.Texts == "")
            {
                Color rgbColor = Color.FromArgb(168, 126, 176);
                rjTextBox1.Texts = "Username";
                rjTextBox1.ForeColor = rgbColor;
            }
        }

        private void rjTextBox2_Leave_1(object sender, EventArgs e)
        {
            if (rjTextBox2.Texts == "")
            {
                Color rgbColor = Color.FromArgb(168, 126, 176);
                rjTextBox2.Texts = "PassWord";
                rjTextBox2.ForeColor = rgbColor;
            }
        }

        private void rjTextBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32 || e.KeyChar >= 65 && e.KeyChar <= 90 ||
               e.KeyChar == 8 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar == 127)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void uButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (rjTextBox1 == null || rjTextBox2 == null)
                {
                    MessageBox.Show("Please Enter Your Username And Password");
                }
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from loginform where uname='" + rjTextBox1.Texts + "' and psw='" + rjTextBox2.Texts + "'", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    connect.unm = rjTextBox1.Texts;
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Welcome", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dashboard3 d = new dashboard3();
                        //connect.unm = rjTextBox1.Texts;
                        //resetpassword f1 = new resetpassword();
                        this.Hide();
                        d.Show();
                        //f1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect User", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            password pass = new password();
            pass.Show();
        }
    }
}

