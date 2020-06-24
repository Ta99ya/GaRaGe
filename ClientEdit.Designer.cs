namespace GARAGE
{
    partial class ClientEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientEdit));
            this.Back_c = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PatrName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
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
            this.Back_c.Location = new System.Drawing.Point(33, 193);
            this.Back_c.Name = "Back_c";
            this.Back_c.Rotation = 0D;
            this.Back_c.Size = new System.Drawing.Size(52, 60);
            this.Back_c.TabIndex = 36;
            this.Back_c.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Back_c.UseVisualStyleBackColor = true;
            this.Back_c.Click += new System.EventHandler(this.Back_c_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.panel4.Location = new System.Drawing.Point(34, 178);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(289, 1);
            this.panel4.TabIndex = 33;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.panel3.Location = new System.Drawing.Point(34, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 1);
            this.panel3.TabIndex = 34;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.panel2.Location = new System.Drawing.Point(34, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 1);
            this.panel2.TabIndex = 35;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.panel1.Location = new System.Drawing.Point(34, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 1);
            this.panel1.TabIndex = 32;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Save
            // 
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.Save.Location = new System.Drawing.Point(201, 205);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(122, 37);
            this.Save.TabIndex = 31;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.label5.Location = new System.Drawing.Point(30, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Телефон";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.label6.Location = new System.Drawing.Point(30, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Отчество";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.label7.Location = new System.Drawing.Point(30, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Фамилия";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.label8.Location = new System.Drawing.Point(30, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Имя";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // PatrName
            // 
            this.PatrName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.PatrName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.PatrName.ForeColor = System.Drawing.Color.White;
            this.PatrName.Location = new System.Drawing.Point(110, 119);
            this.PatrName.MaxLength = 100;
            this.PatrName.Name = "PatrName";
            this.PatrName.Size = new System.Drawing.Size(192, 16);
            this.PatrName.TabIndex = 25;
            this.PatrName.TextChanged += new System.EventHandler(this.PatrName_TextChanged);
            // 
            // LastName
            // 
            this.LastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.LastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LastName.ForeColor = System.Drawing.Color.White;
            this.LastName.Location = new System.Drawing.Point(110, 81);
            this.LastName.MaxLength = 100;
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(192, 16);
            this.LastName.TabIndex = 24;
            this.LastName.TextChanged += new System.EventHandler(this.LastName_TextChanged);
            // 
            // Name
            // 
            this.Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Name.ForeColor = System.Drawing.Color.White;
            this.Name.Location = new System.Drawing.Point(110, 45);
            this.Name.MaxLength = 100;
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(192, 16);
            this.Name.TabIndex = 23;
            this.Name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // Phone
            // 
            this.Phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.Phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Phone.ForeColor = System.Drawing.Color.White;
            this.Phone.Location = new System.Drawing.Point(162, 156);
            this.Phone.Mask = "+0 (999) 000-00-00";
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(140, 16);
            this.Phone.TabIndex = 37;
            // 
            // ClientEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(349, 265);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Back_c);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PatrName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование клиента";
            this.Load += new System.EventHandler(this.ClientEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton Back_c;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PatrName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.MaskedTextBox Phone;
    }
}