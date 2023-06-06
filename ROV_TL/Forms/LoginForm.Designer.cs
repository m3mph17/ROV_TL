namespace ROV_TL
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            LoginButton = new Button();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            RegisterButton = new Button();
            CloseLabel = new Label();
            StaticLabel = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Tan;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.Location = new Point(181, 246);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(125, 46);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Вход";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginTextBox
            // 
            LoginTextBox.BackColor = Color.Tan;
            LoginTextBox.BorderStyle = BorderStyle.None;
            LoginTextBox.Font = new Font("Bahnschrift Condensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            LoginTextBox.Location = new Point(27, 126);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.PlaceholderText = "Логин";
            LoginTextBox.Size = new Size(279, 35);
            LoginTextBox.TabIndex = 1;
            LoginTextBox.KeyPress += LoginTextBox_KeyPress;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = Color.Tan;
            PasswordTextBox.BorderStyle = BorderStyle.None;
            PasswordTextBox.Font = new Font("Bahnschrift Condensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.Location = new Point(27, 180);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PlaceholderText = "Пароль";
            PasswordTextBox.Size = new Size(279, 35);
            PasswordTextBox.TabIndex = 2;
            PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
            PasswordTextBox.KeyDown += PasswordTextBox_KeyDown;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.Tan;
            RegisterButton.FlatStyle = FlatStyle.Flat;
            RegisterButton.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterButton.Location = new Point(27, 246);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(111, 46);
            RegisterButton.TabIndex = 3;
            RegisterButton.Text = "Регистрация";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // CloseLabel
            // 
            CloseLabel.AutoSize = true;
            CloseLabel.Cursor = Cursors.Hand;
            CloseLabel.Font = new Font("Bahnschrift SemiBold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            CloseLabel.Location = new Point(288, 9);
            CloseLabel.Name = "CloseLabel";
            CloseLabel.Size = new Size(30, 33);
            CloseLabel.TabIndex = 8;
            CloseLabel.Text = "X";
            CloseLabel.Click += CloseLabel_Click;
            // 
            // StaticLabel
            // 
            StaticLabel.AutoSize = true;
            StaticLabel.BackColor = Color.Tan;
            StaticLabel.Font = new Font("Bahnschrift Condensed", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            StaticLabel.Location = new Point(68, 17);
            StaticLabel.Name = "StaticLabel";
            StaticLabel.Size = new Size(191, 42);
            StaticLabel.TabIndex = 7;
            StaticLabel.Text = "Вход в аккаунт";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(CloseLabel);
            panel1.Controls.Add(StaticLabel);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 75);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(329, 348);
            Controls.Add(panel1);
            Controls.Add(RegisterButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(LoginButton);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += LoginForm_Load;
            KeyDown += LoginForm_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Button RegisterButton;
        private Label CloseLabel;
        private Label StaticLabel;
        private Panel panel1;
    }
}