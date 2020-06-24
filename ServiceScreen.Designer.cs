namespace GARAGE
{
    partial class ServiceScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceScreen));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idserviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.garageDataSet = new GARAGE.GarageDataSet();
            this.serviceTableAdapter = new GARAGE.GarageDataSetTableAdapters.serviceTableAdapter();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.Back_c = new FontAwesome.Sharp.IconButton();
            this.SideBar = new System.Windows.Forms.Panel();
            this.DeleteButton = new MyImageButton.CustomImageButton();
            this.AddButton = new MyImageButton.CustomImageButton();
            this.EditButton = new MyImageButton.CustomImageButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.MinimizeButton = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idserviceDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ServiceBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(96, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(644, 289);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idserviceDataGridViewTextBoxColumn
            // 
            this.idserviceDataGridViewTextBoxColumn.DataPropertyName = "Id_service";
            this.idserviceDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idserviceDataGridViewTextBoxColumn.Name = "idserviceDataGridViewTextBoxColumn";
            this.idserviceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 400;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ServiceBindingSource
            // 
            this.ServiceBindingSource.DataMember = "service";
            this.ServiceBindingSource.DataSource = this.garageDataSet;
            // 
            // garageDataSet
            // 
            this.garageDataSet.DataSetName = "GarageDataSet";
            this.garageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.ExitButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ExitButton.IconColor = System.Drawing.Color.White;
            this.ExitButton.IconSize = 16;
            this.ExitButton.Location = new System.Drawing.Point(731, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Rotation = 0D;
            this.ExitButton.Size = new System.Drawing.Size(30, 23);
            this.ExitButton.TabIndex = 40;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(615, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(513, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Яковлев М.";
            // 
            // textSearch
            // 
            this.textSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.textSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textSearch.ForeColor = System.Drawing.Color.White;
            this.textSearch.Location = new System.Drawing.Point(134, 112);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(538, 19);
            this.textSearch.TabIndex = 35;
            this.textSearch.Text = "Поиск";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.panel4.Location = new System.Drawing.Point(96, 137);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(699, 1);
            this.panel4.TabIndex = 34;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.button3.Location = new System.Drawing.Point(343, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 23);
            this.button3.TabIndex = 33;
            this.button3.Text = "Дороже 10 тысяч";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.Location = new System.Drawing.Point(199, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "Дешевле 10 тысяч";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(96, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Все";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.iconPictureBox1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.iconPictureBox1.Location = new System.Drawing.Point(96, 103);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 30;
            this.iconPictureBox1.TabStop = false;
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
            this.Back_c.Location = new System.Drawing.Point(4, 443);
            this.Back_c.Name = "Back_c";
            this.Back_c.Rotation = 0D;
            this.Back_c.Size = new System.Drawing.Size(52, 60);
            this.Back_c.TabIndex = 7;
            this.Back_c.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Back_c.UseVisualStyleBackColor = true;
            this.Back_c.Click += new System.EventHandler(this.Back_c_Click);
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SideBar.Controls.Add(this.DeleteButton);
            this.SideBar.Controls.Add(this.AddButton);
            this.SideBar.Controls.Add(this.EditButton);
            this.SideBar.Controls.Add(this.Back_c);
            this.SideBar.Controls.Add(this.iconButton1);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(56, 531);
            this.SideBar.TabIndex = 28;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageHover = ((System.Drawing.Image)(resources.GetObject("DeleteButton.ImageHover")));
            this.DeleteButton.ImageNormal = ((System.Drawing.Image)(resources.GetObject("DeleteButton.ImageNormal")));
            this.DeleteButton.Location = new System.Drawing.Point(5, 235);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(49, 48);
            this.DeleteButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.TabStop = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageHover = ((System.Drawing.Image)(resources.GetObject("AddButton.ImageHover")));
            this.AddButton.ImageNormal = ((System.Drawing.Image)(resources.GetObject("AddButton.ImageNormal")));
            this.AddButton.Location = new System.Drawing.Point(4, 137);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(49, 48);
            this.AddButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddButton.TabIndex = 9;
            this.AddButton.TabStop = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.ImageHover = ((System.Drawing.Image)(resources.GetObject("EditButton.ImageHover")));
            this.EditButton.ImageNormal = ((System.Drawing.Image)(resources.GetObject("EditButton.ImageNormal")));
            this.EditButton.Location = new System.Drawing.Point(5, 333);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(49, 48);
            this.EditButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EditButton.TabIndex = 8;
            this.EditButton.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(-2, 15);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(58, 39);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.MinimizeButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.MinimizeButton.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.MinimizeButton.IconColor = System.Drawing.Color.White;
            this.MinimizeButton.IconSize = 16;
            this.MinimizeButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MinimizeButton.Location = new System.Drawing.Point(695, 3);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Rotation = 0D;
            this.MinimizeButton.Size = new System.Drawing.Size(30, 23);
            this.MinimizeButton.TabIndex = 41;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.MinimizeButton);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(56, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 66);
            this.panel1.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(656, 309);
            this.panel3.TabIndex = 1;
            // 
            // ServiceScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(822, 531);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServiceScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работы";
            this.Load += new System.EventHandler(this.ServiceScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.SideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DeleteButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ServiceBindingSource;
        private GarageDataSet garageDataSet;
        private GarageDataSetTableAdapters.serviceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idserviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private FontAwesome.Sharp.IconButton ExitButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private MyImageButton.CustomImageButton DeleteButton;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private MyImageButton.CustomImageButton EditButton;
        private FontAwesome.Sharp.IconButton Back_c;
        private System.Windows.Forms.Panel SideBar;
        private MyImageButton.CustomImageButton AddButton;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton MinimizeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
    }
}