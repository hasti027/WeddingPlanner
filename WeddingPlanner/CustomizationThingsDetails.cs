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
    public partial class CustomizationThingsDetails : Form
    {


        SqlConnection conn = new SqlConnection(connect.constr);
        public CustomizationThingsDetails()
        {
            InitializeComponent();
        }

        private void uButton1_Click(object sender, EventArgs e)
        {
            try
            {
               
               

                conn.Open();

                SqlCommand cmd = new SqlCommand("custompro", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("name", name1.Texts);
                cmd.Parameters.AddWithValue("sizeqty", sizeqty1.Texts);
                cmd.Parameters.AddWithValue("sizeqtymid", midtext.Texts);
                cmd.Parameters.AddWithValue("sizeqtylarge", large.Texts);
                cmd.Parameters.AddWithValue("price", price1.Texts);
                cmd.Parameters.AddWithValue("opr", "ins");

               
                SqlParameter outputIdParam = new SqlParameter();
                outputIdParam.ParameterName = "@id";
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
                MessageBox.Show(exc.ToString(), "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         public void clearData()
        {
            name1.Texts = null;
            sizeqty1.Texts = null;
            price1.Texts = null;
            midtext.Texts = null;
            large.Texts = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // if (len < text.Length)
            //{
            //    labletxt.Text = labletxt.Text + text.ElementAt(len);
            //    len++;
            //}
            //else
            //{
            //    timer1.Stop();
            //}
        }

        private void CustomizationThingsDetails_Load(object sender, EventArgs e)
        {
           
            bindCombo();
         
        }

        private void bindCombo()
        {
            try
            {
                // Clear ComboBox items before adding new ones
                usercomboboxcs1.Items.Clear();

                // Open connection only when needed
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT id FROM CustomizationTbl", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Add each ID to the ComboBox
                foreach (DataRow row in dt.Rows)
                {
                    usercomboboxcs1.Items.Add(row["id"].ToString());
                }

                conn.Close(); // Close connection after the data is loaded
            }
            catch (Exception ex)
            {
                conn.Close(); // Ensure the connection is closed on error
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        private void uButton3_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("custompro", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("name",  name1.Texts);
                cmd.Parameters.Add("sizeqtymin",sizeqty1.Texts);
                cmd.Parameters.AddWithValue("sizeqtymid", midtext.Texts);
                cmd.Parameters.AddWithValue("sizeqtylarge", large.Texts);
                cmd.Parameters.Add("price", price1.Texts);
                cmd.Parameters.Add("id", usercomboboxcs1.SelectedItem.ToString());
                cmd.Parameters.Add("opr", "upd");

                cmd.ExecuteNonQuery();

                clearData();

                MessageBox.Show("Your data Is Successfully Updated", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();

            }
            catch (Exception exc)
            {

                conn.Close();
                MessageBox.Show(exc.ToString(), "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void usercomboboxcs1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select * from CustomizationTbl where Id=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", usercomboboxcs1.SelectedItem);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    name1.Texts = dr.GetValue(1).ToString();
                    sizeqty1.Texts = dr.GetValue(2).ToString();
                    midtext.Texts = dr.GetValue(3).ToString();
                    large.Texts = dr.GetValue(4).ToString();
                    price1.Texts = dr.GetValue(5).ToString();

                }
                conn.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void uButton2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("custompro", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("name", name1.Texts);
                cmd.Parameters.AddWithValue("sizeqty", sizeqty1.Texts);
                cmd.Parameters.AddWithValue("sizeqtymid", midtext.Texts);
                cmd.Parameters.AddWithValue("sizeqtylarge", large.Texts);
                cmd.Parameters.AddWithValue("price", price1.Texts);
                cmd.Parameters.AddWithValue("id", usercomboboxcs1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("opr", "upd");

                cmd.ExecuteNonQuery();

                clearData();
                usercomboboxcs1.Texts = null;

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
                SqlCommand cmd = new SqlCommand("custompro", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("id", usercomboboxcs1.SelectedItem.ToString());
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

        private void Name1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Sizeqty1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32 || e.KeyChar >= 65 && e.KeyChar <= 90 ||
             e.KeyChar == 8 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar == 127
             ||e.KeyChar>=48 && e.KeyChar<=57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Midtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32 || e.KeyChar >= 65 && e.KeyChar <= 90 ||
           e.KeyChar == 8 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar == 127
           || e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Large_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32 || e.KeyChar >= 65 && e.KeyChar <= 90 ||
           e.KeyChar == 8 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar == 127
           || e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Price1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void UButton5_Click(object sender, EventArgs e)
        {
            usercomboboxcs1_OnSelectedIndexChanged(sender, e);
        }
    }
}
