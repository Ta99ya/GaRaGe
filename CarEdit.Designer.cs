namespace GARAGE
{
    partial class CarEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarEdit));
            this.vcustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.garageDataSet = new GARAGE.GarageDataSet();
            this.vcustomerTableAdapter = new GARAGE.GarageDataSetTableAdapters.vcustomerTableAdapter();
            this.Customer = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Gov_numb = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.TextBox();
            this.Brand = new System.Windows.Forms.TextBox();
            this.Back_c = new FontAwesome.Sharp.IconButton();
            this.Save = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vcustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garageDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // vcustomerBindingSource
            // 
            this.vcustomerBindingSource.DataMember = "vcustomer";
            this.vcustomerBindingSource.DataSource = this.garageDataSet;
            // 
            // garageDataSet
            // 
            this.garageDataSet.DataSetName = "GarageDataSet";
            this.garageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vcustomerTableAdapter
            // 
            this.vcustomerTableAdapter.ClearBeforeFill = true;
            // 
            // Customer
            // 
            this.Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.Customer.DataSource = this.vcustomerBindingSource;
            this.Customer.DisplayMember = "fullname";
            this.Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customer.ForeColor = System.Drawing.Color.White;
            this.Customer.FormattingEnabled = true;
            this.Customer.Location = new System.Drawing.Point(131, 138);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(192, 21);
            this.Customer.TabIndex = 56;
            this.Customer.ValueMember = "Id_customer";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.panel3.Location = new System.Drawing.Point(34, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 1);
            this.panel3.TabIndex = 67;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.panel2.Location = new System.Drawing.Point(34, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 1);
            this.panel2.TabIndex = 68;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.panel1.Location = new System.Drawing.Point(34, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 1);
            this.panel1.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.label5.Location = new System.Drawing.Point(30, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 65;
            this.label5.Text = "Владелец";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.label6.Location = new System.Drawing.Point(30, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 64;
            this.label6.Text = "Гос.Номер";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.label7.Location = new System.Drawing.Point(30, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 63;
            this.label7.Text = "Модель";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.label8.Location = new System.Drawing.Point(30, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 62;
            this.label8.Text = "Марка";
            // 
            // Gov_numb
            // 
            this.Gov_numb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.Gov_numb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Gov_numb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Gov_numb.ForeColor = System.Drawing.Color.White;
            this.Gov_numb.Location = new System.Drawing.Point(131, 98);
            this.Gov_numb.MaxLength = 100;
            this.Gov_numb.Name = "Gov_numb";
            this.Gov_numb.Size = new System.Drawing.Size(192, 16);
            this.Gov_numb.TabIndex = 61;
            // 
            // Model
            // 
            this.Model.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.Model.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Model.ForeColor = System.Drawing.Color.White;
            this.Model.Location = new System.Drawing.Point(131, 62);
            this.Model.MaxLength = 100;
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(192, 16);
            this.Model.TabIndex = 60;
            // 
            // Brand
            // 
            this.Brand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.Brand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Brand.ForeColor = System.Drawing.Color.White;
            this.Brand.Location = new System.Drawing.Point(131, 24);
            this.Brand.MaxLength = 100;
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(192, 16);
            this.Brand.TabIndex = 59;
            // 
            // Back_c
            // 
            this.Back_c.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_c.FlatAppearance.BorderSize = 0;
            this.Back_c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_c.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Back_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_c.ForeColor = System.Drawing.Color.White;
            this.Back_c.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.Back_c.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.Back_c.IconSize = 35;
            this.Back_c.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Back_c.Location = new System.Drawing.Point(33, 171);
            this.Back_c.Name = "Back_c";
            this.Back_c.Rotation = 0D;
            this.Back_c.Size = new System.Drawing.Size(52, 60);
            this.Back_c.TabIndex = 58;
            this.Back_c.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Back_c.UseVisualStyleBackColor = true;
            this.Back_c.Click += new System.EventHandler(this.Back_c_Click);
            // 
            // Save
            // 
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.Save.Location = new System.Drawing.Point(201, 183);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(122, 37);
            this.Save.TabIndex = 57;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.maskedTextBox1.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox1.HidePromptOnLeave = true;
            this.maskedTextBox1.Location = new System.Drawing.Point(91, 220);
            this.maskedTextBox1.Mask = "L000LLL000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 16);
            this.maskedTextBox1.TabIndex = 69;
            // 
            // CarEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(362, 248);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Gov_numb);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.Back_c);
            this.Controls.Add(this.Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CarEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование автомобиля";
            this.Load += new System.EventHandler(this.CarEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vcustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garageDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GarageDataSet garageDataSet;
        private System.Windows.Forms.BindingSource vcustomerBindingSource;
        private GarageDataSetTableAdapters.vcustomerTableAdapter vcustomerTableAdapter;
        private System.Windows.Forms.ComboBox Customer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Gov_numb;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.TextBox Brand;
        private FontAwesome.Sharp.IconButton Back_c;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}