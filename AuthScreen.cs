using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using FontAwesome.Sharp;

namespace GARAGE
{
    public partial class AuthScreen : Form
    {
        public AuthScreen()
        {
            InitializeComponent();
        }

        private void AuthScreen_Load(object sender, EventArgs e)
        {
            this.NotFinde.Visible = false;
            Gar.Gar_Exit = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {

        }
        public void Alert(string msg, Auth_alert.enmType type)
        {

            Auth_alert frm = new Auth_alert();
            frm.showAlert(msg, type);
        }



        private void AuthBut_Click(object sender, EventArgs e)
        {
            // Проверим что есть такой сотрудник и получим его тип

            MySqlCommand _MySqlSelectCommand;
            MySqlDataReader _Reader;

            _MySqlSelectCommand = new MySqlCommand();

            _MySqlSelectCommand.Connection = Gar.MySqlCon;
            _MySqlSelectCommand.CommandText = "SELECT Type FROM staff where Login = @CODE and Password = @PWD";
            _MySqlSelectCommand.Parameters.AddWithValue("@CODE", this.Login.Text);
            _MySqlSelectCommand.Parameters.AddWithValue("@PWD", this.Password.Text);

            _Reader = _MySqlSelectCommand.ExecuteReader();
            _Reader.Read();

            //MainScreen.asd = Login.Text;


            if (_Reader.HasRows)
            {
                Gar.Staff_Type = _Reader.GetString(0);
                _Reader.Close();
                Gar.Gar_Exit = false;
                this.Alert("Вход воспроизведен", Auth_alert.enmType.Success);
                this.Dispose();
            }
            else
            {
                this.NotFinde.Visible = true;
                _Reader.Close();
                this.Alert("Пользователь не найден", Auth_alert.enmType.Warning);
            }


        }

       



        private void Exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Password_Click(object sender, EventArgs e)
        {
            Password.Clear();
            Password.PasswordChar = '*';
            iconPictureBox2.ForeColor = Color.FromArgb(12, 133, 205);
            iconPictureBox2.IconChar = IconChar.Unlock;
            Password.ForeColor = Color.FromArgb(12, 133, 205);
            panel2.BackColor = Color.FromArgb(12, 133, 205);

            Login.ForeColor = Color.WhiteSmoke;
            panel1.BackColor = Color.WhiteSmoke;
            iconPictureBox1.ForeColor = Color.WhiteSmoke;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login.Clear();
            iconPictureBox1.ForeColor = Color.FromArgb(12, 133, 205);
            Login.ForeColor = Color.FromArgb(12, 133, 205);
            panel1.BackColor = Color.FromArgb(12, 133, 205);
            //panel1.ForeColor = Color.FromArgb(12, 133, 205);

            Password.ForeColor = Color.WhiteSmoke;
            panel2.BackColor = Color.WhiteSmoke;
            iconPictureBox2.ForeColor = Color.WhiteSmoke;
            iconPictureBox2.IconChar = IconChar.Lock;
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
