using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GARAGE
{
    public partial class MainScreen : Form
    {
        public string asd;
        public MainScreen()
        {
            InitializeComponent();
            //this.data = data;
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            if (Gar.Staff_Type != "1")
                this.Admin.Enabled = false;
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministrationScreen FormAdministration = new AdministrationScreen();
            FormAdministration.ShowDialog(this);

        }

        private void Work_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderScreen FormOrderScreen = new OrderScreen();
            FormOrderScreen.ShowDialog(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            Date.Text = DateTime.Now.ToString("dddd, d MMMM yyyy г.");
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            
        }
        
             
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Personal_card FormPersonal = new Personal_card();
            FormPersonal.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthScreen FormAuth = new AuthScreen();
            FormAuth.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Date_Click(object sender, EventArgs e)
        {
        }

        private void setting_button_Click(object sender, EventArgs e)
        {
            Personal_card FormPersonal = new Personal_card();
            FormPersonal.ShowDialog(this);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            //iconPictureBox1.ForeColor = Color.FromArgb(12, 133, 205);
            //Login.ForeColor = Color.FromArgb(12, 133, 205);
            //panel2.BackColor = Color.WhiteSmoke;
            panel2.BackColor = Color.Gainsboro;
            panel1.BackColor = Color.FromArgb(12, 133, 205);
            Date.ForeColor = Color.DimGray;
            label2.ForeColor = Color.DimGray;

            this.BackColor= Color.White;
           
            Work.ForeColor = Color.DimGray;
            Admin.ForeColor = Color.DimGray;
            
            exit_button.ForeColor = Color.DimGray;
            setting_button.ForeColor = Color.DimGray;
            notif_button.ForeColor = Color.DimGray;
            profile.ForeColor = Color.DimGray;

            iconButton1.IconColor = Color.DimGray;
            iconButton3.IconColor = Color.DimGray;

            //button2.Image = Image.FromFile(@"D:\Users\taya\0Диплом\картинки\icon_new_style\sun_40px_blue.png", false);
            button2.Image = Properties.Resources.sun_40px_blue;
            //button1.Image = Image.FromFile(@"D:\Users\taya\0Диплом\картинки\icon_new_style\partly_cloudy_night_40px_white.png", false);
            button1.Image = Properties.Resources.partly_cloudy_night_40px_white;

            exit_button.Image = Properties.Resources.logout_rounded_left_50px;
            profile.Image = Properties.Resources.resume_website_55px;
            notif_button.Image = Properties.Resources.alarms_50px;
            setting_button.Image = Properties.Resources.admin_settings_male_50px;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(36, 36, 48);
            Date.ForeColor = Color.White;
            label2.ForeColor = Color.White;


            this.BackColor = Color.FromArgb(30, 30, 40);
            
            Work.ForeColor = Color.White;
            Admin.ForeColor = Color.White;
            
            exit_button.ForeColor = Color.White;
            setting_button.ForeColor = Color.White;
            notif_button.ForeColor = Color.White;
            profile.ForeColor = Color.White;

            iconButton1.IconColor = Color.White;
            iconButton3.IconColor = Color.White;

            button2.Image = Properties.Resources.sun_40px_white;
            button1.Image = Properties.Resources.partly_cloudy_night_40px;

            exit_button.Image = Properties.Resources.logout_rounded_left_50px_white;
            profile.Image = Properties.Resources.resume_website_55px_white;
            notif_button.Image = Properties.Resources.alarms_50px_white;
            setting_button.Image = Properties.Resources.admin_settings_male_50px_white;
        }

        bool press = false; Point n = new Point(0, 0);
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            press = false;
            this.Opacity = 1;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            press = true; n = new Point(e.X, e.Y);
            this.Opacity = 0.8;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (press)
            {
                Point P = this.PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(P.X - n.X, P.Y - n.Y);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
