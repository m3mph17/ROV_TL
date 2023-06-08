namespace ROV_TL.AdminForms.AdminAddtional
{
    partial class AddVioForm
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
            panel1 = new Panel();
            ViosLabel = new Label();
            AdminProfileLabel = new Label();
            panel3 = new Panel();
            CarsLabel = new Label();
            panel2 = new Panel();
            ROVLabel = new Label();
            AdminsLabel = new Label();
            UsersLabel = new Label();
            LoginTextBox = new TextBox();
            ModelTextBox = new TextBox();
            VioTextBox = new TextBox();
            FineTextBox = new TextBox();
            UIDTextBox = new TextBox();
            CIDTextBox = new TextBox();
            DateTimePicker = new DateTimePicker();
            CreateButton = new Button();
            RandomGenButton = new Button();
            StaticHeaderLabel = new Label();
            panel1.SuspendLayout();
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
            panel1.TabIndex = 17;
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
            panel3.Location = new Point(1, 246);
            panel3.Name = "panel3";
            panel3.Size = new Size(136, 5);
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
            // LoginTextBox
            // 
            LoginTextBox.BackColor = Color.Tan;
            LoginTextBox.BorderStyle = BorderStyle.None;
            LoginTextBox.Location = new Point(274, 111);
            LoginTextBox.MaxLength = 50;
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.PlaceholderText = "Login";
            LoginTextBox.Size = new Size(241, 29);
            LoginTextBox.TabIndex = 50;
            // 
            // ModelTextBox
            // 
            ModelTextBox.BackColor = Color.Tan;
            ModelTextBox.BorderStyle = BorderStyle.None;
            ModelTextBox.Location = new Point(274, 158);
            ModelTextBox.MaxLength = 50;
            ModelTextBox.Name = "ModelTextBox";
            ModelTextBox.PlaceholderText = "Car model";
            ModelTextBox.Size = new Size(556, 29);
            ModelTextBox.TabIndex = 51;
            // 
            // VioTextBox
            // 
            VioTextBox.BackColor = Color.Tan;
            VioTextBox.BorderStyle = BorderStyle.None;
            VioTextBox.Location = new Point(210, 210);
            VioTextBox.MaxLength = 50;
            VioTextBox.Multiline = true;
            VioTextBox.Name = "VioTextBox";
            VioTextBox.PlaceholderText = "Violation text";
            VioTextBox.Size = new Size(620, 76);
            VioTextBox.TabIndex = 52;
            // 
            // FineTextBox
            // 
            FineTextBox.BackColor = Color.Tan;
            FineTextBox.BorderStyle = BorderStyle.None;
            FineTextBox.Location = new Point(210, 302);
            FineTextBox.MaxLength = 50;
            FineTextBox.Name = "FineTextBox";
            FineTextBox.PlaceholderText = "Fine";
            FineTextBox.Size = new Size(620, 29);
            FineTextBox.TabIndex = 53;
            // 
            // UIDTextBox
            // 
            UIDTextBox.BackColor = Color.Tan;
            UIDTextBox.BorderStyle = BorderStyle.None;
            UIDTextBox.Location = new Point(210, 111);
            UIDTextBox.MaxLength = 50;
            UIDTextBox.Name = "UIDTextBox";
            UIDTextBox.PlaceholderText = "UID";
            UIDTextBox.Size = new Size(58, 29);
            UIDTextBox.TabIndex = 54;
            // 
            // CIDTextBox
            // 
            CIDTextBox.BackColor = Color.Tan;
            CIDTextBox.BorderStyle = BorderStyle.None;
            CIDTextBox.Location = new Point(210, 158);
            CIDTextBox.MaxLength = 50;
            CIDTextBox.Name = "CIDTextBox";
            CIDTextBox.PlaceholderText = "CID";
            CIDTextBox.Size = new Size(58, 29);
            CIDTextBox.TabIndex = 55;
            // 
            // DateTimePicker
            // 
            DateTimePicker.CalendarForeColor = Color.White;
            DateTimePicker.CalendarMonthBackground = Color.Tan;
            DateTimePicker.CalendarTitleBackColor = Color.FromArgb(45, 45, 45);
            DateTimePicker.CalendarTitleForeColor = Color.White;
            DateTimePicker.CalendarTrailingForeColor = Color.Tan;
            DateTimePicker.Location = new Point(629, 109);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.Size = new Size(201, 36);
            DateTimePicker.TabIndex = 57;
            // 
            // CreateButton
            // 
            CreateButton.BackColor = Color.Tan;
            CreateButton.FlatStyle = FlatStyle.Flat;
            CreateButton.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CreateButton.ForeColor = Color.Black;
            CreateButton.Location = new Point(633, 365);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(197, 36);
            CreateButton.TabIndex = 58;
            CreateButton.Text = "Создать";
            CreateButton.UseVisualStyleBackColor = false;
            CreateButton.Click += CreateButton_Click;
            // 
            // RandomGenButton
            // 
            RandomGenButton.BackColor = Color.Tan;
            RandomGenButton.FlatStyle = FlatStyle.Flat;
            RandomGenButton.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            RandomGenButton.ForeColor = Color.Black;
            RandomGenButton.Location = new Point(210, 365);
            RandomGenButton.Name = "RandomGenButton";
            RandomGenButton.Size = new Size(198, 36);
            RandomGenButton.TabIndex = 59;
            RandomGenButton.Text = "Заполнить случайно";
            RandomGenButton.UseVisualStyleBackColor = false;
            RandomGenButton.Click += RandomGenButton_Click;
            // 
            // StaticHeaderLabel
            // 
            StaticHeaderLabel.AutoSize = true;
            StaticHeaderLabel.Font = new Font("Bahnschrift SemiCondensed", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            StaticHeaderLabel.Location = new Point(210, 25);
            StaticHeaderLabel.Name = "StaticHeaderLabel";
            StaticHeaderLabel.Size = new Size(476, 45);
            StaticHeaderLabel.TabIndex = 60;
            StaticHeaderLabel.Text = "Добавление нового нарушения";
            // 
            // AddVioForm
            // 
            AutoScaleDimensions = new SizeF(11F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(867, 455);
            Controls.Add(StaticHeaderLabel);
            Controls.Add(RandomGenButton);
            Controls.Add(CreateButton);
            Controls.Add(DateTimePicker);
            Controls.Add(CIDTextBox);
            Controls.Add(UIDTextBox);
            Controls.Add(FineTextBox);
            Controls.Add(VioTextBox);
            Controls.Add(ModelTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(panel1);
            Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 6, 5, 6);
            Name = "AddVioForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddVioForm";
            Load += AddVioForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private TextBox LoginTextBox;
        private TextBox ModelTextBox;
        private TextBox VioTextBox;
        private TextBox FineTextBox;
        private TextBox UIDTextBox;
        private TextBox CIDTextBox;
        private DateTimePicker DateTimePicker;
        private Button CreateButton;
        private Button RandomGenButton;
        private Label StaticHeaderLabel;
    }
}