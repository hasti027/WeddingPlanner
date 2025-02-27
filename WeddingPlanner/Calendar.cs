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
    public partial class Calendar : Form
    {
        SqlConnection conn = new SqlConnection(connect.constr);
        public Calendar()
        {
            InitializeComponent();
        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Usercomboboxcs2_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            usercomboboxcs3.Items.Add("2000");
            usercomboboxcs3.Items.Add("2001");
            usercomboboxcs3.Items.Add("2001");
            usercomboboxcs3.Items.Add("2002");
            usercomboboxcs3.Items.Add("2003");
            usercomboboxcs3.Items.Add("2004");
            usercomboboxcs3.Items.Add("2005");
            usercomboboxcs3.Items.Add("2006");
            usercomboboxcs3.Items.Add("2007");
            usercomboboxcs3.Items.Add("2008");
            usercomboboxcs3.Items.Add("2009");
            usercomboboxcs3.Items.Add("2010");
            usercomboboxcs3.Items.Add("2011");
            usercomboboxcs3.Items.Add("2012");
            usercomboboxcs3.Items.Add("2013");
            usercomboboxcs3.Items.Add("2014");
            usercomboboxcs3.Items.Add("2015");
            usercomboboxcs3.Items.Add("2016");
            usercomboboxcs3.Items.Add("2017");
            usercomboboxcs3.Items.Add("2018");
            usercomboboxcs3.Items.Add("2019");
            usercomboboxcs3.Items.Add("2020");
            usercomboboxcs3.Items.Add("2021");
            usercomboboxcs3.Items.Add("2022");
            usercomboboxcs3.Items.Add("2023");
            usercomboboxcs3.Items.Add("2024");
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                usercomboboxcs2.Items.Add(i);
            }
            usercomboboxcs2.SelectedIndex = 0;

            usercomboboxcs1.Items.Add("Normal Package");
            usercomboboxcs1.Items.Add("Custom Package");
            usercomboboxcs1.SelectedIndex = 0;
        }

        private void Usercomboboxcs3_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT c.customer_name, c.[mobile _number], c.alternate_mobile_number,c.email, c.addr, c.landmark, c.state, c.city, c.pincode, pd.package_name, pd.package_price, pd.wedding_types,pd.pic, pd.discount, pd.capacity,v.venue_name, v.venue_address FROM Normal_package_customer cc INNER JOIN Customerinfo c ON cc.CusId = c.cusId INNER JOIN package_tbl pd ON cc.packageId = pd.p_id INNER JOIN venues v ON cc.venueid = v.venueid where c.eventdate like '%" + usercomboboxcs2.Texts + "-" + usercomboboxcs3.Texts + "%' ", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
            }
        }
    }

}
