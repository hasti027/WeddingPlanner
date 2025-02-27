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
using System.Drawing.Drawing2D;
using System.IO;

namespace WeddingPlanner
{
    public partial class displaypackage : Form
    {
        SqlConnection conn = new SqlConnection(connect.constr);

    

        public displaypackage()
        {
            InitializeComponent();
        }
        private void displaypackage_Load(object sender, EventArgs e)
        {
            displaydata();
        }
        public void displaydata()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select p_id as Id,package_name as PackAge_Name,package_price as Package_Price,wedding_types as Wedding_Types,discount as Discount,pic as Image  from package_tbl", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.Columns.Add("pic", Type.GetType("System.Byte[]"));
                foreach (DataRow drow in dt.Rows)
                {
                    drow["pic"] = File.ReadAllBytes(Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + drow["Image"].ToString());
                }
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[dataGridView1.Columns.Count - 2].Visible = false;
                ((DataGridViewImageColumn)dataGridView1.Columns[dataGridView1.Columns.Count - 1]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridView1.Columns[dataGridView1.Columns.Count - 1].Width = 200;
                dataGridView1.Columns[dataGridView1.Columns.Count - 4].Width = 200;
                dataGridView1.Columns[dataGridView1.Columns.Count - 6].Width = 150;


            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
            }

        }
        static string id;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.SelectedCells[0].Value.ToString();
            if (MessageBox.Show("Do You Want to Delete?", "Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("packagepro", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_id", id);
                    cmd.Parameters.Add("opr", "del");

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Your data Is Successfully Deleted", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();

                    displaydata();
                }
                catch (Exception exc)
                {
                    conn.Close();
                    MessageBox.Show(exc.ToString(), "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}