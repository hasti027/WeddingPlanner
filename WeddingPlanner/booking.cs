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
using System.Text.RegularExpressions;

namespace WeddingPlanner
{
    public partial class booking : Form
    {
        SqlConnection conn = new SqlConnection(connect.constr);
        private const int MaxLength = 10;
        List<Location> locations;
        public booking()
        {
            InitializeComponent();
            locations = LocationData.GetLocations();
            foreach (var location in locations)
            {
                state.Items.Add(location.State);
            }
            state.SelectedIndexChanged += State_SelectedIndexChanged;
            city.SelectedIndexChanged += City_SelectedIndexChanged;

        }

        private void Insertbut_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("ManageCustomer1", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("customer_name", customer_name.Texts);
                cmd.Parameters.AddWithValue("mobile_number", mobile_number.Texts);
                cmd.Parameters.AddWithValue("alternate_mobile_number", alternate_mobile_number.Texts);
                cmd.Parameters.AddWithValue("email", email.Texts);
                cmd.Parameters.AddWithValue("address", address.Texts);
                cmd.Parameters.AddWithValue("landmark", landmark.Texts);
                cmd.Parameters.AddWithValue("state", state.Texts);
                cmd.Parameters.AddWithValue("city", city.Texts);
                cmd.Parameters.AddWithValue("pincode", pincode.Texts);
                cmd.Parameters.AddWithValue("eventdate", eventdate.Texts);

                cmd.Parameters.AddWithValue("opr", "ins");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your data Is Successfully Inserted", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();

                customer_name.ReadOnly = true;
                mobile_number.ReadOnly = true;
                alternate_mobile_number.ReadOnly = true;
                email.ReadOnly = true;
                address.ReadOnly = true;
                landmark.ReadOnly = true;
                pincode.ReadOnly = true;
                state.Enabled = false;
                city.Enabled = false;

            }
            catch (Exception exc)
            {

                conn.Close();
                MessageBox.Show(exc.ToString(), "Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

      

        private void Booking_Load(object sender, EventArgs e)
        {
            bindCombopackage_name();
            bindCombo1cusid();
            bindCombovenuename();
        }

        private void bindCombopackage_name()
        {

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select package_name from package_tbl order by package_name", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    usercomboboxcs2.Items.Add(dt.Rows[i][0].ToString());
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void bindCombo1cusid()
        {

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select cusId from CustomerInfo where cusId in (select cusid from Normal_package_customer)", conn);
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
        private void bindCombovenuename()
        {

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select venue_name from venues", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmbvenue.Items.Add(dt.Rows[i][0].ToString());
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }



        private void Cuid_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT c.cusId, c.customer_name, c.[mobile _number], c.alternate_mobile_number, c.email, c.addr, c.landmark, c.state, c.city, c.pincode,c.eventdate, p.p_id, p.package_name, p.package_price, p.discount, p.wedding_types, p.pic, p.capacity, v.venueid, v.venue_name, v.venue_address FROM Customerinfo c INNER JOIN Normal_package_customer n ON c.cusId = n.CusId INNER JOIN package_tbl p ON n.packageId = p.p_id INNER JOIN venues v ON n.venueid = v.venueid WHERE c.cusId ='"+usercomboboxcs1.SelectedItem.ToString()+"'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {                    
                    customer_name.Texts = dt.Rows[0]["customer_name"].ToString();
                    mobile_number.Texts = dt.Rows[0]["mobile _number"].ToString();
                    alternate_mobile_number.Texts = dt.Rows[0]["alternate_mobile_number"].ToString();
                    email.Texts = dt.Rows[0]["email"].ToString();
                    address.Texts = dt.Rows[0]["addr"].ToString();
                    landmark.Texts = dt.Rows[0]["landmark"].ToString();
                    state.Texts = dt.Rows[0]["state"].ToString();
                    city.Texts = dt.Rows[0]["city"].ToString();
                    pincode.Texts = dt.Rows[0]["pincode"].ToString();
                    usercomboboxcs2.SelectedItem = dt.Rows[0]["package_name"].ToString();
                    pictureBox1.ImageLocation = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + dt.Rows[0]["pic"].ToString();
                   // pictureBox1.ImageLocation =  dt.Rows[0]["pic"].ToString();
                    cmbvenue.SelectedItem = dt.Rows[0]["venue_name"].ToString();
                    eventdate.Texts = dt.Rows[0]["eventdate"].ToString();
                }
                else
                {
                    MessageBox.Show("No data found for the selected customer ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void Updatebut_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ManageCustomer1", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("customer_name", customer_name.Texts);
                cmd.Parameters.Add("mobile_number", mobile_number.Texts);
                cmd.Parameters.Add("alternate_mobile_number", alternate_mobile_number.Texts);
                cmd.Parameters.Add("email", email.Texts);
                cmd.Parameters.Add("address", address.Texts);
                cmd.Parameters.Add("landmark", landmark.Texts);
                cmd.Parameters.Add("state", state.Texts);
                cmd.Parameters.Add("city", city.Texts);
                cmd.Parameters.Add("pincode", pincode.Texts);
                cmd.Parameters.Add("eventdate", eventdate.Texts);
                cmd.Parameters.Add("cusId", usercomboboxcs1.SelectedItem.ToString());
                cmd.Parameters.Add("opr", "upd");
                cmd.ExecuteNonQuery();
                conn.Close();
               

                SqlDataAdapter da = new SqlDataAdapter("select p_id from package_tbl where package_name='" + usercomboboxcs2.SelectedItem.ToString() + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                string p_id = dt.Rows[0][0].ToString();

                SqlDataAdapter da1 = new SqlDataAdapter("select cusId from customerInfo where customer_name='" + customer_name.Texts + "' and email='" + email.Texts + "'", conn);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                string cus_id = dt1.Rows[0][0].ToString();

                SqlDataAdapter da2 = new SqlDataAdapter("select venueid from venues where venue_name='" + cmbvenue.SelectedItem.ToString() + "'", conn);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                string venueid = dt2.Rows[0][0].ToString();

                SqlDataAdapter da3 = new SqlDataAdapter("select id from Normal_package_customer where CusId='" + usercomboboxcs1.SelectedItem.ToString() + "'", conn);
                DataTable dt3  = new DataTable();
                da3.Fill(dt3);
                string id = dt3.Rows[0][0].ToString();

                string date = DateTime.Now.ToShortDateString();
                string time = DateTime.Now.ToShortTimeString();

                conn.Open();
                SqlCommand cmd1 = new SqlCommand("ManageNormalPackageCustomer", conn);
                cmd1.CommandType = CommandType.StoredProcedure;



                cmd1.Parameters.Add("cusId", cus_id);
                cmd1.Parameters.Add("packageId", p_id);
                cmd1.Parameters.Add("bookingdate", date);
                cmd1.Parameters.Add("bookingtime", time);
                cmd1.Parameters.Add("venueid", venueid);
                cmd1.Parameters.Add("id", id);
                cmd1.Parameters.Add("opr", "upd");
                cmd1.ExecuteNonQuery();


                MessageBox.Show("Your data Is Successfully Updated", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();

            }
            catch (Exception exc)
            {

                conn.Close();
                MessageBox.Show(exc.ToString(), "Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UButton1_Click(object sender, EventArgs e)
        {


            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select p_id from package_tbl where package_name='" + usercomboboxcs2.SelectedItem.ToString() + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                string p_id = dt.Rows[0][0].ToString();

                SqlDataAdapter da1 = new SqlDataAdapter("select cusId from customerInfo where customer_name='" + customer_name.Texts + "' and email='" + email.Texts + "'", conn);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                string cus_id = dt1.Rows[0][0].ToString();

                SqlDataAdapter da2 = new SqlDataAdapter("select venueid from venues where venue_name='" + cmbvenue.SelectedItem.ToString() + "'", conn);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                string venueid = dt2.Rows[0][0].ToString();

                string date = DateTime.Now.ToShortDateString();
                string time = DateTime.Now.ToShortTimeString();

                conn.Open();
                SqlCommand cmd = new SqlCommand("ManageNormalPackageCustomer", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("cusId", cus_id);
                cmd.Parameters.Add("packageId", p_id);
                cmd.Parameters.Add("bookingdate", date);
                cmd.Parameters.Add("bookingtime", time);
                cmd.Parameters.Add("venueid", venueid);
                cmd.Parameters.Add("opr", "ins");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your booking is successfully processed.", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString(), "Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Deletebut_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ManageCustomer1", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("cusId", usercomboboxcs1.SelectedItem.ToString());
                cmd.Parameters.Add("opr", "del");

                cmd.ExecuteNonQuery();
                conn.Close();

                SqlDataAdapter da = new SqlDataAdapter("select id from Normal_package_customer where CusId='" + usercomboboxcs1.SelectedItem.ToString() + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                string id = dt.Rows[0][0].ToString();

                conn.Open();
                SqlCommand cmd1 = new SqlCommand("manageNormalPackageCustomer", conn);
                cmd1.CommandType = CommandType.StoredProcedure;

                cmd1.Parameters.Add("id",id);
                cmd1.Parameters.Add("opr", "del");
                cmd1.ExecuteNonQuery();
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

        public void clearData()
        {
            customer_name.Texts = null;
            mobile_number.Texts = null;
            alternate_mobile_number.Texts = null;
            email.Texts = null;
            state.Texts = null;
            city.Texts = null;
            address.Texts = null;
            landmark.Texts = null;
            pincode.Texts = null;
            usercomboboxcs1.Items.Clear();
            usercomboboxcs2.Items.Clear();
            pricename.Texts = null;
            distxt.Texts = null;
            typestxt.Texts = null;
            pictureBox1.Image = null;
            captxt.Texts = null;
            cmbvenue.Texts = null;
            eventdate.Texts = null;

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

        private void Mobailtxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Altnumbertxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Emailtxt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar >= 65 && e.KeyChar <= 90 ||
                e.KeyChar == 8 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar == 127
                || e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 64 || e.KeyChar == 95)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Addresstxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Landmarktxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Statetxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Citytxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Pintxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32 || e.KeyChar == 8 || e.KeyChar == 127 || e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void mobailtxt_TextChanged(object sender, EventArgs e)
        {
            if (mobailtxt.Text.Length > MaxLength)
            {
                mobailtxt.Text = mobailtxt.Text.Substring(0, MaxLength);
                mobailtxt.SelectionStart = mobailtxt.Text.Length;
            }
        }

        private void Usercomboboxcs2_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from package_tbl where package_name=@package_name", conn);
                cmd.Parameters.AddWithValue("@package_name", usercomboboxcs2.SelectedItem);
                SqlDataReader dr = cmd.ExecuteReader();

                dr.Read();

                pricename.Texts = dr.GetValue(2).ToString();
                typetxt.Texts = dr.GetValue(3).ToString();
                distxt.Texts = dr.GetValue(4).ToString();
                pictureBox1.ImageLocation = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + dr.GetValue(5).ToString();
                captxt.Texts = dr.GetValue(6).ToString();
                conn.Close();


            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString(), "Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cmbvenue_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Customer_name_Load(object sender, EventArgs e)
        {

        }

        private void State_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            // Clear the current city items
            city.Items.Clear();

            // Get the selected state
            string selectedState = state.SelectedItem.ToString();

            // Find the location (state) and load its cities
            var location = locations.FirstOrDefault(l => l.State == selectedState);
            if (location != null)
            {
                foreach (var citys in location.Cities)
                {
                    city.Items.Add(citys.Name);
                }
                if (city.Items.Count > 0)
                {
                    city.SelectedIndex = 0;  // Automatically select the first city
                }
            }
            else
            {
                MessageBox.Show("No cities found for the selected state.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void City_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected state and city
            string selectedState = state.SelectedItem.ToString();
            string selectedCity = city.SelectedItem.ToString();

            if (string.IsNullOrEmpty(selectedState) || string.IsNullOrEmpty(selectedCity))
            {
                return;  // If no state or city is selected, exit
            }

            // Find the pincode of the selected city
            var location = locations.FirstOrDefault(l => l.State == selectedState);
            if (location != null)
            {
                var city = location.Cities.FirstOrDefault(c => c.Name == selectedCity);
                if (city != null)
                {
                    // Set the pincode in the TextBox
                    pincode.Texts = city.Pincode;
                }
            }
        }
    }
}