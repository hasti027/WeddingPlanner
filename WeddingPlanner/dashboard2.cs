using System;
using System.Windows.Forms;

namespace WeddingPlanner
{
    public partial class dashboard2 : Form
    {
        public dashboard2()
        {
            InitializeComponent();
        }

        private void Dashboard2_Load(object sender, EventArgs e)
        {

        }
        bool menuExpand = false;
        private void Menutransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {

                menuContainer.Height += 10;
                if (menuContainer.Height >= 177)
                {
                    menutransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 49)
                {
                    menutransition.Stop();
                    menuExpand= false;
                }
            }
        }

        bool sidebarExpand=true;
        private void Sidebartransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 70)
                {
                    sidebarExpand = false;
                    sidebartransition.Stop();

                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 229)
                {
                    sidebarExpand = true;
                    sidebartransition.Stop();
                }
            
            }
        }

        private void Btnham_Click(object sender, EventArgs e)
        {
            sidebartransition.Start();
        }

        private void Button10_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void Package_Click(object sender, EventArgs e)
        {

            menutransition.Start();
            
        }
        bool menuExpand1 = false;
        private void Menutransition1_Tick(object sender, EventArgs e)
        {
           
           
            if (menuExpand1 == false)
            {
                
                menuContainer1.Height += 10;
                if (menuContainer1.Height >= 177)
                {
                    menutransition1.Stop();
                    menuExpand1 = true;
                }
            }
            else
            {
                menuContainer1.Height -= 10;
                if (menuContainer1.Height <= 49)
                {
                    menutransition1.Stop();
                    menuExpand1 = false;
                }
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            menutransition1.Start();
            
        }

        private void Button10_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        bool menuExpand2 = false;
        private void Menutransition2_Tick(object sender, EventArgs e)
        {
            if (menuExpand2 == false)
            {
                menuContainer2.Height += 10;
                if (menuContainer2.Height >= 177)
                {
                    menutransition2.Stop();
                    menuExpand2 = true;
                }
            }
            else
            {
                menuContainer2.Height -= 10;
                if (menuContainer2.Height <= 49)
                {
                    menutransition2.Stop();
                    menuExpand2 = false;
                }
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            menutransition2.Start();
            
        }

        private void Button13_Click(object sender, EventArgs e)
        {

        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}