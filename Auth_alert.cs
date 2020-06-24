using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace GARAGE
{
    public partial class Auth_alert : Form
    {
        public Auth_alert()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enmAction.close;
        }

        public enum enmAction
        {

            wait,
            start,
            close
        }

        public enum enmType
        {
            Warning,
            Success,
            Send
        }

        private Auth_alert.enmAction action;
       
        private int x, y;
        public void showAlert(string msg, enmType type)
        {

            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                Auth_alert frm = (Auth_alert)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }


            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)

            {
                case enmType.Success:
                    this.BackColor = Color.YellowGreen;
                    //this.iconPictureBox1.BackColor = Color.YellowGreen;
                    this.iconPictureBox1.IconChar = IconChar.CheckCircle;
                   // this.iconButton1.BackColor = Color.YellowGreen;
                   // this.iconButton1.ForeColor = Color.YellowGreen;


                    break;

                case enmType.Warning:
                    this.BackColor = Color.FromArgb(203, 57, 42);
                    //this.iconPictureBox1.BackColor = Color.DarkOrange;

                    break;

                case enmType.Send:
                    this.BackColor = Color.FromArgb(12, 133, 205);
                   // this.iconPictureBox1.BackColor = Color.FromArgb(12, 133, 205);
                    this.iconPictureBox1.IconChar = IconChar.Clock;
                   // this.iconButton1.BackColor = Color.FromArgb(12, 133, 205);
                   // this.iconButton1.ForeColor = Color.FromArgb(12, 133, 205);
                    //this.iconPictureBox1.BackColor = Color.DarkOrange;

                    break;
            }
            this.label1.Text = msg;

            this.Show();
            this.action = enmAction.start;
            this.timer1.Interval = 1;
            timer1.Start();
        }

        private void iconButton_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enmAction.close;
        }

        private void Auth_alert_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 5000;
                    action = enmAction.close;
                    break;

                case enmAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)

                    {
                        this.Left--;

                    }

                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = enmAction.wait;
                        }


                    }
                    break;

                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {

                        base.Close();

                    }
                    break;

            }

        }

         
    }

}
