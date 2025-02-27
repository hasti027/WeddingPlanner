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
    public partial class resetpassword : Form
    {
        SqlConnection conn = new SqlConnection(connect.constr);
        public resetpassword()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            usercomboboxcs1.Items.Add("Change Username");
            usercomboboxcs1.Items.Add("Change Password");
        }

        private void UButton1_Click(object sender, EventArgs e)
        {
            string old = oldpass.Texts;
            string newpa = newpass.Texts;
            string reset = resetpass.Texts;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from loginform where uname='" + connect.unm + "' and psw='" + old + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    if (newpa == reset)
                    {
                        conn.Open();
                        string sql = "update loginform set psw='" + newpa + "' where psw='" + old + "' and uname='" + connect.unm + "'";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Password has been changed.");
                    }
                    else
                    {
                        MessageBox.Show("Password doesn't match");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect old password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        private void Oldpass_Enter(object sender, EventArgs e)
        {

            if (oldpass.Texts == "Old PassWord")
            {
                oldpass.Texts = "";
                oldpass.ForeColor = Color.DarkOrchid;
            }
        }

        private void Oldpass_Leave(object sender, EventArgs e)
        {
            if (oldpass.Texts == "")
            {
                oldpass.Texts = "Old PassWord";
                oldpass.ForeColor = Color.DarkOrchid;
            }
        }

        private void Newpass_Enter(object sender, EventArgs e)
        {
            if (newpass.Texts == "New PassWord")
            {
                newpass.Texts = "";
                newpass.ForeColor = Color.DarkOrchid;
            }

        }

        private void Newpass_Leave(object sender, EventArgs e)
        {

            if (newpass.Texts == "")
            {
                newpass.Texts = "New PassWord";
                newpass.ForeColor = Color.DarkOrchid;
            }

        }

        private void Resetpass_Enter(object sender, EventArgs e)
        {

            if (resetpass.Texts == "Reset PassWord")
            {
                resetpass.Texts = "";
                resetpass.ForeColor = Color.DarkOrchid;
            }

        }

        private void Resetpass_Leave(object sender, EventArgs e)
        {
            if (resetpass.Texts == "")
            {
                resetpass.Texts = "Reset PassWord";
                resetpass.ForeColor = Color.DarkOrchid;
            }
        }

        private void Usercomboboxcs1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (usercomboboxcs1.SelectedIndex == 0)
            {
                panel2.Visible = false;
                panel3.Visible = true;
            }
            else
            {

                panel2.Visible = true;
                panel3.Visible = false;

            }
        }
    }
}
