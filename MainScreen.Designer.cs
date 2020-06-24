namespace GARAGE
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Date = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.setting_button = new System.Windows.Forms.Button();
            this.notif_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.profile = new System.Windows.Forms.Button();
            this.Work = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.label1.Location = new System.Drawing.Point(119, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 76);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(94, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 2);
            this.panel1.TabIndex = 8;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.BackColor = System.Drawing.Color.Transparent;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.Date.ForeColor = System.Drawing.Color.White;
            this.Date.Location = new System.Drawing.Point(126, 315);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(132, 47);
            this.Date.TabIndex = 42;
            this.Date.Text = "label2";
            this.Date.Click += new System.EventHandler(this.Date_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.iconButton3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 64);
            this.panel2.TabIndex = 48;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(479, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Яковлев М.";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(77, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 40);
            this.button2.TabIndex = 48;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconSize = 16;
            this.iconButton1.Location = new System.Drawing.Point(709, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(30, 23);
            this.iconButton1.TabIndex = 40;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 40);
            this.button1.TabIndex = 47;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // iconButton3
            // 
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconSize = 16;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton3.Location = new System.Drawing.Point(673, 3);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(30, 23);
            this.iconButton3.TabIndex = 41;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(581, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // setting_button
            // 
            this.setting_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setting_button.FlatAppearance.BorderSize = 0;
            this.setting_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setting_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.setting_button.ForeColor = System.Drawing.Color.White;
            this.setting_button.Image = global::GARAGE.Properties.Resources.admin_settings_male_50px_white;
            this.setting_button.Location = new System.Drawing.Point(358, 104);
            this.setting_button.Name = "setting_button";
            this.setting_button.Size = new System.Drawing.Size(125, 78);
            this.setting_button.TabIndex = 7;
            this.setting_button.Text = "Настройки";
            this.setting_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.setting_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.setting_button.UseVisualStyleBackColor = true;
            this.setting_button.Click += new System.EventHandler(this.setting_button_Click);
            // 
            // notif_button
            // 
            this.notif_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notif_button.FlatAppearance.BorderSize = 0;
            this.notif_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notif_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.notif_button.ForeColor = System.Drawing.Color.White;
            this.notif_button.Image = global::GARAGE.Properties.Resources.alarms_50px_white;
            this.notif_button.Location = new System.Drawing.Point(487, 104);
            this.notif_button.Name = "notif_button";
            this.notif_button.Size = new System.Drawing.Size(125, 78);
            this.notif_button.TabIndex = 6;
            this.notif_button.Text = "Уведомления";
            this.notif_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.notif_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.notif_button.UseVisualStyleBackColor = true;
            // 
            // exit_button
            // 
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.exit_button.ForeColor = System.Drawing.Color.White;
            this.exit_button.Image = global::GARAGE.Properties.Resources.logout_rounded_left_50px_white;
            this.exit_button.Location = new System.Drawing.Point(102, 104);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(125, 78);
            this.exit_button.TabIndex = 5;
            this.exit_button.Text = "Выход";
            this.exit_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // profile
            // 
            this.profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile.FlatAppearance.BorderSize = 0;
            this.profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.profile.ForeColor = System.Drawing.Color.White;
            this.profile.Image = global::GARAGE.Properties.Resources.resume_website_55px_white;
            this.profile.Location = new System.Drawing.Point(229, 104);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(125, 78);
            this.profile.TabIndex = 4;
            this.profile.Text = "Профиль";
            this.profile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.profile.UseVisualStyleBackColor = true;
            this.profile.Click += new System.EventHandler(this.button1_Click);
            // 
            // Work
            // 
            this.Work.FlatAppearance.BorderSize = 0;
            this.Work.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Work.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Work.ForeColor = System.Drawing.Color.White;
            this.Work.Image = ((System.Drawing.Image)(resources.GetObject("Work.Image")));
            this.Work.Location = new System.Drawing.Point(93, 393);
            this.Work.Name = "Work";
            this.Work.Size = new System.Drawing.Size(279, 167);
            this.Work.TabIndex = 1;
            this.Work.Text = "Оформление заказ-нарядов";
            this.Work.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Work.UseVisualStyleBackColor = true;
            this.Work.Click += new System.EventHandler(this.Work_Click);
            // 
            // Admin
            // 
            this.Admin.FlatAppearance.BorderSize = 0;
            this.Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Admin.ForeColor = System.Drawing.Color.White;
            this.Admin.Image = ((System.Drawing.Image)(resources.GetObject("Admin.Image")));
            this.Admin.Location = new System.Drawing.Point(390, 393);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(257, 167);
            this.Admin.TabIndex = 0;
            this.Admin.Text = "Администрирование";
            this.Admin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(742, 607);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.setting_button);
            this.Controls.Add(this.notif_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Work);
            this.Controls.Add(this.Admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление автосервисом";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.Button Work;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button profile;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button notif_button;
        private System.Windows.Forms.Button setting_button;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}