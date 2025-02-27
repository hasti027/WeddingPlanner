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
    public partial class DisplayCustomizationThingsDetails : Form
    {
        SqlConnection conn = new SqlConnection(connect.constr);
        public DisplayCustomizationThingsDetails()
        {
            InitializeComponent();
        }
        public void displaydata()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select id as Id,name as Service_Name,sizeqty as Minimum_Quantity,sizeqtymid as Mediam_Quantity,sizeqtylarge as Large_Quantity,price as Price  from CustomizationTbl", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                
             
                //dataGridView1.Columns[dataGridView1.Columns.Count - 1].Width = 200;
                //dataGridView1.Columns[dataGridView1.Columns.Count - 4].Width = 200;
                //dataGridView1.Columns[dataGridView1.Columns.Count - 6].Width = 150;


            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
            }

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DisplayCustomizationThingsDetails_Load(object sender, EventArgs e)
        {
            displaydata();
        }
        static string id;
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.SelectedCells[0].Value.ToString();
            if (MessageBox.Show("Do You Want to Delete?", "Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("custompro", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("id", id);
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
    }
}
