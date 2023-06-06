namespace ROV_TL.AdminForms.AdminAddtional
{
    partial class ViosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViosForm));
            panel1 = new Panel();
            ViosLabel = new Label();
            AdminProfileLabel = new Label();
            panel3 = new Panel();
            CarsLabel = new Label();
            panel2 = new Panel();
            ROVLabel = new Label();
            AdminsLabel = new Label();
            UsersLabel = new Label();
            NotPayedViosButton = new Button();
            PayedVioButton = new Button();
            ActiveVioButton = new Button();
            CurrentPageLabel = new Label();
            CreateNewVio = new Button();
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
            panel1.TabIndex = 16;
            // 
            // ViosLabel
            // 
            ViosLabel.AutoSize = true;
            ViosLabel.ForeColor = Color.Black;
            ViosLabel.Location = new Point(11, 216);
            ViosLabel.Margin = new Padding(5, 0, 5, 0);
            ViosLabel.Name = "ViosLabel";
            ViosLabel.Size = new Size(119, 29);
            ViosLabel.TabIndex = 11;
            ViosLabel.Text = "Нарушения";
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
            // NotPayedViosButton
            // 
            NotPayedViosButton.BackColor = Color.Tan;
            NotPayedViosButton.FlatStyle = FlatStyle.Flat;
            NotPayedViosButton.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            NotPayedViosButton.ForeColor = Color.Black;
            NotPayedViosButton.Location = new Point(250, 109);
            NotPayedViosButton.Name = "NotPayedViosButton";
            NotPayedViosButton.Size = new Size(220, 74);
            NotPayedViosButton.TabIndex = 39;
            NotPayedViosButton.Text = "Неоплаченные штрафы";
            NotPayedViosButton.UseVisualStyleBackColor = false;
            NotPayedViosButton.Click += NotPayedViosButton_Click;
            // 
            // PayedVioButton
            // 
            PayedVioButton.BackColor = Color.Tan;
            PayedVioButton.FlatStyle = FlatStyle.Flat;
            PayedVioButton.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PayedVioButton.ForeColor = Color.Black;
            PayedVioButton.Location = new Point(569, 109);
            PayedVioButton.Name = "PayedVioButton";
            PayedVioButton.Size = new Size(220, 74);
            PayedVioButton.TabIndex = 40;
            PayedVioButton.Text = "Оплаченные штрафы";
            PayedVioButton.UseVisualStyleBackColor = false;
            PayedVioButton.Click += PayedVioButton_Click;
            // 
            // ActiveVioButton
            // 
            ActiveVioButton.BackColor = Color.Tan;
            ActiveVioButton.FlatStyle = FlatStyle.Flat;
            ActiveVioButton.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ActiveVioButton.ForeColor = Color.Black;
            ActiveVioButton.Location = new Point(250, 229);
            ActiveVioButton.Name = "ActiveVioButton";
            ActiveVioButton.Size = new Size(220, 74);
            ActiveVioButton.TabIndex = 41;
            ActiveVioButton.Text = "База активных правил";
            ActiveVioButton.UseVisualStyleBackColor = false;
            ActiveVioButton.Click += ActiveVioButton_Click;
            // 
            // CurrentPageLabel
            // 
            CurrentPageLabel.AutoSize = true;
            CurrentPageLabel.Font = new Font("Bahnschrift SemiBold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            CurrentPageLabel.Location = new Point(250, 32);
            CurrentPageLabel.Name = "CurrentPageLabel";
            CurrentPageLabel.Size = new Size(539, 35);
            CurrentPageLabel.TabIndex = 46;
            CurrentPageLabel.Text = "Меню взаимодействия с нарушениями";
            // 
            // CreateNewVio
            // 
            CreateNewVio.BackColor = Color.Tan;
            CreateNewVio.FlatStyle = FlatStyle.Flat;
            CreateNewVio.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CreateNewVio.ForeColor = Color.Black;
            CreateNewVio.Location = new Point(569, 229);
            CreateNewVio.Name = "CreateNewVio";
            CreateNewVio.Size = new Size(220, 74);
            CreateNewVio.TabIndex = 47;
            CreateNewVio.Text = "Создать новое нарушение";
            CreateNewVio.UseVisualStyleBackColor = false;
            CreateNewVio.Click += CreateNewVio_Click;
            // 
            // ViosForm
            // 
            AutoScaleDimensions = new SizeF(11F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(867, 455);
            Controls.Add(CreateNewVio);
            Controls.Add(CurrentPageLabel);
            Controls.Add(ActiveVioButton);
            Controls.Add(PayedVioButton);
            Controls.Add(NotPayedViosButton);
            Controls.Add(panel1);
            Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "ViosForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViosForm";
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
        private Button NotPayedViosButton;
        private Button PayedVioButton;
        private Button ActiveVioButton;
        private Label CurrentPageLabel;
        private Button CreateNewVio;
    }
}