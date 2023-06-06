namespace ROV_TL.AdminForms
{
    partial class AdminProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProfileForm));
            panel1 = new Panel();
            ViosLabel = new Label();
            AdminProfileLabel = new Label();
            panel3 = new Panel();
            CarsLabel = new Label();
            panel2 = new Panel();
            ROVLabel = new Label();
            AdminsLabel = new Label();
            UsersLabel = new Label();
            AcessPictureBox_2 = new PictureBox();
            AcessPictureBox_3 = new PictureBox();
            AcessPictureBox_1 = new PictureBox();
            ExitPictureBox = new PictureBox();
            ConfirmDataButton = new Button();
            ChangeDataButton = new Button();
            PasswordTextBox = new TextBox();
            StaticPasswordLabel = new Label();
            EmailTextBox = new TextBox();
            LoginTextBox = new TextBox();
            StaticEmailLabel = new Label();
            StaticLoginLabel = new Label();
            WelcomeLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AcessPictureBox_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AcessPictureBox_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AcessPictureBox_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExitPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(ViosLabel);
            panel1.Controls.Add(AdminProfileLabel);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(CarsLabel);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(ROVLabel);
            panel1.Controls.Add(AdminsLabel);
            panel1.Controls.Add(UsersLabel);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(173, 460);
            panel1.TabIndex = 18;
            // 
            // ViosLabel
            // 
            ViosLabel.AutoSize = true;
            ViosLabel.Cursor = Cursors.Hand;
            ViosLabel.ForeColor = Color.Black;
            ViosLabel.Location = new Point(11, 216);
            ViosLabel.Margin = new Padding(5, 0, 5, 0);
            ViosLabel.Name = "ViosLabel";
            ViosLabel.Size = new Size(119, 29);
            ViosLabel.TabIndex = 11;
            ViosLabel.Text = "Нарушения";
            ViosLabel.Click += ViosLabel_Click;
            // 
            // AdminProfileLabel
            // 
            AdminProfileLabel.AutoSize = true;
            AdminProfileLabel.ForeColor = Color.Black;
            AdminProfileLabel.Location = new Point(47, 62);
            AdminProfileLabel.Margin = new Padding(5, 0, 5, 0);
            AdminProfileLabel.Name = "AdminProfileLabel";
            AdminProfileLabel.Size = new Size(72, 29);
            AdminProfileLabel.TabIndex = 10;
            AdminProfileLabel.Text = "Admin";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 35, 35);
            panel3.Location = new Point(53, 91);
            panel3.Name = "panel3";
            panel3.Size = new Size(58, 5);
            panel3.TabIndex = 9;
            // 
            // CarsLabel
            // 
            CarsLabel.AutoSize = true;
            CarsLabel.Cursor = Cursors.Hand;
            CarsLabel.ForeColor = Color.Black;
            CarsLabel.Location = new Point(11, 180);
            CarsLabel.Margin = new Padding(5, 0, 5, 0);
            CarsLabel.Name = "CarsLabel";
            CarsLabel.Size = new Size(126, 29);
            CarsLabel.TabIndex = 8;
            CarsLabel.Text = "Автомобили";
            CarsLabel.Click += CarsLabel_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(35, 35, 35);
            panel2.Location = new Point(-2, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(185, 10);
            panel2.TabIndex = 5;
            // 
            // ROVLabel
            // 
            ROVLabel.AutoSize = true;
            ROVLabel.Font = new Font("Bahnschrift SemiCondensed", 36F, FontStyle.Regular, GraphicsUnit.Point);
            ROVLabel.ForeColor = Color.Black;
            ROVLabel.Location = new Point(33, 9);
            ROVLabel.Name = "ROVLabel";
            ROVLabel.Size = new Size(99, 58);
            ROVLabel.TabIndex = 4;
            ROVLabel.Text = "ROV";
            // 
            // AdminsLabel
            // 
            AdminsLabel.AutoSize = true;
            AdminsLabel.Cursor = Cursors.Hand;
            AdminsLabel.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            AdminsLabel.ForeColor = Color.Black;
            AdminsLabel.Location = new Point(11, 109);
            AdminsLabel.Margin = new Padding(5, 0, 5, 0);
            AdminsLabel.Name = "AdminsLabel";
            AdminsLabel.Size = new Size(150, 29);
            AdminsLabel.TabIndex = 2;
            AdminsLabel.Text = "Администраторы";
            AdminsLabel.Click += AdminsLabel_Click;
            // 
            // UsersLabel
            // 
            UsersLabel.AutoSize = true;
            UsersLabel.Cursor = Cursors.Hand;
            UsersLabel.ForeColor = Color.Black;
            UsersLabel.Location = new Point(11, 144);
            UsersLabel.Margin = new Padding(5, 0, 5, 0);
            UsersLabel.Name = "UsersLabel";
            UsersLabel.Size = new Size(142, 29);
            UsersLabel.TabIndex = 3;
            UsersLabel.Text = "Пользователи";
            UsersLabel.Click += UsersLabel_Click;
            // 
            // AcessPictureBox_2
            // 
            AcessPictureBox_2.BackColor = Color.Tan;
            AcessPictureBox_2.Image = Properties.Resources.LockIcon;
            AcessPictureBox_2.Location = new Point(455, 240);
            AcessPictureBox_2.Name = "AcessPictureBox_2";
            AcessPictureBox_2.Size = new Size(25, 31);
            AcessPictureBox_2.SizeMode = PictureBoxSizeMode.Zoom;
            AcessPictureBox_2.TabIndex = 41;
            AcessPictureBox_2.TabStop = false;
            // 
            // AcessPictureBox_3
            // 
            AcessPictureBox_3.BackColor = Color.Tan;
            AcessPictureBox_3.Image = Properties.Resources.LockIcon;
            AcessPictureBox_3.Location = new Point(791, 240);
            AcessPictureBox_3.Name = "AcessPictureBox_3";
            AcessPictureBox_3.Size = new Size(25, 31);
            AcessPictureBox_3.SizeMode = PictureBoxSizeMode.Zoom;
            AcessPictureBox_3.TabIndex = 40;
            AcessPictureBox_3.TabStop = false;
            // 
            // AcessPictureBox_1
            // 
            AcessPictureBox_1.BackColor = Color.Tan;
            AcessPictureBox_1.Image = Properties.Resources.LockIcon;
            AcessPictureBox_1.Location = new Point(791, 140);
            AcessPictureBox_1.Name = "AcessPictureBox_1";
            AcessPictureBox_1.Size = new Size(25, 31);
            AcessPictureBox_1.SizeMode = PictureBoxSizeMode.Zoom;
            AcessPictureBox_1.TabIndex = 39;
            AcessPictureBox_1.TabStop = false;
            // 
            // ExitPictureBox
            // 
            ExitPictureBox.Cursor = Cursors.Hand;
            ExitPictureBox.Image = Properties.Resources.ExitIcon;
            ExitPictureBox.Location = new Point(814, 17);
            ExitPictureBox.Name = "ExitPictureBox";
            ExitPictureBox.Size = new Size(39, 35);
            ExitPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            ExitPictureBox.TabIndex = 37;
            ExitPictureBox.TabStop = false;
            ExitPictureBox.Click += ExitPictureBox_Click;
            // 
            // ConfirmDataButton
            // 
            ConfirmDataButton.BackColor = Color.Tan;
            ConfirmDataButton.Cursor = Cursors.No;
            ConfirmDataButton.Enabled = false;
            ConfirmDataButton.FlatStyle = FlatStyle.Flat;
            ConfirmDataButton.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmDataButton.ForeColor = Color.Black;
            ConfirmDataButton.Location = new Point(546, 306);
            ConfirmDataButton.Name = "ConfirmDataButton";
            ConfirmDataButton.Size = new Size(279, 34);
            ConfirmDataButton.TabIndex = 36;
            ConfirmDataButton.Text = "Подтвердить данные";
            ConfirmDataButton.UseVisualStyleBackColor = false;
            ConfirmDataButton.Click += ConfirmDataButton_Click;
            // 
            // ChangeDataButton
            // 
            ChangeDataButton.BackColor = Color.Tan;
            ChangeDataButton.Cursor = Cursors.Hand;
            ChangeDataButton.FlatStyle = FlatStyle.Flat;
            ChangeDataButton.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ChangeDataButton.ForeColor = Color.Black;
            ChangeDataButton.Location = new Point(211, 306);
            ChangeDataButton.Name = "ChangeDataButton";
            ChangeDataButton.Size = new Size(279, 34);
            ChangeDataButton.TabIndex = 35;
            ChangeDataButton.Text = "Изменить профиль";
            ChangeDataButton.UseVisualStyleBackColor = false;
            ChangeDataButton.Click += ChangeDataButton_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = Color.Tan;
            PasswordTextBox.BorderStyle = BorderStyle.None;
            PasswordTextBox.Font = new Font("Bahnschrift Condensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.Location = new Point(211, 238);
            PasswordTextBox.MaxLength = 20;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PlaceholderText = "Пароль";
            PasswordTextBox.ReadOnly = true;
            PasswordTextBox.Size = new Size(279, 35);
            PasswordTextBox.TabIndex = 33;
            PasswordTextBox.Enter += PasswordTextBox_Enter;
            PasswordTextBox.Leave += PasswordTextBox_Leave;
            // 
            // StaticPasswordLabel
            // 
            StaticPasswordLabel.AutoSize = true;
            StaticPasswordLabel.ForeColor = Color.White;
            StaticPasswordLabel.Location = new Point(205, 202);
            StaticPasswordLabel.Margin = new Padding(5, 0, 5, 0);
            StaticPasswordLabel.Name = "StaticPasswordLabel";
            StaticPasswordLabel.Size = new Size(80, 29);
            StaticPasswordLabel.TabIndex = 32;
            StaticPasswordLabel.Text = "Пароль";
            // 
            // EmailTextBox
            // 
            EmailTextBox.BackColor = Color.Tan;
            EmailTextBox.BorderStyle = BorderStyle.None;
            EmailTextBox.Font = new Font("Bahnschrift Condensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTextBox.Location = new Point(546, 238);
            EmailTextBox.MaxLength = 25;
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.PlaceholderText = "Email";
            EmailTextBox.ReadOnly = true;
            EmailTextBox.Size = new Size(279, 35);
            EmailTextBox.TabIndex = 29;
            // 
            // LoginTextBox
            // 
            LoginTextBox.BackColor = Color.Tan;
            LoginTextBox.BorderStyle = BorderStyle.None;
            LoginTextBox.Font = new Font("Bahnschrift Condensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            LoginTextBox.Location = new Point(211, 138);
            LoginTextBox.MaxLength = 12;
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.PlaceholderText = "Логин";
            LoginTextBox.ReadOnly = true;
            LoginTextBox.Size = new Size(614, 35);
            LoginTextBox.TabIndex = 28;
            // 
            // StaticEmailLabel
            // 
            StaticEmailLabel.AutoSize = true;
            StaticEmailLabel.ForeColor = Color.White;
            StaticEmailLabel.Location = new Point(540, 202);
            StaticEmailLabel.Margin = new Padding(5, 0, 5, 0);
            StaticEmailLabel.Name = "StaticEmailLabel";
            StaticEmailLabel.Size = new Size(65, 29);
            StaticEmailLabel.TabIndex = 26;
            StaticEmailLabel.Text = "Email";
            // 
            // StaticLoginLabel
            // 
            StaticLoginLabel.AutoSize = true;
            StaticLoginLabel.ForeColor = Color.White;
            StaticLoginLabel.Location = new Point(205, 102);
            StaticLoginLabel.Margin = new Padding(5, 0, 5, 0);
            StaticLoginLabel.Name = "StaticLoginLabel";
            StaticLoginLabel.Size = new Size(71, 29);
            StaticLoginLabel.TabIndex = 25;
            StaticLoginLabel.Text = "Логин";
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Bahnschrift SemiCondensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            WelcomeLabel.Location = new Point(211, 33);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(346, 33);
            WelcomeLabel.TabIndex = 42;
            WelcomeLabel.Text = "Добро пожаловать, adminLogin";
            // 
            // AdminProfileForm
            // 
            AutoScaleDimensions = new SizeF(11F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(867, 455);
            Controls.Add(WelcomeLabel);
            Controls.Add(AcessPictureBox_2);
            Controls.Add(AcessPictureBox_3);
            Controls.Add(AcessPictureBox_1);
            Controls.Add(ExitPictureBox);
            Controls.Add(ConfirmDataButton);
            Controls.Add(ChangeDataButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(StaticPasswordLabel);
            Controls.Add(EmailTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(StaticEmailLabel);
            Controls.Add(StaticLoginLabel);
            Controls.Add(panel1);
            Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "AdminProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminProfileForm";
            Load += AdminProfileForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AcessPictureBox_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)AcessPictureBox_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)AcessPictureBox_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExitPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label ViosLabel;
        private Label AdminProfileLabel;
        private Panel panel3;
        private Label CarsLabel;
        private Panel panel2;
        private Label ROVLabel;
        private Label AdminsLabel;
        private Label UsersLabel;
        private PictureBox AcessPictureBox_2;
        private PictureBox AcessPictureBox_3;
        private PictureBox AcessPictureBox_1;
        private PictureBox ExitPictureBox;
        private Button ConfirmDataButton;
        private Button ChangeDataButton;
        private TextBox PasswordTextBox;
        private Label StaticPasswordLabel;
        private TextBox EmailTextBox;
        private TextBox LoginTextBox;
        private Label StaticEmailLabel;
        private Label StaticLoginLabel;
        private Label WelcomeLabel;
    }
}