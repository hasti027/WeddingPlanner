using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace WeddingPlanner
{
    public partial class defult : Form
    {
        SqlConnection conn = new SqlConnection(connect.constr);
        public defult()
        {
            InitializeComponent();
        }

        private void Defult_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select count(*) from customizationtbl",conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                lblscount.Text = dt.Rows[0][0].ToString();
                cps.Value = int.Parse(lblscount.Text);

                da = new SqlDataAdapter("select count(*) from package_tbl",conn);
                dt = new DataTable();
                da.Fill(dt);
                lblpcount.Text = dt.Rows[0][0].ToString();
                cpp.Value = int.Parse( lblcpcount.Text);

                da = new SqlDataAdapter("select count(*) from Normal_package_customer", conn);
                dt = new DataTable();
                da.Fill(dt);
                lblnpcount.Text = dt.Rows[0][0].ToString();
                cpn.Value = int.Parse(lblnpcount.Text);


                da = new SqlDataAdapter("select distinct count(cusId) from Custom_package_customer", conn);
                dt = new DataTable();
                da.Fill(dt);
                lblcpcount.Text = dt.Rows[0][0].ToString();
                cpsp.Value = int.Parse(lblcpcount.Text);

                timer1.Start();
            }
            catch (Exception exc)
            {

                throw exc;
            }
        }
        static int count;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(count==4)
            {
                count =0;
            }
            mainpanel1.BackgroundImage = imageList1.Images[count++];
        }
    }
}
