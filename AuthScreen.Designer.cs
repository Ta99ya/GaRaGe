namespace GARAGE
{
    partial class AuthScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthScreen));
            this.NotFinde = new System.Windows.Forms.Label();
            this.AuthBut = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.MinimizeButton = new FontAwesome.Sharp.IconButton();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NotFinde
            // 
            this.NotFinde.AutoSize = true;
            this.NotFinde.ForeColor = System.Drawing.Color.White;
            this.NotFinde.Location = new System.Drawing.Point(124, 515);
            this.NotFinde.Name = "NotFinde";
            this.NotFinde.Size = new System.Drawing.Size(134, 13);
            this.NotFinde.TabIndex = 5;
            this.NotFinde.Text = "Пользователь не найден";
            // 
            // AuthBut
            // 
            this.AuthBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(205)))));
            this.AuthBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.AuthBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.AuthBut.Location = new System.Drawing.Point(81, 390);
            this.AuthBut.Name = "AuthBut";
            this.AuthBut.Size = new System.Drawing.Size(214, 46);
            this.AuthBut.TabIndex = 21;
            this.AuthBut.Text = "Авторизация";
            this.AuthBut.UseVisualStyleBackColor = false;
            this.AuthBut.Click += new System.EventHandler(this.AuthBut_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(81, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 37);
            this.button2.TabIndex = 20;
            this.button2.Text = "Регистрация";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(81, 358);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 1);
            this.panel2.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(80, 299);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 1);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(111, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Password.ForeColor = System.Drawing.Color.White;
            this.Password.HideSelection = false;
            this.Password.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Password.Location = new System.Drawing.Point(118, 333);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(175, 19);
            this.Password.TabIndex = 16;
            this.Password.TabStop = false;
            this.Password.Text = "Пароль";
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.HideSelection = false;
            this.Login.Location = new System.Drawing.Point(118, 274);
            this.Login.Name = "Login";
            this.Login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Login.Size = new System.Drawing.Size(177, 19);
            this.Login.TabIndex = 15;
            this.Login.TabStop = false;
            this.Login.Text = "Логин";
            this.Login.Click += new System.EventHandler(this.Login_Click);
            this.Login.TextChanged += new System.EventHandler(this.Login_TextChanged);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.Location = new System.Drawing.Point(80, 322);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 23;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.Location = new System.Drawing.Point(80, 265);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 22;
            this.iconPictureBox1.TabStop = false;
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
            this.MinimizeButton.Location = new System.Drawing.Point(305, 4);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Rotation = 0D;
            this.MinimizeButton.Size = new System.Drawing.Size(30, 23);
            this.MinimizeButton.TabIndex = 43;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.ExitButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ExitButton.IconColor = System.Drawing.Color.White;
            this.ExitButton.IconSize = 16;
            this.ExitButton.Location = new System.Drawing.Point(341, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Rotation = 0D;
            this.ExitButton.Size = new System.Drawing.Size(30, 23);
            this.ExitButton.TabIndex = 42;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AuthScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(374, 578);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.AuthBut);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.NotFinde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.AuthScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NotFinde;
        private System.Windows.Forms.Button AuthBut;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Login;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton MinimizeButton;
        private FontAwesome.Sharp.IconButton ExitButton;
    }
}