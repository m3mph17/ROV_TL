namespace ROV_TL.AdminForms
{
    partial class AdminsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminsForm));
            panel1 = new Panel();
            ViosLabel = new Label();
            AdminProfileLabel = new Label();
            panel3 = new Panel();
            CarsLabel = new Label();
            panel2 = new Panel();
            ROVLabel = new Label();
            AdminsLabel = new Label();
            UsersLabel = new Label();
            NextPageButton = new PictureBox();
            PrevPageButton = new PictureBox();
            CurrentPageLabel = new Label();
            StaticEmailLabel = new Label();
            StaticLvlLabel = new Label();
            StaticPasswordLabel = new Label();
            StaticLoginLabel = new Label();
            panel8 = new Panel();
            LvlLabel_1 = new Label();
            LoginLabel_1 = new Label();
            PasswordLabel_1 = new Label();
            EmailLabel_1 = new Label();
            EmailLabel_2 = new Label();
            PasswordLabel_2 = new Label();
            LoginLabel_2 = new Label();
            LvlLabel_2 = new Label();
            panel9 = new Panel();
            EmailLabel_3 = new Label();
            PasswordLabel_3 = new Label();
            LoginLabel_3 = new Label();
            LvlLabel_3 = new Label();
            panel4 = new Panel();
            EmailLabel_4 = new Label();
            PasswordLabel_4 = new Label();
            LoginLabel_4 = new Label();
            LvlLabel_4 = new Label();
            panel5 = new Panel();
            EmailLabel_5 = new Label();
            PasswordLabel_5 = new Label();
            LoginLabel_5 = new Label();
            LvlLabel_5 = new Label();
            panel6 = new Panel();
            EmailLabel_6 = new Label();
            PasswordLabel_6 = new Label();
            LoginLabel_6 = new Label();
            LvlLabel_6 = new Label();
            panel7 = new Panel();
            EmailLabel_7 = new Label();
            PasswordLabel_7 = new Label();
            LoginLabel_7 = new Label();
            LvlLabel_7 = new Label();
            panel10 = new Panel();
            AddButton = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NextPageButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrevPageButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddButton).BeginInit();
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
            panel1.TabIndex = 15;
            // 
            // ViosLabel
            // 
            ViosLabel.AutoSize = true;
            ViosLabel.Cursor = Cursors.Hand;
            ViosLabel.ForeColor = Color.Black;
            ViosLabel.Location = new Point(11, 221);
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
            AdminProfileLabel.Cursor = Cursors.Hand;
            AdminProfileLabel.ForeColor = Color.Black;
            AdminProfileLabel.Location = new Point(47, 62);
            AdminProfileLabel.Margin = new Padding(5, 0, 5, 0);
            AdminProfileLabel.Name = "AdminProfileLabel";
            AdminProfileLabel.Size = new Size(72, 29);
            AdminProfileLabel.TabIndex = 10;
            AdminProfileLabel.Text = "Admin";
            AdminProfileLabel.Click += AdminProfileLabel_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 35, 35);
            panel3.Location = new Point(-2, 139);
            panel3.Name = "panel3";
            panel3.Size = new Size(163, 5);
            panel3.TabIndex = 9;
            // 
            // CarsLabel
            // 
            CarsLabel.AutoSize = true;
            CarsLabel.Cursor = Cursors.Hand;
            CarsLabel.ForeColor = Color.Black;
            CarsLabel.Location = new Point(11, 185);
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
            AdminsLabel.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            AdminsLabel.ForeColor = Color.Black;
            AdminsLabel.Location = new Point(11, 109);
            AdminsLabel.Margin = new Padding(5, 0, 5, 0);
            AdminsLabel.Name = "AdminsLabel";
            AdminsLabel.Size = new Size(150, 29);
            AdminsLabel.TabIndex = 2;
            AdminsLabel.Text = "Администраторы";
            // 
            // UsersLabel
            // 
            UsersLabel.AutoSize = true;
            UsersLabel.Cursor = Cursors.Hand;
            UsersLabel.ForeColor = Color.Black;
            UsersLabel.Location = new Point(11, 149);
            UsersLabel.Margin = new Padding(5, 0, 5, 0);
            UsersLabel.Name = "UsersLabel";
            UsersLabel.Size = new Size(142, 29);
            UsersLabel.TabIndex = 3;
            UsersLabel.Text = "Пользователи";
            UsersLabel.Click += UsersLabel_Click;
            // 
            // NextPageButton
            // 
            NextPageButton.Cursor = Cursors.Hand;
            NextPageButton.Image = Properties.Resources.NextPageIcon;
            NextPageButton.Location = new Point(676, 12);
            NextPageButton.Name = "NextPageButton";
            NextPageButton.Size = new Size(30, 30);
            NextPageButton.SizeMode = PictureBoxSizeMode.StretchImage;
            NextPageButton.TabIndex = 47;
            NextPageButton.TabStop = false;
            NextPageButton.Click += NextPageButton_Click;
            // 
            // PrevPageButton
            // 
            PrevPageButton.Cursor = Cursors.Hand;
            PrevPageButton.Image = Properties.Resources.PrevPageIcon;
            PrevPageButton.Location = new Point(348, 12);
            PrevPageButton.Name = "PrevPageButton";
            PrevPageButton.Size = new Size(30, 30);
            PrevPageButton.SizeMode = PictureBoxSizeMode.StretchImage;
            PrevPageButton.TabIndex = 46;
            PrevPageButton.TabStop = false;
            PrevPageButton.Click += PrevPageButton_Click;
            // 
            // CurrentPageLabel
            // 
            CurrentPageLabel.AutoSize = true;
            CurrentPageLabel.Font = new Font("Bahnschrift SemiBold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            CurrentPageLabel.Location = new Point(384, 9);
            CurrentPageLabel.Name = "CurrentPageLabel";
            CurrentPageLabel.Size = new Size(286, 35);
            CurrentPageLabel.TabIndex = 45;
            CurrentPageLabel.Text = "Текущая страница: 1";
            // 
            // StaticEmailLabel
            // 
            StaticEmailLabel.AutoSize = true;
            StaticEmailLabel.Font = new Font("Bahnschrift SemiCondensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            StaticEmailLabel.Location = new Point(715, 75);
            StaticEmailLabel.Margin = new Padding(5, 0, 5, 0);
            StaticEmailLabel.Name = "StaticEmailLabel";
            StaticEmailLabel.Size = new Size(80, 35);
            StaticEmailLabel.TabIndex = 51;
            StaticEmailLabel.Text = "Email";
            // 
            // StaticLvlLabel
            // 
            StaticLvlLabel.AutoSize = true;
            StaticLvlLabel.Font = new Font("Bahnschrift SemiCondensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            StaticLvlLabel.Location = new Point(199, 75);
            StaticLvlLabel.Margin = new Padding(5, 0, 5, 0);
            StaticLvlLabel.Name = "StaticLvlLabel";
            StaticLvlLabel.Size = new Size(96, 35);
            StaticLvlLabel.TabIndex = 50;
            StaticLvlLabel.Text = "Доступ";
            // 
            // StaticPasswordLabel
            // 
            StaticPasswordLabel.AutoSize = true;
            StaticPasswordLabel.Font = new Font("Bahnschrift SemiCondensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            StaticPasswordLabel.Location = new Point(518, 75);
            StaticPasswordLabel.Margin = new Padding(5, 0, 5, 0);
            StaticPasswordLabel.Name = "StaticPasswordLabel";
            StaticPasswordLabel.Size = new Size(98, 35);
            StaticPasswordLabel.TabIndex = 49;
            StaticPasswordLabel.Text = "Пароль";
            // 
            // StaticLoginLabel
            // 
            StaticLoginLabel.AutoSize = true;
            StaticLoginLabel.Font = new Font("Bahnschrift SemiCondensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            StaticLoginLabel.Location = new Point(353, 75);
            StaticLoginLabel.Margin = new Padding(5, 0, 5, 0);
            StaticLoginLabel.Name = "StaticLoginLabel";
            StaticLoginLabel.Size = new Size(84, 35);
            StaticLoginLabel.TabIndex = 48;
            StaticLoginLabel.Text = "Логин";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(55, 55, 55);
            panel8.Location = new Point(199, 113);
            panel8.Name = "panel8";
            panel8.Size = new Size(643, 10);
            panel8.TabIndex = 53;
            // 
            // LvlLabel_1
            // 
            LvlLabel_1.AutoSize = true;
            LvlLabel_1.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LvlLabel_1.Location = new Point(198, 127);
            LvlLabel_1.Margin = new Padding(5, 0, 5, 0);
            LvlLabel_1.MinimumSize = new Size(96, 0);
            LvlLabel_1.Name = "LvlLabel_1";
            LvlLabel_1.Size = new Size(96, 25);
            LvlLabel_1.TabIndex = 57;
            LvlLabel_1.Text = "-1";
            LvlLabel_1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginLabel_1
            // 
            LoginLabel_1.AutoSize = true;
            LoginLabel_1.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LoginLabel_1.Location = new Point(319, 127);
            LoginLabel_1.Margin = new Padding(5, 0, 5, 0);
            LoginLabel_1.MaximumSize = new Size(160, 0);
            LoginLabel_1.MinimumSize = new Size(150, 0);
            LoginLabel_1.Name = "LoginLabel_1";
            LoginLabel_1.Size = new Size(150, 25);
            LoginLabel_1.TabIndex = 58;
            LoginLabel_1.Text = "Login";
            LoginLabel_1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordLabel_1
            // 
            PasswordLabel_1.AutoSize = true;
            PasswordLabel_1.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel_1.Location = new Point(489, 127);
            PasswordLabel_1.Margin = new Padding(5, 0, 5, 0);
            PasswordLabel_1.MaximumSize = new Size(160, 0);
            PasswordLabel_1.MinimumSize = new Size(150, 0);
            PasswordLabel_1.Name = "PasswordLabel_1";
            PasswordLabel_1.Size = new Size(150, 25);
            PasswordLabel_1.TabIndex = 59;
            PasswordLabel_1.Text = "Password";
            PasswordLabel_1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EmailLabel_1
            // 
            EmailLabel_1.AutoSize = true;
            EmailLabel_1.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabel_1.Location = new Point(655, 127);
            EmailLabel_1.Margin = new Padding(5, 0, 5, 0);
            EmailLabel_1.MaximumSize = new Size(200, 0);
            EmailLabel_1.MinimumSize = new Size(200, 0);
            EmailLabel_1.Name = "EmailLabel_1";
            EmailLabel_1.Size = new Size(200, 25);
            EmailLabel_1.TabIndex = 60;
            EmailLabel_1.Text = "Email";
            EmailLabel_1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EmailLabel_2
            // 
            EmailLabel_2.AutoSize = true;
            EmailLabel_2.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabel_2.Location = new Point(655, 171);
            EmailLabel_2.Margin = new Padding(5, 0, 5, 0);
            EmailLabel_2.MaximumSize = new Size(200, 0);
            EmailLabel_2.MinimumSize = new Size(200, 0);
            EmailLabel_2.Name = "EmailLabel_2";
            EmailLabel_2.Size = new Size(200, 25);
            EmailLabel_2.TabIndex = 65;
            EmailLabel_2.Text = "Email";
            EmailLabel_2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordLabel_2
            // 
            PasswordLabel_2.AutoSize = true;
            PasswordLabel_2.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel_2.Location = new Point(489, 171);
            PasswordLabel_2.Margin = new Padding(5, 0, 5, 0);
            PasswordLabel_2.MaximumSize = new Size(160, 0);
            PasswordLabel_2.MinimumSize = new Size(150, 0);
            PasswordLabel_2.Name = "PasswordLabel_2";
            PasswordLabel_2.Size = new Size(150, 25);
            PasswordLabel_2.TabIndex = 64;
            PasswordLabel_2.Text = "Password";
            PasswordLabel_2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginLabel_2
            // 
            LoginLabel_2.AutoSize = true;
            LoginLabel_2.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LoginLabel_2.Location = new Point(319, 171);
            LoginLabel_2.Margin = new Padding(5, 0, 5, 0);
            LoginLabel_2.MaximumSize = new Size(160, 0);
            LoginLabel_2.MinimumSize = new Size(150, 0);
            LoginLabel_2.Name = "LoginLabel_2";
            LoginLabel_2.Size = new Size(150, 25);
            LoginLabel_2.TabIndex = 63;
            LoginLabel_2.Text = "Login";
            LoginLabel_2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LvlLabel_2
            // 
            LvlLabel_2.AutoSize = true;
            LvlLabel_2.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LvlLabel_2.Location = new Point(198, 171);
            LvlLabel_2.Margin = new Padding(5, 0, 5, 0);
            LvlLabel_2.MinimumSize = new Size(96, 0);
            LvlLabel_2.Name = "LvlLabel_2";
            LvlLabel_2.Size = new Size(96, 25);
            LvlLabel_2.TabIndex = 62;
            LvlLabel_2.Text = "-1";
            LvlLabel_2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(55, 55, 55);
            panel9.Location = new Point(199, 157);
            panel9.Name = "panel9";
            panel9.Size = new Size(643, 10);
            panel9.TabIndex = 61;
            // 
            // EmailLabel_3
            // 
            EmailLabel_3.AutoSize = true;
            EmailLabel_3.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabel_3.Location = new Point(655, 216);
            EmailLabel_3.Margin = new Padding(5, 0, 5, 0);
            EmailLabel_3.MaximumSize = new Size(200, 0);
            EmailLabel_3.MinimumSize = new Size(200, 0);
            EmailLabel_3.Name = "EmailLabel_3";
            EmailLabel_3.Size = new Size(200, 25);
            EmailLabel_3.TabIndex = 70;
            EmailLabel_3.Text = "Email";
            EmailLabel_3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordLabel_3
            // 
            PasswordLabel_3.AutoSize = true;
            PasswordLabel_3.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel_3.Location = new Point(489, 216);
            PasswordLabel_3.Margin = new Padding(5, 0, 5, 0);
            PasswordLabel_3.MaximumSize = new Size(160, 0);
            PasswordLabel_3.MinimumSize = new Size(150, 0);
            PasswordLabel_3.Name = "PasswordLabel_3";
            PasswordLabel_3.Size = new Size(150, 25);
            PasswordLabel_3.TabIndex = 69;
            PasswordLabel_3.Text = "Password";
            PasswordLabel_3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginLabel_3
            // 
            LoginLabel_3.AutoSize = true;
            LoginLabel_3.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LoginLabel_3.Location = new Point(319, 216);
            LoginLabel_3.Margin = new Padding(5, 0, 5, 0);
            LoginLabel_3.MaximumSize = new Size(160, 0);
            LoginLabel_3.MinimumSize = new Size(150, 0);
            LoginLabel_3.Name = "LoginLabel_3";
            LoginLabel_3.Size = new Size(150, 25);
            LoginLabel_3.TabIndex = 68;
            LoginLabel_3.Text = "Login";
            LoginLabel_3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LvlLabel_3
            // 
            LvlLabel_3.AutoSize = true;
            LvlLabel_3.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LvlLabel_3.Location = new Point(198, 216);
            LvlLabel_3.Margin = new Padding(5, 0, 5, 0);
            LvlLabel_3.MinimumSize = new Size(96, 0);
            LvlLabel_3.Name = "LvlLabel_3";
            LvlLabel_3.Size = new Size(96, 25);
            LvlLabel_3.TabIndex = 67;
            LvlLabel_3.Text = "-1";
            LvlLabel_3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(55, 55, 55);
            panel4.Location = new Point(199, 202);
            panel4.Name = "panel4";
            panel4.Size = new Size(643, 10);
            panel4.TabIndex = 66;
            // 
            // EmailLabel_4
            // 
            EmailLabel_4.AutoSize = true;
            EmailLabel_4.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabel_4.Location = new Point(655, 261);
            EmailLabel_4.Margin = new Padding(5, 0, 5, 0);
            EmailLabel_4.MaximumSize = new Size(200, 0);
            EmailLabel_4.MinimumSize = new Size(200, 0);
            EmailLabel_4.Name = "EmailLabel_4";
            EmailLabel_4.Size = new Size(200, 25);
            EmailLabel_4.TabIndex = 75;
            EmailLabel_4.Text = "Email";
            EmailLabel_4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordLabel_4
            // 
            PasswordLabel_4.AutoSize = true;
            PasswordLabel_4.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel_4.Location = new Point(489, 261);
            PasswordLabel_4.Margin = new Padding(5, 0, 5, 0);
            PasswordLabel_4.MaximumSize = new Size(160, 0);
            PasswordLabel_4.MinimumSize = new Size(150, 0);
            PasswordLabel_4.Name = "PasswordLabel_4";
            PasswordLabel_4.Size = new Size(150, 25);
            PasswordLabel_4.TabIndex = 74;
            PasswordLabel_4.Text = "Password";
            PasswordLabel_4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginLabel_4
            // 
            LoginLabel_4.AutoSize = true;
            LoginLabel_4.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LoginLabel_4.Location = new Point(319, 261);
            LoginLabel_4.Margin = new Padding(5, 0, 5, 0);
            LoginLabel_4.MaximumSize = new Size(160, 0);
            LoginLabel_4.MinimumSize = new Size(150, 0);
            LoginLabel_4.Name = "LoginLabel_4";
            LoginLabel_4.Size = new Size(150, 25);
            LoginLabel_4.TabIndex = 73;
            LoginLabel_4.Text = "Login";
            LoginLabel_4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LvlLabel_4
            // 
            LvlLabel_4.AutoSize = true;
            LvlLabel_4.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LvlLabel_4.Location = new Point(198, 261);
            LvlLabel_4.Margin = new Padding(5, 0, 5, 0);
            LvlLabel_4.MinimumSize = new Size(96, 0);
            LvlLabel_4.Name = "LvlLabel_4";
            LvlLabel_4.Size = new Size(96, 25);
            LvlLabel_4.TabIndex = 72;
            LvlLabel_4.Text = "-1";
            LvlLabel_4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(55, 55, 55);
            panel5.Location = new Point(199, 247);
            panel5.Name = "panel5";
            panel5.Size = new Size(643, 10);
            panel5.TabIndex = 71;
            // 
            // EmailLabel_5
            // 
            EmailLabel_5.AutoSize = true;
            EmailLabel_5.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabel_5.Location = new Point(655, 307);
            EmailLabel_5.Margin = new Padding(5, 0, 5, 0);
            EmailLabel_5.MaximumSize = new Size(200, 0);
            EmailLabel_5.MinimumSize = new Size(200, 0);
            EmailLabel_5.Name = "EmailLabel_5";
            EmailLabel_5.Size = new Size(200, 25);
            EmailLabel_5.TabIndex = 80;
            EmailLabel_5.Text = "Email";
            EmailLabel_5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordLabel_5
            // 
            PasswordLabel_5.AutoSize = true;
            PasswordLabel_5.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel_5.Location = new Point(489, 307);
            PasswordLabel_5.Margin = new Padding(5, 0, 5, 0);
            PasswordLabel_5.MaximumSize = new Size(160, 0);
            PasswordLabel_5.MinimumSize = new Size(150, 0);
            PasswordLabel_5.Name = "PasswordLabel_5";
            PasswordLabel_5.Size = new Size(150, 25);
            PasswordLabel_5.TabIndex = 79;
            PasswordLabel_5.Text = "Password";
            PasswordLabel_5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginLabel_5
            // 
            LoginLabel_5.AutoSize = true;
            LoginLabel_5.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LoginLabel_5.Location = new Point(319, 307);
            LoginLabel_5.Margin = new Padding(5, 0, 5, 0);
            LoginLabel_5.MaximumSize = new Size(160, 0);
            LoginLabel_5.MinimumSize = new Size(150, 0);
            LoginLabel_5.Name = "LoginLabel_5";
            LoginLabel_5.Size = new Size(150, 25);
            LoginLabel_5.TabIndex = 78;
            LoginLabel_5.Text = "Login";
            LoginLabel_5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LvlLabel_5
            // 
            LvlLabel_5.AutoSize = true;
            LvlLabel_5.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LvlLabel_5.Location = new Point(198, 307);
            LvlLabel_5.Margin = new Padding(5, 0, 5, 0);
            LvlLabel_5.MinimumSize = new Size(96, 0);
            LvlLabel_5.Name = "LvlLabel_5";
            LvlLabel_5.Size = new Size(96, 25);
            LvlLabel_5.TabIndex = 77;
            LvlLabel_5.Text = "-1";
            LvlLabel_5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(55, 55, 55);
            panel6.Location = new Point(199, 293);
            panel6.Name = "panel6";
            panel6.Size = new Size(643, 10);
            panel6.TabIndex = 76;
            // 
            // EmailLabel_6
            // 
            EmailLabel_6.AutoSize = true;
            EmailLabel_6.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabel_6.Location = new Point(655, 352);
            EmailLabel_6.Margin = new Padding(5, 0, 5, 0);
            EmailLabel_6.MaximumSize = new Size(200, 0);
            EmailLabel_6.MinimumSize = new Size(200, 0);
            EmailLabel_6.Name = "EmailLabel_6";
            EmailLabel_6.Size = new Size(200, 25);
            EmailLabel_6.TabIndex = 85;
            EmailLabel_6.Text = "Email";
            EmailLabel_6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordLabel_6
            // 
            PasswordLabel_6.AutoSize = true;
            PasswordLabel_6.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel_6.Location = new Point(489, 352);
            PasswordLabel_6.Margin = new Padding(5, 0, 5, 0);
            PasswordLabel_6.MaximumSize = new Size(160, 0);
            PasswordLabel_6.MinimumSize = new Size(150, 0);
            PasswordLabel_6.Name = "PasswordLabel_6";
            PasswordLabel_6.Size = new Size(150, 25);
            PasswordLabel_6.TabIndex = 84;
            PasswordLabel_6.Text = "Password";
            PasswordLabel_6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginLabel_6
            // 
            LoginLabel_6.AutoSize = true;
            LoginLabel_6.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LoginLabel_6.Location = new Point(319, 352);
            LoginLabel_6.Margin = new Padding(5, 0, 5, 0);
            LoginLabel_6.MaximumSize = new Size(160, 0);
            LoginLabel_6.MinimumSize = new Size(150, 0);
            LoginLabel_6.Name = "LoginLabel_6";
            LoginLabel_6.Size = new Size(150, 25);
            LoginLabel_6.TabIndex = 83;
            LoginLabel_6.Text = "Login";
            LoginLabel_6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LvlLabel_6
            // 
            LvlLabel_6.AutoSize = true;
            LvlLabel_6.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LvlLabel_6.Location = new Point(198, 352);
            LvlLabel_6.Margin = new Padding(5, 0, 5, 0);
            LvlLabel_6.MinimumSize = new Size(96, 0);
            LvlLabel_6.Name = "LvlLabel_6";
            LvlLabel_6.Size = new Size(96, 25);
            LvlLabel_6.TabIndex = 82;
            LvlLabel_6.Text = "-1";
            LvlLabel_6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(55, 55, 55);
            panel7.Location = new Point(199, 338);
            panel7.Name = "panel7";
            panel7.Size = new Size(643, 10);
            panel7.TabIndex = 81;
            // 
            // EmailLabel_7
            // 
            EmailLabel_7.AutoSize = true;
            EmailLabel_7.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabel_7.Location = new Point(654, 395);
            EmailLabel_7.Margin = new Padding(5, 0, 5, 0);
            EmailLabel_7.MaximumSize = new Size(200, 0);
            EmailLabel_7.MinimumSize = new Size(200, 0);
            EmailLabel_7.Name = "EmailLabel_7";
            EmailLabel_7.Size = new Size(200, 25);
            EmailLabel_7.TabIndex = 90;
            EmailLabel_7.Text = "Email";
            EmailLabel_7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordLabel_7
            // 
            PasswordLabel_7.AutoSize = true;
            PasswordLabel_7.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel_7.Location = new Point(488, 395);
            PasswordLabel_7.Margin = new Padding(5, 0, 5, 0);
            PasswordLabel_7.MaximumSize = new Size(160, 0);
            PasswordLabel_7.MinimumSize = new Size(150, 0);
            PasswordLabel_7.Name = "PasswordLabel_7";
            PasswordLabel_7.Size = new Size(150, 25);
            PasswordLabel_7.TabIndex = 89;
            PasswordLabel_7.Text = "Password";
            PasswordLabel_7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginLabel_7
            // 
            LoginLabel_7.AutoSize = true;
            LoginLabel_7.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LoginLabel_7.Location = new Point(318, 395);
            LoginLabel_7.Margin = new Padding(5, 0, 5, 0);
            LoginLabel_7.MaximumSize = new Size(160, 0);
            LoginLabel_7.MinimumSize = new Size(150, 0);
            LoginLabel_7.Name = "LoginLabel_7";
            LoginLabel_7.Size = new Size(150, 25);
            LoginLabel_7.TabIndex = 88;
            LoginLabel_7.Text = "Login";
            LoginLabel_7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LvlLabel_7
            // 
            LvlLabel_7.AutoSize = true;
            LvlLabel_7.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LvlLabel_7.Location = new Point(197, 395);
            LvlLabel_7.Margin = new Padding(5, 0, 5, 0);
            LvlLabel_7.MinimumSize = new Size(96, 0);
            LvlLabel_7.Name = "LvlLabel_7";
            LvlLabel_7.Size = new Size(96, 25);
            LvlLabel_7.TabIndex = 87;
            LvlLabel_7.Text = "-1";
            LvlLabel_7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(55, 55, 55);
            panel10.Location = new Point(198, 381);
            panel10.Name = "panel10";
            panel10.Size = new Size(643, 10);
            panel10.TabIndex = 86;
            // 
            // AddButton
            // 
            AddButton.Image = Properties.Resources.AddIcon;
            AddButton.Location = new Point(199, 9);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(40, 40);
            AddButton.SizeMode = PictureBoxSizeMode.StretchImage;
            AddButton.TabIndex = 91;
            AddButton.TabStop = false;
            AddButton.Click += AddButton_Click;
            // 
            // AdminsForm
            // 
            AutoScaleDimensions = new SizeF(11F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(867, 455);
            Controls.Add(AddButton);
            Controls.Add(EmailLabel_7);
            Controls.Add(PasswordLabel_7);
            Controls.Add(LoginLabel_7);
            Controls.Add(LvlLabel_7);
            Controls.Add(panel10);
            Controls.Add(EmailLabel_6);
            Controls.Add(PasswordLabel_6);
            Controls.Add(LoginLabel_6);
            Controls.Add(LvlLabel_6);
            Controls.Add(panel7);
            Controls.Add(EmailLabel_5);
            Controls.Add(PasswordLabel_5);
            Controls.Add(LoginLabel_5);
            Controls.Add(LvlLabel_5);
            Controls.Add(panel6);
            Controls.Add(EmailLabel_4);
            Controls.Add(PasswordLabel_4);
            Controls.Add(LoginLabel_4);
            Controls.Add(LvlLabel_4);
            Controls.Add(panel5);
            Controls.Add(EmailLabel_3);
            Controls.Add(PasswordLabel_3);
            Controls.Add(LoginLabel_3);
            Controls.Add(LvlLabel_3);
            Controls.Add(panel4);
            Controls.Add(EmailLabel_2);
            Controls.Add(PasswordLabel_2);
            Controls.Add(LoginLabel_2);
            Controls.Add(LvlLabel_2);
            Controls.Add(panel9);
            Controls.Add(EmailLabel_1);
            Controls.Add(PasswordLabel_1);
            Controls.Add(LoginLabel_1);
            Controls.Add(LvlLabel_1);
            Controls.Add(panel8);
            Controls.Add(StaticEmailLabel);
            Controls.Add(StaticLvlLabel);
            Controls.Add(StaticPasswordLabel);
            Controls.Add(StaticLoginLabel);
            Controls.Add(NextPageButton);
            Controls.Add(PrevPageButton);
            Controls.Add(CurrentPageLabel);
            Controls.Add(panel1);
            Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "AdminsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AProfileForm";
            Load += AProfileForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NextPageButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)PrevPageButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label AdminProfileLabel;
        private Panel panel3;
        private Panel panel2;
        private Label ROVLabel;
        private Label AdminsLabel;
        private Label UsersLabel;
        private Label ViosLabel;
        private Label CarsLabel;
        private PictureBox NextPageButton;
        private PictureBox PrevPageButton;
        private Label CurrentPageLabel;
        private Label StaticEmailLabel;
        private Label StaticLvlLabel;
        private Label StaticPasswordLabel;
        private Label StaticLoginLabel;
        private Panel panel8;
        private Label LvlLabel_1;
        private Label LoginLabel_1;
        private Label PasswordLabel_1;
        private Label EmailLabel_1;
        private Label EmailLabel_2;
        private Label PasswordLabel_2;
        private Label LoginLabel_2;
        private Label LvlLabel_2;
        private Panel panel9;
        private Label EmailLabel_3;
        private Label PasswordLabel_3;
        private Label LoginLabel_3;
        private Label LvlLabel_3;
        private Panel panel4;
        private Label EmailLabel_4;
        private Label PasswordLabel_4;
        private Label LoginLabel_4;
        private Label LvlLabel_4;
        private Panel panel5;
        private Label EmailLabel_5;
        private Label PasswordLabel_5;
        private Label LoginLabel_5;
        private Label LvlLabel_5;
        private Panel panel6;
        private Label EmailLabel_6;
        private Label PasswordLabel_6;
        private Label LoginLabel_6;
        private Label LvlLabel_6;
        private Panel panel7;
        private Label EmailLabel_7;
        private Label PasswordLabel_7;
        private Label LoginLabel_7;
        private Label LvlLabel_7;
        private Panel panel10;
        private PictureBox AddButton;
    }
}