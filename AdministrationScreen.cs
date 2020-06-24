using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyImageButton;


namespace GARAGE
{
    public partial class AdministrationScreen : Form
    {
        public AdministrationScreen()
        {
            InitializeComponent();
        }

        private void AdministrationScreen_Load(object sender, EventArgs e)
        {



        }

        private void AutoButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarScreen FormCarScreen = new CarScreen();
            FormCarScreen.ShowDialog(this);
        }

        private void PartsButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            PartsScreen FormPartsScreeen = new PartsScreen();
            FormPartsScreeen.ShowDialog(this);
        }

        private void ClientButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientsScreen FormClientsScreen = new ClientsScreen();
            FormClientsScreen.ShowDialog(this);
            
        }

        private void RepairButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServiceScreen FormServiceScreeen = new ServiceScreen();
            FormServiceScreeen.ShowDialog(this);
        }

        private void MasterButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MastersScreen FormMaster = new MastersScreen();
            FormMaster.ShowDialog(this);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen MainMenuScreen = new MainScreen();
            MainMenuScreen.ShowDialog(this);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
