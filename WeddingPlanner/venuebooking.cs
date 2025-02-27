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
    public partial class venuebooking : Form
    {
        SqlConnection conn = new SqlConnection(connect.constr);
        public venuebooking()
        {
            InitializeComponent();
        }
        public void clearData()
        {
            usercomboboxcs1.Controls.Clear();
            name.Controls.Clear();
            address.Controls.Clear();
            landmark.Controls.Clear();
            state.Controls.Clear();
            city.Controls.Clear();
            pincode.Controls.Clear();
        }

        private void UButton1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("ManageVenue", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("P_venue_name",name.Texts);
                cmd.Parameters.AddWithValue("p_venue_address",address.Texts);
                cmd.Parameters.AddWithValue("p_venue_landmark",landmark.Texts);
                cmd.Parameters.AddWithValue("P_venue_state", state.Texts);
                cmd.Parameters.AddWithValue("P_venue_city", city.Texts);
                cmd.Parameters.AddWithValue("P_venue_pincode",pincode.Texts);
                cmd.Parameters.AddWithValue("opr", "ins");

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Your data Is Successfully Inserted", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();

            }
            catch (Exception exc)
            {
                conn.Close();
                MessageBox.Show(exc.ToString(), "Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UButton2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ManageVenue", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("P_venue_name", name.Texts);
                cmd.Parameters.AddWithValue("p_venue_address", address.Texts);
                cmd.Parameters.AddWithValue("p_venue_landmark", landmark.Texts);
                cmd.Parameters.AddWithValue("P_venue_state", state.Texts);
                cmd.Parameters.AddWithValue("P_venue_city", city.Texts);
                cmd.Parameters.AddWithValue("P_venue_pincode", pincode.Texts);

                cmd.Parameters.Add("p_venueid", usercomboboxcs1.SelectedItem.ToString());
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
        public void bindCombo()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select venueid from venues", conn);
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

        private void Venuebooking_Load(object sender, EventArgs e)
        {
            bindCombo();
        }

        private void Usercomboboxcs1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select * from venues where venueid=@p_venueid", conn);
                cmd.Parameters.AddWithValue("@p_venueid", usercomboboxcs1.SelectedItem);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    name.Texts = dr.GetValue(1).ToString();
                    address.Texts = dr.GetValue(2).ToString();
                    landmark.Texts = dr.GetValue(3).ToString();
                    state.Texts = dr.GetValue(4).ToString();
                    city.Texts = dr.GetValue(5).ToString();
                    pincode.Texts = dr.GetValue(6).ToString();
                }
                conn.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void UButton3_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ManageVenue", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("p_venueid", usercomboboxcs1.SelectedItem.ToString());
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
                MessageBox.Show(ex.ToString());
            }
        }

        private void Name_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Address_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32 || e.KeyChar >= 65 && e.KeyChar <= 90 ||
                e.KeyChar == 8 || e.KeyChar >= 97 && e.KeyChar <= 122 || 
                e.KeyChar == 127||e.KeyChar>=48 && e.KeyChar<=57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Landmark_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32 || e.KeyChar >= 65 && e.KeyChar <= 90 ||
                   e.KeyChar == 8 || e.KeyChar >= 97 && e.KeyChar <= 122 ||
                   e.KeyChar == 127 || e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void State_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32 || e.KeyChar >= 65 && e.KeyChar <= 90 ||
                    e.KeyChar == 8 || e.KeyChar >= 97 && e.KeyChar <= 122 ||
                    e.KeyChar == 127)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void City_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32 || e.KeyChar >= 65 && e.KeyChar <= 90 ||
                  e.KeyChar == 8 || e.KeyChar >= 97 && e.KeyChar <= 122 ||
                  e.KeyChar == 127)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void Pincode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32 || e.KeyChar == 8 ||e.KeyChar == 127|| e.KeyChar >= 48 && e.KeyChar <= 57)
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
