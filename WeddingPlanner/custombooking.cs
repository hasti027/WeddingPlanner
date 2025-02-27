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
    public partial class custombooking : Form
    {
        SqlConnection conn = new SqlConnection(connect.constr);
        List<Location> locations;

        public custombooking()
        {
            InitializeComponent();
            locations = LocationData.GetLocations();
            foreach (var location in locations)
            {
                usercomboboxcs4.Items.Add(location.State);
            }
            usercomboboxcs4.SelectedIndexChanged += Usercomboboxcs4_SelectedIndexChanged;
            usercomboboxcs5.SelectedIndexChanged += Usercomboboxcs5_SelectedIndexChanged;
        }
        static int sno;
        private void Btnadd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(++sno, usercomboboxcs2.SelectedItem, qty.Texts, pr.Texts);
        }

        private void Custombooking_Load(object sender, EventArgs e)
        {
            bindComboVenue();
            bindCombo1Name();
        
            bindCombo4orderid();
        }

        private void bindComboVenue()
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
        private void bindCombo1Name()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select name from CustomizationTbl", conn);
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
       
        private void bindCombo2cuid()
        {
            try
            {
                usercomboboxcs1.Items.Clear();
                SqlDataAdapter da = new SqlDataAdapter("select distinct cusId from Custom_package_customer where orderid="+usercomboboxcs6.Texts, conn);
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

        private void bindCombo4orderid()
        {
            try
            {
                usercomboboxcs6.Items.Clear();
                SqlDataAdapter da = new SqlDataAdapter("select distinct orderId from Custom_package_customer", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    usercomboboxcs6.Items.Add(dt.Rows[i][0].ToString());
                }
                usercomboboxcs6.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }
        private void UButton4_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ManageCustomer1", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@customer_name", customer_name.Texts);
                cmd.Parameters.AddWithValue("@mobile_number", mobile_number.Texts);
                cmd.Parameters.AddWithValue("@alternate_mobile_number", alternate_mobile_number.Texts);
                cmd.Parameters.AddWithValue("@email", email.Texts);
                cmd.Parameters.AddWithValue("@address", address.Texts);
                cmd.Parameters.AddWithValue("@landmark", landmark.Texts);
                cmd.Parameters.AddWithValue("@state", usercomboboxcs4.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@city", usercomboboxcs5.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@pincode", pincode.Texts);
                cmd.Parameters.AddWithValue("@eventdate", eventdate.Texts);
                cmd.Parameters.AddWithValue("@opr", "ins");
                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("SELECT cusId FROM customerinfo WHERE customer_name = @customer_name AND email = @email", conn);
                cmd2.Parameters.AddWithValue("@customer_name", customer_name.Texts);
                cmd2.Parameters.AddWithValue("@email", email.Texts);
                object result = cmd2.ExecuteScalar();
                string cusId = result != null ? result.ToString() : null;

                if (string.IsNullOrEmpty(cusId))
                {
                    throw new Exception("Customer ID not found.");
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string customPackID;
                    using (SqlCommand cmd3 = new SqlCommand("SELECT Id FROM CustomizationTbl WHERE name = @name", conn))
                    {
                        cmd3.Parameters.AddWithValue("@name", dataGridView1.Rows[i].Cells[1].Value.ToString());
                        object result3 = cmd3.ExecuteScalar();
                        customPackID = result3 != null ? result3.ToString() : null;
                    }

                    if (string.IsNullOrEmpty(customPackID))
                    {
                        throw new Exception("Customization ID not found.");
                    }

                    string venueId;
                    using (SqlCommand cmd4 = new SqlCommand("SELECT venueid FROM venues WHERE venue_name = @venue_name", conn))
                    {
                        cmd4.Parameters.AddWithValue("@venue_name", cmbvenue.SelectedItem.ToString());
                        object result4 = cmd4.ExecuteScalar();
                        venueId = result4 != null ? result4.ToString() : null;
                    }

                    if (string.IsNullOrEmpty(venueId))
                    {
                        throw new Exception("Venue ID not found.");
                    }

                    string date = DateTime.Now.ToShortDateString();
                    string time = DateTime.Now.ToShortTimeString();
                    Random random = new Random();
                    int oid = random.Next();

                    decimal price;

                    if (!decimal.TryParse(dataGridView1.Rows[i].Cells[3].Value.ToString(), out price))
                    {
                        throw new Exception("Price must be a valid decimal.");
                    }
                    using (SqlCommand cmd5 = new SqlCommand("ManageCustomPackageCustomer", conn))
                    {
                        cmd5.CommandType = CommandType.StoredProcedure;
                        cmd5.Parameters.AddWithValue("@cusId", cusId);
                        cmd5.Parameters.AddWithValue("@customPackID", customPackID);
                        cmd5.Parameters.AddWithValue("@orderId", oid);
                        cmd5.Parameters.AddWithValue("@qty", dataGridView1.Rows[i].Cells[2].Value.ToString());
                        cmd5.Parameters.AddWithValue("@price", price);
                        cmd5.Parameters.AddWithValue("@bookingdate", date);
                        cmd5.Parameters.AddWithValue("@bookingtime", time);
                        cmd5.Parameters.AddWithValue("@venueId", venueId);
                        cmd5.Parameters.AddWithValue("@opr", "ins");
                        cmd5.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Your booking is successfully processed.", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                customer_name.ReadOnly = true;
                mobile_number.ReadOnly = true;
                alternate_mobile_number.ReadOnly = true;
                email.ReadOnly = true;
                address.ReadOnly = true;
                landmark.ReadOnly = true;
                //  usercomboboxcs4.ReadOnly = true;
                //usercomboboxcs5.ReadOnly = true;
                pincode.ReadOnly = true;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void Cmbvenue_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from venues where venue_name=@venue_name", conn);
                cmd.Parameters.AddWithValue("@venue_name", cmbvenue.SelectedItem);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    eventdate.Texts = dr.GetValue(2).ToString();

                }
                conn.Close();
                cmd.Dispose();


            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString(), "Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UButton2_Click(object sender, EventArgs e)
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
                cmd.Parameters.Add("state", usercomboboxcs4.SelectedItem.ToString());
                cmd.Parameters.Add("city", usercomboboxcs5.SelectedItem.ToString());
                cmd.Parameters.Add("pincode", pincode.Texts);
                cmd.Parameters.Add("eventdate", eventdate.Texts);
                cmd.Parameters.Add("cusId", usercomboboxcs1.SelectedItem.ToString());
                cmd.Parameters.Add("opr", "upd");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your data Is Successfully Updated", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();

                conn.Open();
                cmd = new SqlCommand("delete from custom_package_customer where orderId=" + orderId, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    string customPackID;
                    conn.Open();
                    using (SqlCommand cmd3 = new SqlCommand("SELECT Id FROM CustomizationTbl WHERE name = @name", conn))
                    {
                        cmd3.Parameters.AddWithValue("@name", dataGridView1.Rows[i].Cells[1].Value.ToString());
                        object result3 = cmd3.ExecuteScalar();
                        customPackID = result3 != null ? result3.ToString() : null;
                    }
                    conn.Close();
                    if (string.IsNullOrEmpty(customPackID))
                    {
                        throw new Exception("Customization ID not found.");
                    }

                    string venueId;
                    conn.Open();
                    using (SqlCommand cmd4 = new SqlCommand("SELECT venueid FROM venues WHERE venue_name = @venue_name", conn))
                    {
                        cmd4.Parameters.AddWithValue("@venue_name", cmbvenue.SelectedItem.ToString());
                        object result4 = cmd4.ExecuteScalar();
                        venueId = result4 != null ? result4.ToString() : null;
                    }
                    conn.Close();
                    if (string.IsNullOrEmpty(venueId))
                    {
                        throw new Exception("Venue ID not found.");
                    }

                    string date = DateTime.Now.ToShortDateString();
                    string time = DateTime.Now.ToShortTimeString();


                    decimal price;

                    if (!decimal.TryParse(dataGridView1.Rows[i].Cells[3].Value.ToString(), out price))
                    {
                        throw new Exception("Price must be a valid decimal.");
                    }
                    conn.Open();
                    using (SqlCommand cmd5 = new SqlCommand("ManageCustomPackageCustomer", conn))
                    {
                        cmd5.CommandType = CommandType.StoredProcedure;
                        cmd5.Parameters.AddWithValue("@cusId", usercomboboxcs1.SelectedItem.ToString());
                        cmd5.Parameters.AddWithValue("@customPackID", customPackID);
                        cmd5.Parameters.AddWithValue("@orderId", orderId);
                        cmd5.Parameters.AddWithValue("@qty", dataGridView1.Rows[i].Cells[2].Value.ToString());
                        cmd5.Parameters.AddWithValue("@price", price);
                        cmd5.Parameters.AddWithValue("@bookingdate", date);
                        cmd5.Parameters.AddWithValue("@bookingtime", time);
                        cmd5.Parameters.AddWithValue("@venueId", venueId);
                        cmd5.Parameters.AddWithValue("@opr", "ins");
                        cmd5.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception exc)
            {
                conn.Close();
                MessageBox.Show(exc.ToString(), "Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UButton3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ManageCustomer1", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("cusId", usercomboboxcs1.SelectedItem.ToString());
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
        public void clearData()
        {
            customer_name.Controls.Clear();
            mobile_number.Controls.Clear();
            alternate_mobile_number.Controls.Clear();
            email.Controls.Clear();
            usercomboboxcs4.Controls.Clear();
            usercomboboxcs5.Controls.Clear();
            address.Controls.Clear();
            landmark.Controls.Clear();
            pincode.Controls.Clear();
            usercomboboxcs1.Controls.Clear();
            usercomboboxcs6.Controls.Clear();
            usercomboboxcs2.Controls.Clear();
            usercomboboxcs3.Controls.Clear();
            qty.Clear();
            pr.Clear();
            cmbvenue.Controls.Clear();
            eventdate.Clear();
            dataGridView1.Rows.Clear();

        }

        private void Usercomboboxcs3_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Usercomboboxcs2_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                qty.Texts = 0.ToString();

                SqlDataAdapter da1 = new SqlDataAdapter("select * from CustomizationTbl where name='" + usercomboboxcs2.SelectedItem + "'", conn);

                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                string cus_id = dt1.Rows[0][0].ToString();

                SqlDataAdapter da = new SqlDataAdapter("select sizeqty,sizeqtymid,sizeqtylarge from CustomizationTbl where name='" + usercomboboxcs2.SelectedItem + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                usercomboboxcs3.Items.Clear();

                usercomboboxcs3.Items.Add(dt.Rows[0][0].ToString());
                usercomboboxcs3.Items.Add(dt.Rows[0][1].ToString());
                usercomboboxcs3.Items.Add(dt.Rows[0][2].ToString());

                usercomboboxcs3.SelectedIndex = 0;


            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString(), "Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Qty_Leave(object sender, EventArgs e)
        {
            string[] data = usercomboboxcs3.SelectedItem.ToString().Split(' ');

            if (int.Parse(qty.Texts.Split(' ')[0]) < int.Parse(data[0]))
            {
                MessageBox.Show("minimum quntity should be " + usercomboboxcs3.SelectedItem.ToString());
                qty.Focus();
            }
        }
        static int orderId;
    
        private void Usercomboboxcs4_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Clear the current city items
            usercomboboxcs5.Items.Clear();

            // Get the selected state
            string selectedState = usercomboboxcs4.SelectedItem.ToString();

            // Find the location (state) and load its cities
            var location = locations.FirstOrDefault(l => l.State == selectedState);
            if (location != null)
            {
                foreach (var city in location.Cities)
                {
                    usercomboboxcs5.Items.Add(city.Name);
                }
                if (usercomboboxcs5.Items.Count > 0)
                {
                    usercomboboxcs5.SelectedIndex = 0;  // Automatically select the first city
                }
            }
            else
            {
                MessageBox.Show("No cities found for the selected state.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Usercomboboxcs5_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected state and city
            string selectedState = usercomboboxcs4.SelectedItem.ToString();
            string selectedCity = usercomboboxcs5.SelectedItem.ToString();

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
        static string rno;
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rno = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            usercomboboxcs2.SelectedItem = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            qty.Texts = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            pr.Texts = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void UButton1_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int idx = int.Parse(dataGridView1.SelectedCells[0].RowIndex.ToString());
                    DataGridViewRow dgr = new DataGridViewRow();

                    dgr.CreateCells(dataGridView1);

                    dgr.Cells[0].Value = idx + 1; 
                    dgr.Cells[1].Value = usercomboboxcs2.Texts;  
                    dgr.Cells[2].Value = qty.Texts; 
                    dgr.Cells[3].Value = pr.Texts; 

                    dataGridView1.Rows.Insert(idx, dgr);

                    if (idx + 1 < dataGridView1.Rows.Count) 
                    {
                        dataGridView1.Rows.RemoveAt(idx + 1);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a cell to insert the row.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void Usercomboboxcs6_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            bindCombo2cuid();
            dataGridView1.Rows.Clear();
            //int norqty = Convert.ToInt32(usercomboboxcs3.SelectedItem.ToString());
            SqlDataAdapter da = new SqlDataAdapter("SELECT c.cusId, c.customer_name, c.[mobile _number], c.alternate_mobile_number, c.email, c.addr, c.landmark, c.state, c.city, c.pincode,CU.Id,cu.name,cu.sizeqty,cu.sizeqtymid,cu.sizeqtylarge,v.venueid, v.venue_name, v.venue_address,n.price,n.qty,n.orderid FROM   Customerinfo c INNER JOIN Custom_package_customer n ON c.cusId = n.cusId INNER JOIN CustomizationTbl cu ON n.customPackID = cu.Id INNER JOIN venues v ON n.venueId = v.venueid where n.orderId='" + usercomboboxcs6.SelectedItem.ToString() + "'", conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            usercomboboxcs1.SelectedItem = dt.Rows[0]["cusId"].ToString();
            customer_name.Texts = dt.Rows[0]["customer_name"].ToString();
            mobile_number.Texts = dt.Rows[0]["mobile _number"].ToString();
            alternate_mobile_number.Texts = dt.Rows[0]["alternate_mobile_number"].ToString();
            email.Texts = dt.Rows[0]["email"].ToString();
            address.Texts = dt.Rows[0]["addr"].ToString();
            landmark.Texts = dt.Rows[0]["landmark"].ToString();
            usercomboboxcs4.SelectedItem = dt.Rows[0]["state"].ToString();
            usercomboboxcs5.SelectedItem = dt.Rows[0]["city"].ToString();
            pincode.Texts = dt.Rows[0]["pincode"].ToString();
            orderId = int.Parse(dt.Rows[0]["orderid"].ToString());
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    dataGridView1.Rows.Add((i + 1), dt.Rows[i]["name"].ToString(), dt.Rows[i]["qty"].ToString(), dt.Rows[i]["price"].ToString());
                }

                cmbvenue.SelectedItem = dt.Rows[0]["venue_name"].ToString();
                eventdate.Texts = dt.Rows[0]["venue_address"].ToString();
            }
            else
            {
                MessageBox.Show("No data found for the selected customer ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UButton5_Click(object sender, EventArgs e)
        {
            bindCombo4orderid();
        }

        private void UButton6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
