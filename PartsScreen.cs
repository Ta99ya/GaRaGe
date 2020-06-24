using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace GARAGE
{
    public partial class PartsScreen : Form
    {
        public PartsScreen()
        {
            InitializeComponent();
            this.PartsTableAdapter.Connection = Gar.MySqlCon;
        }

        private void PartsScreen_Load(object sender, EventArgs e)
        {

            this.PartsTableAdapter.Fill(this.garageDataSet.Parts);

        }

        private void AddParts_Click(object sender, EventArgs e)
        {
            PartsEdit FormPartsEdit = new PartsEdit(0);
            FormPartsEdit.ShowDialog(this);

            this.PartsTableAdapter.Fill(this.garageDataSet.Parts);
        }

        private void DelParts_Click(object sender, EventArgs e)
        {
            Int32 tekID;

            if ((this.PartsBindingSource.Count > 0) && (this.dataGridView1.CurrentRow != null))
            {


                if (MessageBox.Show(this, "Удаляем запчасть?", "Подтверждение операции", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {

                    tekID = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["idPartsDataGridViewTextBoxColumn"].Value.ToString());
                    if (this.dataGridView1.CurrentRow.IsNewRow == false)
                    {
                        MySqlCommand _MySqlSelectCommand;
                        _MySqlSelectCommand = new MySqlCommand();
                        _MySqlSelectCommand.Connection = Gar.MySqlCon;
                        _MySqlSelectCommand.CommandText = "DELETE FROM Parts where Id_Parts = @ID";
                        _MySqlSelectCommand.Parameters.AddWithValue("@ID", tekID);
                        int rowEffected = _MySqlSelectCommand.ExecuteNonQuery();

                        this.PartsTableAdapter.Fill(this.garageDataSet.Parts);
                    }

                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 tekID;
            
            if (e.RowIndex >= 0)
            {
                if (this.dataGridView1.Rows[e.RowIndex].IsNewRow == false)
                {

                    tekID = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells["idPartsDataGridViewTextBoxColumn"].Value.ToString());

                    PartsEdit FormPartsEdit = new PartsEdit(tekID);
                    FormPartsEdit.ShowDialog(this);

                    this.PartsTableAdapter.Fill(this.garageDataSet.Parts);
                    dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[0];
                }

            }
        }

        private void Back_c_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministrationScreen AdministrationScreen = new AdministrationScreen();
            AdministrationScreen.ShowDialog(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.chart1.Series["ChartLinea"].Points.AddXY("Сатурн", 36);
            this.chart1.Series["ChartLinea"].Points.AddXY("Lada", 2);
            this.chart1.Series["ChartLinea"].Points.AddXY("Русланд", 49);
            this.chart1.Series["ChartLinea"].Points.AddXY("BP", 30);
            this.chart1.Series["ChartLinea"].Points.AddXY("Планета", 38);
            this.chart1.Series["ChartLinea"].Points.AddXY("IXORA", 15);
           

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customImageButton2_Click(object sender, EventArgs e)
        {
            PartsEdit FormPartsEdit = new PartsEdit(0);
            FormPartsEdit.ShowDialog(this);

            this.PartsTableAdapter.Fill(this.garageDataSet.Parts);
        }

        private void customImageButton3_Click(object sender, EventArgs e)
        {
            Int32 tekID;

            if ((this.PartsBindingSource.Count > 0) && (this.dataGridView1.CurrentRow != null))
            {


                if (MessageBox.Show(this, "Удаляем запчасть?", "Подтверждение операции", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {

                    tekID = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["idPartsDataGridViewTextBoxColumn"].Value.ToString());
                    if (this.dataGridView1.CurrentRow.IsNewRow == false)
                    {
                        MySqlCommand _MySqlSelectCommand;
                        _MySqlSelectCommand = new MySqlCommand();
                        _MySqlSelectCommand.Connection = Gar.MySqlCon;
                        _MySqlSelectCommand.CommandText = "DELETE FROM Parts where Id_Parts = @ID";
                        _MySqlSelectCommand.Parameters.AddWithValue("@ID", tekID);
                        int rowEffected = _MySqlSelectCommand.ExecuteNonQuery();

                        this.PartsTableAdapter.Fill(this.garageDataSet.Parts);
                    }

                }
            }
        }
    }
}
