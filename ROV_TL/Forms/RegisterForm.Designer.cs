namespace ROV_TL.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            loginTextBox = new TextBox();
            passwordTextBox = new TextBox();
            emailTextBox = new TextBox();
            registerButton = new Button();
            fioTextBox = new TextBox();
            textBox1 = new TextBox();
            LoginButton = new Button();
            staticLabel = new Label();
            panel1 = new Panel();
            closeLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // loginTextBox
            // 
            loginTextBox.BackColor = Color.Tan;
            loginTextBox.BorderStyle = BorderStyle.None;
            loginTextBox.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            loginTextBox.ForeColor = SystemColors.WindowText;
            loginTextBox.Location = new Point(29, 92);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.PlaceholderText = "Логин";
            loginTextBox.Size = new Size(269, 29);
            loginTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.Tan;
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(29, 138);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Пароль";
            passwordTextBox.Size = new Size(269, 29);
            passwordTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.Tan;
            emailTextBox.BorderStyle = BorderStyle.None;
            emailTextBox.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox.Location = new Point(29, 270);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "Email";
            emailTextBox.Size = new Size(269, 29);
            emailTextBox.TabIndex = 2;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.Tan;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            registerButton.Location = new Point(187, 324);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(111, 52);
            registerButton.TabIndex = 3;
            registerButton.Text = "Регистрация";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // fioTextBox
            // 
            fioTextBox.BackColor = Color.Tan;
            fioTextBox.BorderStyle = BorderStyle.None;
            fioTextBox.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            fioTextBox.Location = new Point(29, 226);
            fioTextBox.Name = "fioTextBox";
            fioTextBox.PlaceholderText = "ФИО";
            fioTextBox.Size = new Size(269, 29);
            fioTextBox.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Tan;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(29, 182);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Подтвердить пароль";
            textBox1.Size = new Size(269, 29);
            textBox1.TabIndex = 5;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Tan;
            LoginButton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.Location = new Point(29, 324);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(111, 52);
            LoginButton.TabIndex = 6;
            LoginButton.Text = "Вход";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // staticLabel
            // 
            staticLabel.AutoSize = true;
            staticLabel.BackColor = Color.Tan;
            staticLabel.Font = new Font("Bahnschrift Condensed", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            staticLabel.Location = new Point(94, 19);
            staticLabel.Name = "staticLabel";
            staticLabel.Size = new Size(164, 42);
            staticLabel.TabIndex = 7;
            staticLabel.Text = "Регистрация";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(closeLabel);
            panel1.Controls.Add(staticLabel);
            panel1.Location = new Point(-10, -10);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 75);
            panel1.TabIndex = 8;
            // 
            // closeLabel
            // 
            closeLabel.AutoSize = true;
            closeLabel.Cursor = Cursors.Hand;
            closeLabel.Font = new Font("Bahnschrift SemiBold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            closeLabel.Location = new Point(289, 19);
            closeLabel.Name = "closeLabel";
            closeLabel.Size = new Size(30, 33);
            closeLabel.TabIndex = 8;
            closeLabel.Text = "X";
            closeLabel.Click += closeLabel_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(329, 404);
            Controls.Add(LoginButton);
            Controls.Add(textBox1);
            Controls.Add(fioTextBox);
            Controls.Add(registerButton);
            Controls.Add(emailTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(loginTextBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            KeyDown += RegisterForm_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginTextBox;
        private TextBox passwordTextBox;
        private TextBox emailTextBox;
        private Button registerButton;
        private TextBox fioTextBox;
        private TextBox textBox1;
        private Button LoginButton;
        private Label staticLabel;
        private Panel panel1;
        private Label closeLabel;
    }
}