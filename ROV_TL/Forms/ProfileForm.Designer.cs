namespace ROV_TL
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            VioLabel = new Label();
            ProfileLabel = new Label();
            StaticLoginLabel = new Label();
            StaticEmailLabel = new Label();
            BalanceLabel = new Label();
            CarInfoLabel = new Label();
            panel1 = new Panel();
            UserNameLabel = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            ROVLabel = new Label();
            LoginTextBox = new TextBox();
            EmailTextBox = new TextBox();
            FioTextBox = new TextBox();
            StaticFioLabel = new Label();
            PasswordTextBox = new TextBox();
            StaticPasswordLabel = new Label();
            StaticBalanceLabel = new Label();
            ChangeDataButton = new Button();
            ConfirmDataButton = new Button();
            ExitPictureBox = new PictureBox();
            UpdatePictureBox = new PictureBox();
            AcessPictureBox_1 = new PictureBox();
            AcessPictureBox_3 = new PictureBox();
            AcessPictureBox_4 = new PictureBox();
            AcessPictureBox_2 = new PictureBox();
            AddBalanceButton = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExitPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpdatePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AcessPictureBox_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AcessPictureBox_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AcessPictureBox_4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AcessPictureBox_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddBalanceButton).BeginInit();
            SuspendLayout();
            // 
            // VioLabel
            // 
            VioLabel.AutoSize = true;
            VioLabel.Cursor = Cursors.Hand;
            VioLabel.Location = new Point(11, 139);
            VioLabel.Margin = new Padding(5, 0, 5, 0);
            VioLabel.Name = "VioLabel";
            VioLabel.Size = new Size(93, 29);
            VioLabel.TabIndex = 3;
            VioLabel.Text = "Штрафы";
            VioLabel.Click += VioLabel_Click;
            VioLabel.MouseHover += VioLabel_MouseHover;
            // 
            // ProfileLabel
            // 
            ProfileLabel.AutoSize = true;
            ProfileLabel.ForeColor = Color.Black;
            ProfileLabel.Location = new Point(12, 97);
            ProfileLabel.Margin = new Padding(5, 0, 5, 0);
            ProfileLabel.Name = "ProfileLabel";
            ProfileLabel.Size = new Size(98, 29);
            ProfileLabel.TabIndex = 2;
            ProfileLabel.Text = "Профиль";
            ProfileLabel.MouseHover += ProfileLabel_MouseHover;
            // 
            // StaticLoginLabel
            // 
            StaticLoginLabel.AutoSize = true;
            StaticLoginLabel.ForeColor = Color.White;
            StaticLoginLabel.Location = new Point(206, 114);
            StaticLoginLabel.Margin = new Padding(5, 0, 5, 0);
            StaticLoginLabel.Name = "StaticLoginLabel";
            StaticLoginLabel.Size = new Size(71, 29);
            StaticLoginLabel.TabIndex = 4;
            StaticLoginLabel.Text = "Логин";
            // 
            // StaticEmailLabel
            // 
            StaticEmailLabel.AutoSize = true;
            StaticEmailLabel.ForeColor = Color.White;
            StaticEmailLabel.Location = new Point(206, 213);
            StaticEmailLabel.Margin = new Padding(5, 0, 5, 0);
            StaticEmailLabel.Name = "StaticEmailLabel";
            StaticEmailLabel.Size = new Size(65, 29);
            StaticEmailLabel.TabIndex = 6;
            StaticEmailLabel.Text = "Email";
            // 
            // BalanceLabel
            // 
            BalanceLabel.AutoSize = true;
            BalanceLabel.ForeColor = Color.White;
            BalanceLabel.Location = new Point(382, 36);
            BalanceLabel.Margin = new Padding(5, 0, 5, 0);
            BalanceLabel.MinimumSize = new Size(100, 30);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.Size = new Size(100, 30);
            BalanceLabel.TabIndex = 7;
            BalanceLabel.Text = "balance";
            // 
            // CarInfoLabel
            // 
            CarInfoLabel.AutoSize = true;
            CarInfoLabel.Cursor = Cursors.Hand;
            CarInfoLabel.Location = new Point(11, 175);
            CarInfoLabel.Margin = new Padding(5, 0, 5, 0);
            CarInfoLabel.Name = "CarInfoLabel";
            CarInfoLabel.Size = new Size(126, 29);
            CarInfoLabel.TabIndex = 8;
            CarInfoLabel.Text = "Автомобили";
            CarInfoLabel.Click += CarInfoLabel_Click;
            CarInfoLabel.MouseHover += CarInfoLabel_MouseHover;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(UserNameLabel);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(CarInfoLabel);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(ROVLabel);
            panel1.Controls.Add(ProfileLabel);
            panel1.Controls.Add(VioLabel);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(173, 459);
            panel1.TabIndex = 9;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Location = new Point(45, 419);
            UserNameLabel.MaximumSize = new Size(200, 27);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(65, 27);
            UserNameLabel.TabIndex = 10;
            UserNameLabel.Text = "label1";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 35, 35);
            panel3.Location = new Point(0, 129);
            panel3.Name = "panel3";
            panel3.Size = new Size(109, 5);
            panel3.TabIndex = 9;
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
            ROVLabel.Location = new Point(34, 10);
            ROVLabel.Name = "ROVLabel";
            ROVLabel.Size = new Size(99, 58);
            ROVLabel.TabIndex = 4;
            ROVLabel.Text = "ROV";
            // 
            // LoginTextBox
            // 
            LoginTextBox.BackColor = Color.Tan;
            LoginTextBox.BorderStyle = BorderStyle.None;
            LoginTextBox.Font = new Font("Bahnschrift Condensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            LoginTextBox.Location = new Point(212, 150);
            LoginTextBox.MaxLength = 12;
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.PlaceholderText = "Логин";
            LoginTextBox.ReadOnly = true;
            LoginTextBox.Size = new Size(279, 35);
            LoginTextBox.TabIndex = 10;
            // 
            // EmailTextBox
            // 
            EmailTextBox.BackColor = Color.Tan;
            EmailTextBox.BorderStyle = BorderStyle.None;
            EmailTextBox.Font = new Font("Bahnschrift Condensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTextBox.Location = new Point(212, 249);
            EmailTextBox.MaxLength = 25;
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.PlaceholderText = "Email";
            EmailTextBox.ReadOnly = true;
            EmailTextBox.Size = new Size(279, 35);
            EmailTextBox.TabIndex = 11;
            // 
            // FioTextBox
            // 
            FioTextBox.BackColor = Color.Tan;
            FioTextBox.BorderStyle = BorderStyle.None;
            FioTextBox.Font = new Font("Bahnschrift Condensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            FioTextBox.Location = new Point(547, 249);
            FioTextBox.MaxLength = 75;
            FioTextBox.Name = "FioTextBox";
            FioTextBox.PlaceholderText = "ФИО";
            FioTextBox.ReadOnly = true;
            FioTextBox.Size = new Size(279, 35);
            FioTextBox.TabIndex = 13;
            // 
            // StaticFioLabel
            // 
            StaticFioLabel.AutoSize = true;
            StaticFioLabel.ForeColor = Color.White;
            StaticFioLabel.Location = new Point(541, 213);
            StaticFioLabel.Margin = new Padding(5, 0, 5, 0);
            StaticFioLabel.Name = "StaticFioLabel";
            StaticFioLabel.Size = new Size(56, 29);
            StaticFioLabel.TabIndex = 12;
            StaticFioLabel.Text = "ФИО";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = Color.Tan;
            PasswordTextBox.BorderStyle = BorderStyle.None;
            PasswordTextBox.Font = new Font("Bahnschrift Condensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.Location = new Point(547, 150);
            PasswordTextBox.MaxLength = 20;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PlaceholderText = "Пароль";
            PasswordTextBox.ReadOnly = true;
            PasswordTextBox.Size = new Size(279, 35);
            PasswordTextBox.TabIndex = 15;
            PasswordTextBox.Enter += PasswordTextBox_Enter;
            PasswordTextBox.Leave += PasswordTextBox_Leave;
            // 
            // StaticPasswordLabel
            // 
            StaticPasswordLabel.AutoSize = true;
            StaticPasswordLabel.ForeColor = Color.White;
            StaticPasswordLabel.Location = new Point(541, 114);
            StaticPasswordLabel.Margin = new Padding(5, 0, 5, 0);
            StaticPasswordLabel.Name = "StaticPasswordLabel";
            StaticPasswordLabel.Size = new Size(80, 29);
            StaticPasswordLabel.TabIndex = 14;
            StaticPasswordLabel.Text = "Пароль";
            // 
            // StaticBalanceLabel
            // 
            StaticBalanceLabel.AutoSize = true;
            StaticBalanceLabel.ForeColor = Color.White;
            StaticBalanceLabel.Location = new Point(206, 36);
            StaticBalanceLabel.Name = "StaticBalanceLabel";
            StaticBalanceLabel.Size = new Size(172, 29);
            StaticBalanceLabel.TabIndex = 16;
            StaticBalanceLabel.Text = "Текущий баланс:";
            // 
            // ChangeDataButton
            // 
            ChangeDataButton.BackColor = Color.Tan;
            ChangeDataButton.Cursor = Cursors.Hand;
            ChangeDataButton.FlatStyle = FlatStyle.Flat;
            ChangeDataButton.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ChangeDataButton.Location = new Point(212, 318);
            ChangeDataButton.Name = "ChangeDataButton";
            ChangeDataButton.Size = new Size(279, 34);
            ChangeDataButton.TabIndex = 17;
            ChangeDataButton.Text = "Изменить профиль";
            ChangeDataButton.UseVisualStyleBackColor = false;
            ChangeDataButton.Click += ChangeDataButton_Click;
            // 
            // ConfirmDataButton
            // 
            ConfirmDataButton.BackColor = Color.Tan;
            ConfirmDataButton.Cursor = Cursors.No;
            ConfirmDataButton.Enabled = false;
            ConfirmDataButton.FlatStyle = FlatStyle.Flat;
            ConfirmDataButton.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmDataButton.Location = new Point(547, 318);
            ConfirmDataButton.Name = "ConfirmDataButton";
            ConfirmDataButton.Size = new Size(279, 34);
            ConfirmDataButton.TabIndex = 18;
            ConfirmDataButton.Text = "Подтвердить данные";
            ConfirmDataButton.UseVisualStyleBackColor = false;
            ConfirmDataButton.Click += ConfirmDataButton_Click;
            // 
            // ExitPictureBox
            // 
            ExitPictureBox.Cursor = Cursors.Hand;
            ExitPictureBox.Image = Properties.Resources.ExitIcon;
            ExitPictureBox.Location = new Point(816, 12);
            ExitPictureBox.Name = "ExitPictureBox";
            ExitPictureBox.Size = new Size(39, 35);
            ExitPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            ExitPictureBox.TabIndex = 19;
            ExitPictureBox.TabStop = false;
            ExitPictureBox.Click += ExitPictureBox_Click;
            // 
            // UpdatePictureBox
            // 
            UpdatePictureBox.Cursor = Cursors.Hand;
            UpdatePictureBox.Image = Properties.Resources.UpdateIcon2;
            UpdatePictureBox.Location = new Point(771, 12);
            UpdatePictureBox.Name = "UpdatePictureBox";
            UpdatePictureBox.Size = new Size(39, 35);
            UpdatePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            UpdatePictureBox.TabIndex = 20;
            UpdatePictureBox.TabStop = false;
            UpdatePictureBox.Click += UpdatePictureBox_Click;
            // 
            // AcessPictureBox_1
            // 
            AcessPictureBox_1.BackColor = Color.Tan;
            AcessPictureBox_1.Image = Properties.Resources.LockIcon;
            AcessPictureBox_1.Location = new Point(457, 152);
            AcessPictureBox_1.Name = "AcessPictureBox_1";
            AcessPictureBox_1.Size = new Size(25, 31);
            AcessPictureBox_1.SizeMode = PictureBoxSizeMode.Zoom;
            AcessPictureBox_1.TabIndex = 21;
            AcessPictureBox_1.TabStop = false;
            // 
            // AcessPictureBox_3
            // 
            AcessPictureBox_3.BackColor = Color.Tan;
            AcessPictureBox_3.Image = Properties.Resources.LockIcon;
            AcessPictureBox_3.Location = new Point(457, 251);
            AcessPictureBox_3.Name = "AcessPictureBox_3";
            AcessPictureBox_3.Size = new Size(25, 31);
            AcessPictureBox_3.SizeMode = PictureBoxSizeMode.Zoom;
            AcessPictureBox_3.TabIndex = 22;
            AcessPictureBox_3.TabStop = false;
            // 
            // AcessPictureBox_4
            // 
            AcessPictureBox_4.BackColor = Color.Tan;
            AcessPictureBox_4.Image = Properties.Resources.LockIcon;
            AcessPictureBox_4.Location = new Point(791, 251);
            AcessPictureBox_4.Name = "AcessPictureBox_4";
            AcessPictureBox_4.Size = new Size(25, 31);
            AcessPictureBox_4.SizeMode = PictureBoxSizeMode.Zoom;
            AcessPictureBox_4.TabIndex = 24;
            AcessPictureBox_4.TabStop = false;
            // 
            // AcessPictureBox_2
            // 
            AcessPictureBox_2.BackColor = Color.Tan;
            AcessPictureBox_2.Image = Properties.Resources.LockIcon;
            AcessPictureBox_2.Location = new Point(791, 152);
            AcessPictureBox_2.Name = "AcessPictureBox_2";
            AcessPictureBox_2.Size = new Size(25, 31);
            AcessPictureBox_2.SizeMode = PictureBoxSizeMode.Zoom;
            AcessPictureBox_2.TabIndex = 23;
            AcessPictureBox_2.TabStop = false;
            // 
            // AddBalanceButton
            // 
            AddBalanceButton.Cursor = Cursors.Hand;
            AddBalanceButton.Image = (Image)resources.GetObject("AddBalanceButton.Image");
            AddBalanceButton.Location = new Point(497, 33);
            AddBalanceButton.Name = "AddBalanceButton";
            AddBalanceButton.Size = new Size(36, 35);
            AddBalanceButton.SizeMode = PictureBoxSizeMode.StretchImage;
            AddBalanceButton.TabIndex = 41;
            AddBalanceButton.TabStop = false;
            AddBalanceButton.Click += AddBalanceButton_Click;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(11F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(867, 455);
            Controls.Add(AddBalanceButton);
            Controls.Add(AcessPictureBox_4);
            Controls.Add(AcessPictureBox_2);
            Controls.Add(AcessPictureBox_3);
            Controls.Add(AcessPictureBox_1);
            Controls.Add(UpdatePictureBox);
            Controls.Add(ExitPictureBox);
            Controls.Add(ConfirmDataButton);
            Controls.Add(ChangeDataButton);
            Controls.Add(StaticBalanceLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(StaticPasswordLabel);
            Controls.Add(FioTextBox);
            Controls.Add(StaticFioLabel);
            Controls.Add(EmailTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(BalanceLabel);
            Controls.Add(StaticEmailLabel);
            Controls.Add(StaticLoginLabel);
            Controls.Add(panel1);
            Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProfileForm";
            Load += ProfileForm_Load;
            KeyPress += ProfileForm_KeyPress;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ExitPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpdatePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)AcessPictureBox_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)AcessPictureBox_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)AcessPictureBox_4).EndInit();
            ((System.ComponentModel.ISupportInitialize)AcessPictureBox_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddBalanceButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label VioLabel;
        private Label ProfileLabel;
        private Label StaticLoginLabel;
        private Label StaticEmailLabel;
        private Label BalanceLabel;
        private Label CarInfoLabel;
        private Panel panel1;
        private Panel panel2;
        private Label ROVLabel;
        private TextBox LoginTextBox;
        private TextBox EmailTextBox;
        private TextBox FioTextBox;
        private Label StaticFioLabel;
        private TextBox PasswordTextBox;
        private Label StaticPasswordLabel;
        private Label StaticBalanceLabel;
        private Button ChangeDataButton;
        private Button ConfirmDataButton;
        private PictureBox ExitPictureBox;
        private Panel panel3;
        private PictureBox UpdatePictureBox;
        private PictureBox AcessPictureBox_1;
        private PictureBox AcessPictureBox_3;
        private PictureBox AcessPictureBox_4;
        private PictureBox AcessPictureBox_2;
        private PictureBox AddBalanceButton;
        private Label UserNameLabel;
    }
}