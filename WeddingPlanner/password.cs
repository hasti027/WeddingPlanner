using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace WeddingPlanner
{
    public partial class password : Form
    {
    SqlConnection conn = new SqlConnection(connect.constr);
        public password()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.tabotp_Load);

        }

        private void tabotp_Load(object sender, EventArgs e)
        {
            // Attach TextChanged event handler for all OTP TextBoxes
            o1.TextChanged += otpTextBox_TextChanged;
            o2.TextChanged += otpTextBox_TextChanged;
            o3.TextChanged += otpTextBox_TextChanged;
            o4.TextChanged += otpTextBox_TextChanged;
            o5.TextChanged += otpTextBox_TextChanged;
            o6.TextChanged += otpTextBox_TextChanged;

            // Set MaxLength property for each TextBox to 1
            o1.MaxLength = 1;
            o2.MaxLength = 1;
            o3.MaxLength = 1;
            o4.MaxLength = 1;
            o5.MaxLength = 1;
            o6.MaxLength = 1;

            // Set focus to the first TextBox
            o1.Focus();
        }

        private void Password_Load(object sender, EventArgs e)
        {
            tabreset.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabreset.DrawItem += Tabreset_DrawItem;

            tabotp.Hide();
            tabrespwd.Hide();
           

        }

        private void otpTextBox_TextChanged(object sender, EventArgs e)
        {
            // Debugging: Show a message to ensure the event is firing
            MessageBox.Show("TextChanged Event Fired!");

            TextBox currentTextBox = (TextBox)sender;

            // Check if the current TextBox contains exactly 1 character
            if (currentTextBox.Text.Length == 1)
            {
                // Move the focus to the next TextBox
                if (currentTextBox.Name == o1.Name)
                {
                    o2.Focus();
                }
                else if (currentTextBox.Name == o2.Name)
                {
                    o3.Focus();
                }
                else if (currentTextBox.Name == o3.Name)
                {
                    o4.Focus();
                }
                else if (currentTextBox.Name == o4.Name)
                {
                    o5.Focus();
                }
                else if (currentTextBox.Name == o5.Name)
                {
                    o6.Focus();
                }
                else if (currentTextBox.Name == o6.Name)
                {
                    // Handle OTP submission
                    MessageBox.Show("OTP Complete!");
                }
            }
        }

        private void Tabreset_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage tabPage = tabreset.TabPages[e.Index];
            Rectangle tabBounds = tabreset.GetTabRect(e.Index);

            //Color hexColor = ColorTranslator.FromHtml("A579A5");
            Color rgbColor = Color.FromArgb(165, 121, 165);

            using (Brush brush = new SolidBrush(rgbColor)) 
            {
                e.Graphics.DrawString(tabPage.Text, e.Font, brush, tabBounds.X + 2, tabBounds.Y + 2);
            }
        }
        
        private void RjTextBox6_Leave(object sender, EventArgs e)
        { 
            Color rgbColor = Color.FromArgb(168, 126, 176);
            if (rjTextBox6.Texts=="")
            {
                rjTextBox6.Texts = "New Password";
                rjTextBox6.ForeColor = rgbColor;
            }
        }

        private void RjTextBox6_Enter(object sender, EventArgs e)
        {

            Color rgbColor = Color.FromArgb(168, 126, 176);
            if(rjTextBox6.Texts=="New Password")
            {
                rjTextBox6.Texts = "";
                rjTextBox6.ForeColor = rgbColor;
            }
        }

        private void RjTextBox7_Enter(object sender, EventArgs e)
        {
            Color rgbColor = Color.FromArgb(168, 126, 176);
            if (rjTextBox7.Texts == "Confirm Password")
            {
                rjTextBox7.Texts = "";
                rjTextBox7.ForeColor = rgbColor;
            }
        }

        private void RjTextBox7_Leave(object sender, EventArgs e)
        {
            Color rgbColor = Color.FromArgb(168, 126, 176);
            if (rjTextBox7.Texts == "")
            {
                rjTextBox7.Texts = "Confirm Password";
                rjTextBox7.ForeColor = rgbColor;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        static string otp; 
        private void Btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                Random r = new Random(); 
                otp = r.Next(100000, 1000000).ToString(); 
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress("jyotiodedra77@gmail.com");
                message.To.Add(new MailAddress(email.Texts));
                message.Subject = "OTP";
                message.IsBodyHtml = true; 
                message.Body = "Your OTP is " + otp;

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; 
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("jyotiodedra77@gmail.com", "vkby qxko tfdh hiez"); // Your Gmail app password
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                smtp.Send(message);
                MessageBox.Show("OTP Sent");

                tabemail.Hide();
                tabotp.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
       
        private void UButton1_Click(object sender, EventArgs e)
        {
            string txtotp = o1.Texts + o2.Texts + o3.Texts + o4.Texts + o5.Texts + o6.Texts;
            if (txtotp == otp)
            {
                tabotp.Hide();
                tabrespwd.Show();
            }
            else
            {
                MessageBox.Show("Incorrect OTP");
            }
        }

        private void UButton2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update loginform set psw='" + rjTextBox6.Text + "' where email='" + email + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Password has been changed"); 
                    


            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
            }
        }

       

        

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Random r = new Random();
                otp = r.Next(100000, 1000000).ToString();
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress("jyotiodedra77@gmail.com");
                message.To.Add(new MailAddress(email.Texts));
                message.Subject = "OTP";
                message.IsBodyHtml = true;
                message.Body = "Your OTP is " + otp;

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("jyotiodedra77@gmail.com", "vkby qxko tfdh hiez"); // Your Gmail app password
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                smtp.Send(message);
                MessageBox.Show("OTP Sent");

                tabemail.Hide();
                tabotp.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void Tabotp_Click(object sender, EventArgs e)
        {
           
        }

        private void O1_Enter(object sender, EventArgs e)
        {
            o1.MaxLength = 1;
        }
    }
}
