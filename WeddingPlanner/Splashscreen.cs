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
    public partial class Splashscreen : Form
    {
        public Splashscreen()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            label1.Text = progressBar1.Value + "%";
            if(progressBar1.Value==100)
            {
                LoginForm log1 = new LoginForm();
                this.Hide();
                log1.Show();
                timer1.Stop();

            }
        }

        private void Splashscreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
