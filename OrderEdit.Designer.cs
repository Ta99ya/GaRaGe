namespace GARAGE
{
    partial class OrderEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderEdit));
            this.label4 = new System.Windows.Forms.Label();
            this.Car = new System.Windows.Forms.ComboBox();
            this.vcarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.garageDataSet = new GARAGE.GarageDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.Staff = new System.Windows.Forms.ComboBox();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Date_Plan = new System.Windows.Forms.DateTimePicker();
            this.Date_Complete = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Note = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.dataGridViewService = new System.Windows.Forms.DataGridView();
            this.idorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idserviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ServiceListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Id_staff = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.qntyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuOrderService = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.ServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new GARAGE.GarageDataSetTableAdapters.staffTableAdapter();
            this.vcar1TableAdapter = new GARAGE.GarageDataSetTableAdapters.vcar1TableAdapter();
            this.order_serviceTableAdapter = new GARAGE.GarageDataSetTableAdapters.order_serviceTableAdapter();
            this.serviceTableAdapter = new GARAGE.GarageDataSetTableAdapters.serviceTableAdapter();
            this.ServiceSUM = new System.Windows.Forms.TextBox();
            this.OrderSUM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_PartsTableAdapter = new GARAGE.GarageDataSetTableAdapters.order_PartsTableAdapter();
            this.PartsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vPartsTableAdapter = new GARAGE.GarageDataSetTableAdapters.vPartsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idorderDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Parts = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.qntyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuOrderParts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteOrderParts = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.PartsSUM = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Back_c = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.vcarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceListBindingSource)).BeginInit();
            this.MenuOrderService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.MenuOrderParts.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.label4.Location = new System.Drawing.Point(23, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Автомобиль";
            // 
            // Car
            // 
            this.Car.DataSource = this.vcarBindingSource;
            this.Car.DisplayMember = "car_name";
            this.Car.FormattingEnabled = true;
            this.Car.Location = new System.Drawing.Point(140, 85);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(200, 21);
            this.Car.TabIndex = 2;
            this.Car.ValueMember = "Id_car";
            // 
            // vcarBindingSource
            // 
            this.vcarBindingSource.DataMember = "vcar1";
            this.vcarBindingSource.DataSource = this.garageDataSet;
            // 
            // garageDataSet
            // 
            this.garageDataSet.DataSetName = "GarageDataSet";
            this.garageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.label1.Location = new System.Drawing.Point(23, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Мастер-приемщик:";
            // 
            // Staff
            // 
            this.Staff.DataSource = this.staffBindingSource;
            this.Staff.DisplayMember = "Name";
            this.Staff.FormattingEnabled = true;
            this.Staff.Location = new System.Drawing.Point(140, 113);
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(200, 21);
            this.Staff.TabIndex = 3;
            this.Staff.ValueMember = "Id_staff";
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.garageDataSet;
            // 
            // Date_Plan
            // 
            this.Date_Plan.CustomFormat = "dd.MM.yyyy HH:mm";
            this.Date_Plan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_Plan.Location = new System.Drawing.Point(140, 31);
            this.Date_Plan.Name = "Date_Plan";
            this.Date_Plan.Size = new System.Drawing.Size(121, 20);
            this.Date_Plan.TabIndex = 0;
            this.Date_Plan.Value = new System.DateTime(2020, 6, 8, 13, 30, 0, 0);
            this.Date_Plan.ValueChanged += new System.EventHandler(this.Date_Plan_ValueChanged);
            // 
            // Date_Complete
            // 
            this.Date_Complete.CustomFormat = "dd.MM.yyyy HH:mm";
            this.Date_Complete.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_Complete.Location = new System.Drawing.Point(140, 58);
            this.Date_Complete.Name = "Date_Complete";
            this.Date_Complete.Size = new System.Drawing.Size(121, 20);
            this.Date_Complete.TabIndex = 1;
            this.Date_Complete.Value = new System.DateTime(2020, 6, 8, 13, 30, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.label2.Location = new System.Drawing.Point(23, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Дата, время план";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.label3.Location = new System.Drawing.Point(23, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Дата, время факт";
            // 
            // Status
            // 
            this.Status.FormattingEnabled = true;
            this.Status.Location = new System.Drawing.Point(471, 29);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(197, 21);
            this.Status.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.label5.Location = new System.Drawing.Point(386, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Статус:";
            // 
            // Note
            // 
            this.Note.Location = new System.Drawing.Point(471, 87);
            this.Note.MaxLength = 200;
            this.Note.Multiline = true;
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(197, 71);
            this.Note.TabIndex = 5;
            this.Note.TextChanged += new System.EventHandler(this.Note_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.label6.Location = new System.Drawing.Point(386, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Примечание:";
            // 
            // OK
            // 
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK.Location = new System.Drawing.Point(549, 618);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(122, 37);
            this.OK.TabIndex = 8;
            this.OK.Text = "Сохранить";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // dataGridViewService
            // 
            this.dataGridViewService.AllowUserToOrderColumns = true;
            this.dataGridViewService.AutoGenerateColumns = false;
            this.dataGridViewService.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.dataGridViewService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewService.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewService.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewService.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idorderDataGridViewTextBoxColumn,
            this.idserviceDataGridViewTextBoxColumn,
            this.Id_staff,
            this.qntyDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridViewService.ContextMenuStrip = this.MenuOrderService;
            this.dataGridViewService.DataSource = this.ServiceBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewService.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewService.EnableHeadersVisualStyles = false;
            this.dataGridViewService.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewService.Location = new System.Drawing.Point(20, 206);
            this.dataGridViewService.Name = "dataGridViewService";
            this.dataGridViewService.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewService.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewService.Size = new System.Drawing.Size(648, 124);
            this.dataGridViewService.TabIndex = 6;
            this.dataGridViewService.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewService_CellValueChanged);
            this.dataGridViewService.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewService_DataError);
            this.dataGridViewService.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewService_DefaultValuesNeeded);
            // 
            // idorderDataGridViewTextBoxColumn
            // 
            this.idorderDataGridViewTextBoxColumn.DataPropertyName = "Id_order";
            this.idorderDataGridViewTextBoxColumn.HeaderText = "Id_order";
            this.idorderDataGridViewTextBoxColumn.Name = "idorderDataGridViewTextBoxColumn";
            this.idorderDataGridViewTextBoxColumn.Visible = false;
            this.idorderDataGridViewTextBoxColumn.Width = 80;
            // 
            // idserviceDataGridViewTextBoxColumn
            // 
            this.idserviceDataGridViewTextBoxColumn.DataPropertyName = "Id_service";
            this.idserviceDataGridViewTextBoxColumn.DataSource = this.ServiceListBindingSource;
            this.idserviceDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.idserviceDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idserviceDataGridViewTextBoxColumn.HeaderText = "Работа";
            this.idserviceDataGridViewTextBoxColumn.Name = "idserviceDataGridViewTextBoxColumn";
            this.idserviceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idserviceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idserviceDataGridViewTextBoxColumn.ValueMember = "Id_service";
            this.idserviceDataGridViewTextBoxColumn.Width = 220;
            // 
            // ServiceListBindingSource
            // 
            this.ServiceListBindingSource.DataMember = "service";
            this.ServiceListBindingSource.DataSource = this.garageDataSet;
            // 
            // Id_staff
            // 
            this.Id_staff.DataPropertyName = "Id_staff";
            this.Id_staff.DataSource = this.staffBindingSource;
            this.Id_staff.DisplayMember = "Name";
            this.Id_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Id_staff.HeaderText = "Сотрудник";
            this.Id_staff.Name = "Id_staff";
            this.Id_staff.ValueMember = "Id_staff";
            this.Id_staff.Width = 220;
            // 
            // qntyDataGridViewTextBoxColumn
            // 
            this.qntyDataGridViewTextBoxColumn.DataPropertyName = "Qnty";
            this.qntyDataGridViewTextBoxColumn.HeaderText = "Кол-во";
            this.qntyDataGridViewTextBoxColumn.Name = "qntyDataGridViewTextBoxColumn";
            this.qntyDataGridViewTextBoxColumn.Width = 60;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // MenuOrderService
            // 
            this.MenuOrderService.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Delete});
            this.MenuOrderService.Name = "MenuOrderService";
            this.MenuOrderService.Size = new System.Drawing.Size(119, 26);
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(118, 22);
            this.Delete.Text = "Удалить";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ServiceBindingSource
            // 
            this.ServiceBindingSource.DataMember = "order_service";
            this.ServiceBindingSource.DataSource = this.garageDataSet;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // vcar1TableAdapter
            // 
            this.vcar1TableAdapter.ClearBeforeFill = true;
            // 
            // order_serviceTableAdapter
            // 
            this.order_serviceTableAdapter.ClearBeforeFill = true;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // ServiceSUM
            // 
            this.ServiceSUM.Location = new System.Drawing.Point(557, 171);
            this.ServiceSUM.Name = "ServiceSUM";
            this.ServiceSUM.ReadOnly = true;
            this.ServiceSUM.Size = new System.Drawing.Size(111, 20);
            this.ServiceSUM.TabIndex = 56;
            this.ServiceSUM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // OrderSUM
            // 
            this.OrderSUM.Location = new System.Drawing.Point(140, 141);
            this.OrderSUM.Name = "OrderSUM";
            this.OrderSUM.ReadOnly = true;
            this.OrderSUM.Size = new System.Drawing.Size(200, 20);
            this.OrderSUM.TabIndex = 57;
            this.OrderSUM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Перечень работ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.label9.Location = new System.Drawing.Point(23, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Стоимость заказа:";
            // 
            // PartsBindingSource
            // 
            this.PartsBindingSource.DataMember = "order_Parts";
            this.PartsBindingSource.DataSource = this.garageDataSet;
            // 
            // order_PartsTableAdapter
            // 
            this.order_PartsTableAdapter.ClearBeforeFill = true;
            // 
            // PartsListBindingSource
            // 
            this.PartsListBindingSource.DataMember = "vParts";
            this.PartsListBindingSource.DataSource = this.garageDataSet;
            // 
            // vPartsTableAdapter
            // 
            this.vPartsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idorderDataGridViewTextBoxColumn1,
            this.Id_Parts,
            this.qntyDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1});
            this.dataGridView1.ContextMenuStrip = this.MenuOrderParts;
            this.dataGridView1.DataSource = this.PartsBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(20, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(425, 112);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            // 
            // idorderDataGridViewTextBoxColumn1
            // 
            this.idorderDataGridViewTextBoxColumn1.DataPropertyName = "Id_order";
            this.idorderDataGridViewTextBoxColumn1.HeaderText = "Id_order";
            this.idorderDataGridViewTextBoxColumn1.Name = "idorderDataGridViewTextBoxColumn1";
            this.idorderDataGridViewTextBoxColumn1.Visible = false;
            // 
            // Id_Parts
            // 
            this.Id_Parts.DataPropertyName = "Id_Parts";
            this.Id_Parts.DataSource = this.PartsListBindingSource;
            this.Id_Parts.DisplayMember = "Name";
            this.Id_Parts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Id_Parts.HeaderText = "Наименование";
            this.Id_Parts.Name = "Id_Parts";
            this.Id_Parts.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id_Parts.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Id_Parts.ValueMember = "Id_Parts";
            this.Id_Parts.Width = 220;
            // 
            // qntyDataGridViewTextBoxColumn1
            // 
            this.qntyDataGridViewTextBoxColumn1.DataPropertyName = "Qnty";
            this.qntyDataGridViewTextBoxColumn1.HeaderText = "Кол-во";
            this.qntyDataGridViewTextBoxColumn1.Name = "qntyDataGridViewTextBoxColumn1";
            this.qntyDataGridViewTextBoxColumn1.Width = 60;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            // 
            // MenuOrderParts
            // 
            this.MenuOrderParts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteOrderParts});
            this.MenuOrderParts.Name = "MenuOrderParts";
            this.MenuOrderParts.Size = new System.Drawing.Size(119, 26);
            // 
            // DeleteOrderParts
            // 
            this.DeleteOrderParts.Name = "DeleteOrderParts";
            this.DeleteOrderParts.Size = new System.Drawing.Size(118, 22);
            this.DeleteOrderParts.Text = "Удалить";
            this.DeleteOrderParts.Click += new System.EventHandler(this.DeleteOrderParts_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.label7.Location = new System.Drawing.Point(23, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Перечень запчастей";
            // 
            // PartsSUM
            // 
            this.PartsSUM.Location = new System.Drawing.Point(557, 170);
            this.PartsSUM.Name = "PartsSUM";
            this.PartsSUM.ReadOnly = true;
            this.PartsSUM.Size = new System.Drawing.Size(111, 20);
            this.PartsSUM.TabIndex = 63;
            this.PartsSUM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(449, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 64;
            this.label10.Text = "Стоимость итого";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(449, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 65;
            this.label11.Text = "Стоимость итого";
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
            this.Back_c.Location = new System.Drawing.Point(12, 606);
            this.Back_c.Name = "Back_c";
            this.Back_c.Rotation = 0D;
            this.Back_c.Size = new System.Drawing.Size(52, 60);
            this.Back_c.TabIndex = 67;
            this.Back_c.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Back_c.UseVisualStyleBackColor = true;
            this.Back_c.Click += new System.EventHandler(this.Back_c_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.ServiceSUM);
            this.panel3.Location = new System.Drawing.Point(0, 176);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(717, 204);
            this.panel3.TabIndex = 68;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.PartsSUM);
            this.panel4.Location = new System.Drawing.Point(0, 396);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(728, 204);
            this.panel4.TabIndex = 69;
            // 
            // OrderEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(706, 675);
            this.Controls.Add(this.Back_c);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.OrderSUM);
            this.Controls.Add(this.dataGridViewService);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Date_Complete);
            this.Controls.Add(this.Date_Plan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Staff);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование заказа";
            this.Load += new System.EventHandler(this.OrderEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vcarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceListBindingSource)).EndInit();
            this.MenuOrderService.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.MenuOrderParts.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Car;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Staff;
        private GarageDataSet garageDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private GarageDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private System.Windows.Forms.DateTimePicker Date_Plan;
        private System.Windows.Forms.DateTimePicker Date_Complete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Note;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.BindingSource vcarBindingSource;
        private GarageDataSetTableAdapters.vcar1TableAdapter vcar1TableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewService;
        private System.Windows.Forms.BindingSource ServiceBindingSource;
        private GarageDataSetTableAdapters.order_serviceTableAdapter order_serviceTableAdapter;
        private System.Windows.Forms.BindingSource ServiceListBindingSource;
        private GarageDataSetTableAdapters.serviceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.TextBox ServiceSUM;
        private System.Windows.Forms.TextBox OrderSUM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn idorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idserviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Id_staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn qntyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource PartsBindingSource;
        private GarageDataSetTableAdapters.order_PartsTableAdapter order_PartsTableAdapter;
        private System.Windows.Forms.BindingSource PartsListBindingSource;
        private GarageDataSetTableAdapters.vPartsTableAdapter vPartsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idorderDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Id_Parts;
        private System.Windows.Forms.DataGridViewTextBoxColumn qntyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PartsSUM;
        private System.Windows.Forms.ContextMenuStrip MenuOrderService;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ContextMenuStrip MenuOrderParts;
        private System.Windows.Forms.ToolStripMenuItem DeleteOrderParts;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton Back_c;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}