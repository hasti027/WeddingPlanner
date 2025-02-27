using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeddingPlanner
{
    public partial class dashboard3 : Form
    {
        private Boolean showpanelbooking = false;
        private Boolean showpaneladd = false;
        private Boolean showpaneldisplay = false;
        private Boolean showpanelbdisplay = false;
        private Boolean showpanelsetting = false;

       
        public dashboard3()
        {
            InitializeComponent();
            
                togglepanels();
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Btnbooking_Click(object sender, EventArgs e)
        {
               
                panelbooking.Show();
                showpaneldisplay = false;
                showpaneladd = false;
            showpanelbdisplay = false;
            showpanelbooking = !showpanelbooking;
                togglepanels();
                if(!sidebarExpand)
                {
                    panelbooking.Hide();
                    paneldisplay.Hide();
                    paneladd.Hide();
                    sidebartransition.Start();
                }
  
        }
        private void togglepanels()
        {
                if (showpanelbooking)
                {
                    panelbooking.Height = 60;
                }
                else
                {
                    panelbooking.Height = 0;
                }
            
            if (showpaneladd)
            {
                paneladd.Height = 60;
            }
            else
            {
                paneladd.Height = 0;
            }
            if (showpaneldisplay)
            {
                paneldisplay.Height = 60;
            }
            else
            {
                paneldisplay.Height = 0;
            }
            if(showpanelbdisplay)
            {
                panelpackage.Height = 60;
            }
            else
            {
                panelpackage.Height = 0; 
            }
            if(showpanelsetting)
            {
                panelsetting.Height = 60;
            }
            else
            {
                panelsetting.Height = 0;
            }

        }

        private void Btnadd_Click(object sender, EventArgs e)
        {
            paneladd.Show();
            showpanelbooking = false;
            showpaneldisplay = false;
            showpanelbdisplay = false;
            showpaneladd = !showpaneladd;
            togglepanels();
            if (!sidebarExpand)
            {
                panelbooking.Hide();
                paneldisplay.Hide();
                paneladd.Hide();
                sidebartransition.Start();
            }
        }

        private void Btndisplay_Click(object sender, EventArgs e)
        {
            paneldisplay.Show();
            showpanelbooking = false;
            showpaneladd = false;
            showpanelbdisplay = false;
            showpaneldisplay = !showpaneldisplay;
            togglepanels();
            if (!sidebarExpand)
            {
                panelbooking.Hide();
                paneldisplay.Hide();
                paneladd.Hide();
                sidebartransition.Start();
            }
        }
        bool sidebarExpand = true;
        private void mysidebar()
        {
            if (sidebarExpand)
            {
                panelsidebar.Width -= 10;
                if (panelsidebar.Width <= 70)
                {
                    sidebarExpand = false;
                    sidebartransition.Stop();

                }
            }
            else
            {

                panelsidebar.Width += 10;
                if (panelsidebar.Width >= 229)
                {
                    sidebarExpand = true;
                    sidebartransition.Stop();
                }

            }
        }
        private void Sidebartransition_Tick(object sender, EventArgs e)
        {
            mysidebar();
        }

        private void Btnham_Click(object sender, EventArgs e)
        {
            panelbooking.Hide();
            paneldisplay.Hide();
            paneladd.Hide();
            sidebartransition.Start();
            
            
        }

        private void Dashboard3_Load(object sender, EventArgs e)
        {
            sidebartransition.Start();
            paneldisplay.Hide();
            panel1.Controls.Clear();
            sidebartransition.Start();
            defult s = new defult();
            s.TopLevel = false;
            panel1.Controls.Add(s);
            s.Show();
        }

        private void Btndashboard_Click(object sender, EventArgs e)
        {




           
        }

        private void Btncalendar_Click(object sender, EventArgs e)
        {
            sidebartransition.Start();
            paneldisplay.Hide();
            panel1.Controls.Clear();
            sidebartransition.Start();
            Calendar s = new Calendar();
            s.TopLevel = false;
            panel1.Controls.Add(s);
            s.Show();
        }

        private void Btnsetting_Click(object sender, EventArgs e)
        {
            panelsetting.Show();
            showpanelbooking = false;
            showpaneladd = false;
            showpanelbdisplay = false;
            showpaneldisplay = false;
            showpanelsetting = !showpanelsetting;
            togglepanels();
            if (!sidebarExpand)
            {
                panelbooking.Hide();
                paneldisplay.Hide();
                paneladd.Hide();
                panelsetting.Hide();
                panelpackage.Hide();
                sidebartransition.Start();
            }
        }

        private void Btnlogout_Click(object sender, EventArgs e)
        {
            sidebartransition.Start();
            paneldisplay.Hide();
            panel1.Controls.Clear();
            sidebartransition.Start();
            LoginForm s = new LoginForm();
            s.TopLevel = false;
            panel1.Controls.Add(s);
            s.Show();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            sidebartransition.Start();
            panelbooking.Hide();
            panel1.Controls.Clear();
            booking s = new booking();
            s.TopLevel = false;
            panel1.Controls.Add(s);
            s.Show();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            sidebartransition.Start();
            panelbooking.Hide();
            panel1.Controls.Clear();
            custombooking s = new custombooking();
            s.TopLevel = false;
            panel1.Controls.Add(s);
            s.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            sidebartransition.Start();
            paneldisplay.Hide();
            panel1.Controls.Clear();
            sidebartransition.Start();
             displaypackage s = new displaypackage();
            s.TopLevel = false;
            panel1.Controls.Add(s);
            s.Show();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            sidebartransition.Start();
            paneladd.Hide();
            panel1.Controls.Clear();
            packagesform s = new packagesform();
            s.TopLevel = false;
            panel1.Controls.Add(s);
            s.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            sidebartransition.Start();
            paneladd.Hide();
            panel1.Controls.Clear();
            CustomizationThingsDetails s = new CustomizationThingsDetails();
            s.TopLevel = false;
            panel1.Controls.Add(s);
            s.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            sidebartransition.Start();
            paneldisplay.Hide();
            panel1.Controls.Clear();
            sidebartransition.Start();
            dispalycustombooking s = new dispalycustombooking();
            s.TopLevel = false;
            panel1.Controls.Add(s);
            s.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       

        private void Button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Button12_Click_1(object sender, EventArgs e)
        {
            panelpackage.Show();
            showpanelbooking = false;
            showpaneldisplay = false;
            showpaneladd = false;
            showpanelbdisplay = !showpanelbdisplay;
            togglepanels();
            if (!sidebarExpand)
            {
                panelbooking.Hide();
                paneldisplay.Hide();
                paneladd.Hide();
                panelpackage.Hide();
                sidebartransition.Start();
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {

            sidebartransition.Start();
            paneldisplay.Hide();
            panel1.Controls.Clear();
            sidebartransition.Start();
            displaybooking s = new displaybooking();
            s.TopLevel = false;
            panel1.Controls.Add(s);
            s.Show();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {

            sidebartransition.Start();
            paneldisplay.Hide();
            panel1.Controls.Clear();
            sidebartransition.Start();
            custombooking s = new custombooking();
            s.TopLevel = false;
            panel1.Controls.Add(s);
            s.Show();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            sidebartransition.Start();
            paneldisplay.Hide();
            panel1.Controls.Clear();
            sidebartransition.Start();
            resetpassword s = new resetpassword();
            s.TopLevel = false;
            panel1.Controls.Add(s);
            s.Show();
        }

        private void Button12_Click_2(object sender, EventArgs e)
        {
            if (MessageBox.Show("exit", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error)==DialogResult.Yes)
            {
                this.Close();
            }
            
        }
    }
}
