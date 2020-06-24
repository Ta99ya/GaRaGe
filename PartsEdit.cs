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
    public partial class PartsEdit : Form
    {
        private Int32 Id_Parts; // Id детали

        public PartsEdit(Int32 ID)
        {
            InitializeComponent();

            Id_Parts = ID;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            MySqlCommand _MySqlSelectCommand;

            _MySqlSelectCommand = new MySqlCommand();
            _MySqlSelectCommand.Connection = Gar.MySqlCon;


            if (this.Id_Parts == 0)
            {
                // получим очередной номер
                this.Id_Parts = Gar.GetNN("Parts");
                _MySqlSelectCommand.CommandText = "INSERT INTO Parts (Id_Parts, Name, Price, Provider, Eurocode) VALUES(@ID, @NAME, @PRICE, @PROVIDER, @CODE)";

            }
            else
            {
                _MySqlSelectCommand.CommandText = "UPDATE Parts SET Name = @NAME, Price = @PRICE, Provider = @PROVIDER, Eurocode = @CODE WHERE Id_Parts = @ID";

            }

            _MySqlSelectCommand.Parameters.AddWithValue("@ID", this.Id_Parts);
            _MySqlSelectCommand.Parameters.AddWithValue("@NAME", this.Name.Text);
            _MySqlSelectCommand.Parameters.AddWithValue("@PRICE", this.Price.Value);
            _MySqlSelectCommand.Parameters.AddWithValue("@PROVIDER", this.Provider.Text);
            _MySqlSelectCommand.Parameters.AddWithValue("@CODE", this.Eurocode.Text);

            int rowEffected = _MySqlSelectCommand.ExecuteNonQuery();

            this.Dispose();
        }

        private void PartsEdit_Load(object sender, EventArgs e)
        {
            if (this.Id_Parts > 0)
            {
                // Редактирование
                MySqlCommand _MySqlSelectCommand;
                MySqlDataReader _Reader;

                _MySqlSelectCommand = new MySqlCommand();

                _MySqlSelectCommand.Connection = Gar.MySqlCon;
                _MySqlSelectCommand.CommandText = "SELECT Name, Price, Eurocode, Provider FROM Parts where Id_Parts = @ID";
                _MySqlSelectCommand.Parameters.AddWithValue("@ID", this.Id_Parts);

                _Reader = _MySqlSelectCommand.ExecuteReader();
                _Reader.Read();
                if (_Reader.HasRows)
                {
                    this.Name.Text = _Reader.GetString(0);
                    this.Price.Value = _Reader.GetDecimal(1);
                    this.Eurocode.Text = _Reader.GetString(2);
                    this.Provider.Text = _Reader.GetString(3);
                    
                }
                _Reader.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Eurocode_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Price_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Provider_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            MySqlCommand _MySqlSelectCommand;

            _MySqlSelectCommand = new MySqlCommand();
            _MySqlSelectCommand.Connection = Gar.MySqlCon;


            if (this.Id_Parts == 0)
            {
                // получим очередной номер
                this.Id_Parts = Gar.GetNN("Parts");
                _MySqlSelectCommand.CommandText = "INSERT INTO Parts (Id_Parts, Name, Price, Provider, Eurocode) VALUES(@ID, @NAME, @PRICE, @PROVIDER, @CODE)";

            }
            else
            {
                _MySqlSelectCommand.CommandText = "UPDATE Parts SET Name = @NAME, Price = @PRICE, Provider = @PROVIDER, Eurocode = @CODE WHERE Id_Parts = @ID";

            }

            _MySqlSelectCommand.Parameters.AddWithValue("@ID", this.Id_Parts);
            _MySqlSelectCommand.Parameters.AddWithValue("@NAME", this.Name.Text);
            _MySqlSelectCommand.Parameters.AddWithValue("@PRICE", this.Price.Value);
            _MySqlSelectCommand.Parameters.AddWithValue("@PROVIDER", this.Provider.Text);
            _MySqlSelectCommand.Parameters.AddWithValue("@CODE", this.Eurocode.Text);

            int rowEffected = _MySqlSelectCommand.ExecuteNonQuery();

            this.Dispose();
        }

        private void Back_c_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Back_c_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
