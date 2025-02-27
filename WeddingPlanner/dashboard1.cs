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
    public partial class dashboard1 : Form
    {
        public dashboard1()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button11_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Timer5_Tick(object sender, EventArgs e)
        {

        }

        private void Button12_Click(object sender, EventArgs e)
        {
            menutransaction.Start();
        }

        private void Button13_Click(object sender, EventArgs e)
        {

        }

        private void Menucontainer_Paint(object sender, PaintEventArgs e)
        {

        }
        bool menuExpand = false;
        private void menutransaction_Tick(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


        }
        bool sidebarExpand = true;
        private void sidedbartransaction_Tick(object sender, EventArgs e)
        {
           
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    timer1.Stop();

                }
                else
                {
                    sidebar.Width += 5;
                    if (sidebar.Width == sidebar.MaximumSize.Width)
                    {
                        sidebarExpand = true;
                        timer1.Stop();
                    }
                }
            }
        }
    }
}
    

