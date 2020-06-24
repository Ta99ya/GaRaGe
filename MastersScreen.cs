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

namespace GARAGE
{
    public partial class MastersScreen : Form
    {
        public MastersScreen()
        {
            InitializeComponent();
            this.staffTableAdapter.Connection = Gar.MySqlCon;
        }

        private void MastersScreen_Load(object sender, EventArgs e)
        {

            this.staffTableAdapter.Fill(this.garageDataSet.staff);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 tekID;
            
            if (e.RowIndex >= 0)
            {
                if (this.dataGridView1.Rows[e.RowIndex].IsNewRow == false)
                {

                    tekID = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells["idstaffDataGridViewTextBoxColumn"].Value.ToString());

                    MasterEdit FormMasterEdit = new MasterEdit(tekID);
                    FormMasterEdit.ShowDialog(this);

                    this.staffTableAdapter.Fill(this.garageDataSet.staff);
                    dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[0];
                }

            }
        }

        private void AddMaster_Click(object sender, EventArgs e)
        {
            MasterEdit FormMasterEdit = new MasterEdit(0);
            FormMasterEdit.ShowDialog(this);

            this.staffTableAdapter.Fill(this.garageDataSet.staff);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DelMaster_Click(object sender, EventArgs e)
        {

            Int32 tekID;

            if ((this.staffBindingSource.Count > 0) && (this.dataGridView1.CurrentRow != null))
            {


                if (MessageBox.Show(this, "Удаляем мастера?", "Подтверждение операции", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {

                    tekID = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["idstaffDataGridViewTextBoxColumn"].Value.ToString());
                    if (this.dataGridView1.CurrentRow.IsNewRow == false)
                    {
                        MySqlCommand _MySqlSelectCommand;
                        _MySqlSelectCommand = new MySqlCommand();
                        _MySqlSelectCommand.Connection = Gar.MySqlCon;
                        _MySqlSelectCommand.CommandText = "DELETE FROM staff where Id_staff = @ID";
                        _MySqlSelectCommand.Parameters.AddWithValue("@ID", tekID);
                        int rowEffected = _MySqlSelectCommand.ExecuteNonQuery();

                        this.staffTableAdapter.Fill(this.garageDataSet.staff);
                    }

                }
            }


        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            MasterEdit FormMasterEdit = new MasterEdit(0);
            FormMasterEdit.ShowDialog(this);

            this.staffTableAdapter.Fill(this.garageDataSet.staff);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Int32 tekID;

            if ((this.staffBindingSource.Count > 0) && (this.dataGridView1.CurrentRow != null))
            {


                if (MessageBox.Show(this, "Удаляем мастера?", "Подтверждение операции", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {

                    tekID = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["idstaffDataGridViewTextBoxColumn"].Value.ToString());
                    if (this.dataGridView1.CurrentRow.IsNewRow == false)
                    {
                        MySqlCommand _MySqlSelectCommand;
                        _MySqlSelectCommand = new MySqlCommand();
                        _MySqlSelectCommand.Connection = Gar.MySqlCon;
                        _MySqlSelectCommand.CommandText = "DELETE FROM staff where Id_staff = @ID";
                        _MySqlSelectCommand.Parameters.AddWithValue("@ID", tekID);
                        int rowEffected = _MySqlSelectCommand.ExecuteNonQuery();

                        this.staffTableAdapter.Fill(this.garageDataSet.staff);
                    }

                }
            }
        }

        private void Back_c_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministrationScreen AdministrationScreen = new AdministrationScreen();
            AdministrationScreen.ShowDialog(this);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool press = false; Point n = new Point(0, 0);
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            press = false;
            this.Opacity = 1;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (press)
            {
                Point P = this.PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(P.X - n.X, P.Y - n.Y);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            press = true; n = new Point(e.X, e.Y);
            this.Opacity = 0.8;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
