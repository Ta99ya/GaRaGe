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
    public partial class OrderScreen : Form
    {
        public OrderScreen()
        {
            InitializeComponent();
            this.vorderTableAdapter.Connection = Gar.MySqlCon;
            cboColumn.SelectedIndex = 1;
        }

        private void OrderScreen_Load(object sender, EventArgs e)
        {

            this.vorderTableAdapter.Fill(this.garageDataSet.vorder);

        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 tekID;
            
            if (e.RowIndex >= 0)
            {
                if (this.dataGridView1.Rows[e.RowIndex].IsNewRow == false)
                {

                    tekID = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells["idorderDataGridViewTextBoxColumn"].Value.ToString());

                    OrderEdit FormOrderEdit = new OrderEdit(tekID);
                    FormOrderEdit.ShowDialog(this);

                    this.vorderTableAdapter.Fill(this.garageDataSet.vorder);
                    
                     dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[0]; 


                }

            }
        }

        private void customImageButton2_Click(object sender, EventArgs e)
        {
            OrderEdit FormOrderEdit = new OrderEdit(0);
            FormOrderEdit.ShowDialog(this);

            this.vorderTableAdapter.Fill(this.garageDataSet.vorder);
        }

        private void Back_c_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen MainMenuScreen = new MainScreen();
            MainMenuScreen.ShowDialog(this);
        }

        private void customImageButton1_Click(object sender, EventArgs e)
        {
            Int32 tekID;

            if ((this.vorderBindingSource.Count > 0) && (this.dataGridView1.CurrentRow != null))
            {


                if (MessageBox.Show(this, "Отменяем заказ?", "Подтверждение операции", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {

                    tekID = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["idorderDataGridViewTextBoxColumn"].Value.ToString());
                    if (this.dataGridView1.CurrentRow.IsNewRow == false)
                    {
                        MySqlCommand _MySqlSelectCommand;
                        _MySqlSelectCommand = new MySqlCommand();
                        _MySqlSelectCommand.Connection = Gar.MySqlCon;
                        _MySqlSelectCommand.CommandText = "UPDATE `order` SET Status = 'C' where Id_order = @ID";
                        _MySqlSelectCommand.Parameters.AddWithValue("@ID", tekID);
                        int rowEffected = _MySqlSelectCommand.ExecuteNonQuery();

                        this.vorderTableAdapter.Fill(this.garageDataSet.vorder);
                    }

                }
            }
        }
        bool press = false; Point n = new Point(0, 0);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            press = true; n = new Point(e.X, e.Y);
            this.Opacity = 0.8;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (press)
            {
                Point P = this.PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(P.X - n.X, P.Y - n.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            press = false;
            this.Opacity = 1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(garageDataSet.vorder);
            string c = cboColumn.Text;
            switch (c)
            {
                
                case "Номер ЗН":
                    DV.RowFilter = string.Format("Id_order like '%{0}%'", textSearch.Text);
                    dataGridView1.DataSource = DV;
                    break;

                case "Статус":
                    DV.RowFilter = string.Format("Status like '%{0}%'", textSearch.Text);
                    dataGridView1.DataSource = DV;
                    break;

                case "Мастер-приемщик":
                    DV.RowFilter = string.Format("Staff like '%{0}%'", textSearch.Text);
                    dataGridView1.DataSource = DV;
                    break;

                case "Клиент":
                    DV.RowFilter = string.Format("fullname like '%{0}%'", textSearch.Text);
                    dataGridView1.DataSource = DV;
                    break;

                case "Гос.Номер":
                    DV.RowFilter = string.Format("Gov_numb like '%{0}%'", textSearch.Text);
                    dataGridView1.DataSource = DV;
                    break;

                case "Сумма":
                    DV.RowFilter = string.Format("Sum like '%{0}%'", textSearch.Text);
                    dataGridView1.DataSource = DV;
                    break;

                case "Примечание":
                    DV.RowFilter = string.Format("Note like '%{0}%'", textSearch.Text);
                    dataGridView1.DataSource = DV;
                    break;

                case "Телефон":
                    DV.RowFilter = string.Format("phone like '%{0}%'", textSearch.Text);
                    dataGridView1.DataSource = DV;
                    break;

                case "Марка":
                    DV.RowFilter = string.Format("Brand like '%{0}%'", textSearch.Text);
                    dataGridView1.DataSource = DV;
                    break;

                case "Модель":
                    DV.RowFilter = string.Format("Model like '%{0}%'", textSearch.Text);
                    dataGridView1.DataSource = DV;
                    break;



            }
            /*
            if (cboColumn.Text == "Статус")
            {
                DataView DV = new DataView(garageDataSet.vorder);
                DV.RowFilter = string.Format("Status like '%{0}%'", textSearch.Text);
                dataGridView1.DataSource = DV;
            }   
            */
        }

        
        private void textSearch_KeyDown(object sender, KeyEventArgs e)
        {
           /* if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(textSearch.Text))

                    vorderBindingSource.Filter = string.Empty;
                else
                    vorderBindingSource.Filter = string.Format("{0}='{1}'", cboColumn.Text, textSearch.Text+ "%'");
                  
            }
            */
        }
        

        private void textSearch_Click(object sender, EventArgs e)
        {
            textSearch.Clear();
        }
    }
}
