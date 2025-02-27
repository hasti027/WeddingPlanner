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
    public partial class serivesform : Form
    {
        private string text;
        private int len = 0;

        SqlConnection conn = new SqlConnection(connect.constr);
        public serivesform()
        {
            InitializeComponent();
        }
        public void clearData()
        {
            name.Controls.Clear();
            price.Controls.Clear();
            usercomboboxcs1.Controls.Clear();

        }

        private void uButton1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("packageservicepro", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("servicename", name.Texts);
                cmd.Parameters.AddWithValue("price", price.Texts);

                cmd.Parameters.AddWithValue("opr", "ins");


                cmd.ExecuteNonQuery();


                MessageBox.Show("Your data Is Successfully Inserted", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();
                conn.Close();




            }
            catch (Exception exc)
            {

                conn.Close();
                MessageBox.Show(exc.ToString(), "Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void uButton2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("packageservicepro", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("servicename", name.Texts);
                cmd.Parameters.Add("price", price.Texts);

                cmd.Parameters.Add("pdestid", usercomboboxcs1.SelectedItem.ToString());
                cmd.Parameters.Add("opr", "upd");

                cmd.ExecuteNonQuery();

                clearData();

                MessageBox.Show("Your data Is Successfully Updated", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();

            }
            catch (Exception exc)
            {

                conn.Close();
                MessageBox.Show(exc.ToString(), "Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usercomboboxcs1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select * from packageservicetbl where pdestid=@pdestid", conn);
                cmd.Parameters.AddWithValue("@pdestid", usercomboboxcs1.SelectedItem);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    name.Texts = dr.GetValue(1).ToString();
                    price.Texts = dr.GetValue(2).ToString();


                }
                conn.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    
        }
        public void bindCombo()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select pdestid from packageservicetbl", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    usercomboboxcs1.Items.Add(dt.Rows[i][0].ToString());
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void uButton3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("packageservicepro", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("pdestid", usercomboboxcs1.SelectedItem.ToString());
                cmd.Parameters.Add("opr", "del");

                cmd.ExecuteNonQuery();

                clearData();

                MessageBox.Show("Your data Is Successfully Deleted", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();

                clearData();


            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString(), "Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void serivesform_Load(object sender, EventArgs e)
        {
            bindCombo();
            text = labletxt.Text;
            labletxt.Text = "";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (len < text.Length)
            {
                labletxt.Text = labletxt.Text + text.ElementAt(len);
                len++;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
     
    }
}
