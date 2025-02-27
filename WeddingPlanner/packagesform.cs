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
using System.IO;

namespace WeddingPlanner
{
    public partial class packagesform : Form
    {
        SqlConnection conn = new SqlConnection(connect.constr);
        public packagesform()
        {
            InitializeComponent();
        }
        public void clearData()
        {
            usercomboboxcs1.Texts = null;
            nametxt.Texts = null;
            pricetxt.Texts = null;
            typestxt.Texts = null;
            distxt.Texts = null;
            image.ImageLocation = "";
        }

        private void uButton1_Click(object sender, EventArgs e)
        {
            try
            {

                File.Copy(image.ImageLocation, Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "/images/" + openFileDialog1.SafeFileName);

                conn.Open();

                SqlCommand cmd = new SqlCommand("packagepro", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("package_name", nametxt.Texts);
                cmd.Parameters.AddWithValue("package_price", pricetxt.Texts);
                cmd.Parameters.AddWithValue("wedding_types", typestxt.Texts);
                cmd.Parameters.AddWithValue("discount", distxt.Texts);
                cmd.Parameters.AddWithValue("pic", "/images/" + openFileDialog1.SafeFileName);
                cmd.Parameters.AddWithValue("opr", "ins");

                SqlParameter outputIdParam = new SqlParameter();
                outputIdParam.ParameterName = "@p_id";
                outputIdParam.SqlDbType = SqlDbType.Int;
                outputIdParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outputIdParam);

                cmd.ExecuteNonQuery();


                int insertedId = (int)outputIdParam.Value;
                MessageBox.Show("Data Inserted Successfully. Inserted ID: " + insertedId);

                conn.Close();

                clearData();


                bindCombo();

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
                SqlCommand cmd = new SqlCommand("packagepro", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("package_name", nametxt.Texts);
                cmd.Parameters.AddWithValue("package_price", pricetxt.Texts);
                cmd.Parameters.AddWithValue("wedding_types", typestxt.Texts);
                cmd.Parameters.AddWithValue("discount", distxt.Texts);
                cmd.Parameters.AddWithValue("pic", "/images/" + openFileDialog1.SafeFileName);

                cmd.Parameters.AddWithValue("p_id",usercomboboxcs1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("opr", "upd");

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

        private void uButton3_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("packagepro", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("p_id", usercomboboxcs1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("opr", "del");

                cmd.ExecuteNonQuery();

                clearData();

                MessageBox.Show("Your data Is Successfully Deleted", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();

                clearData();

                usercomboboxcs1.Items.Clear();
                bindCombo();


            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString(), "Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usercomboboxcs1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select * from package_tbl where p_id=@p_id", conn);
                cmd.Parameters.AddWithValue("@p_id",usercomboboxcs1.SelectedItem);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    nametxt.Texts = dr.GetValue(1).ToString();
                    pricetxt.Texts = dr.GetValue(2).ToString();
                    typestxt.Texts = dr.GetValue(3).ToString();
                    distxt.Texts = dr.GetValue(4).ToString();
                    image.ImageLocation = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + dr.GetValue(5).ToString();
                }
                conn.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            image.ImageLocation = openFileDialog1.FileName;
        }

        private void image_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        public void bindCombo()
        {
           
            //try
            //{
            //    usercomboboxcs1.Items.Clear();
            //    if (conn.State == ConnectionState.Closed)
            //        conn.Open();

            //    SqlDataAdapter da = new SqlDataAdapter("select p_id from package_tbl", conn);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    foreach (DataRow row in dt.Rows)
            //    {
            //        usercomboboxcs1.Items.Add(row["p_id"].ToString());
            //    }

            //    conn.Close(); 
            //}
            //catch (Exception ex)
            //{
            //    conn.Close(); 
            //    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            try
            {
                usercomboboxcs1.Items.Clear();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlDataAdapter da = new SqlDataAdapter("select p_id from package_tbl", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                MessageBox.Show("Rows retrieved: " + dt.Rows.Count); // Debugging line

                foreach (DataRow row in dt.Rows)
                {
                    usercomboboxcs1.Items.Add(row["p_id"].ToString());
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void packagesform_Load(object sender, EventArgs e)
        {

            bindCombo();
        }

        private void Nametxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Pricetxt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar>=48 && e.KeyChar<=57|| e.KeyChar == 32 || e.KeyChar == 127 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void Typestxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Distxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 32 || e.KeyChar == 127 || e.KeyChar == 8)
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
