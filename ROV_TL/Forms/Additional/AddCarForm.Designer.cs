namespace ROV_TL.Forms.Additional
{
    partial class AddCarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCarForm));
            StaticCloseLabel = new Label();
            CancelButton = new Button();
            AddCarButton = new Button();
            staticRedactLabel = new Label();
            CarModelTextBox = new TextBox();
            NumplateTextBox = new TextBox();
            SuspendLayout();
            // 
            // StaticCloseLabel
            // 
            StaticCloseLabel.AutoSize = true;
            StaticCloseLabel.Cursor = Cursors.Hand;
            StaticCloseLabel.Location = new Point(507, 9);
            StaticCloseLabel.Name = "StaticCloseLabel";
            StaticCloseLabel.Size = new Size(25, 29);
            StaticCloseLabel.TabIndex = 26;
            StaticCloseLabel.Text = "X";
            StaticCloseLabel.Click += StaticCloseLabel_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.Tan;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CancelButton.ForeColor = Color.Black;
            CancelButton.Location = new Point(53, 215);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(197, 34);
            CancelButton.TabIndex = 25;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddCarButton
            // 
            AddCarButton.BackColor = Color.Tan;
            AddCarButton.FlatStyle = FlatStyle.Flat;
            AddCarButton.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            AddCarButton.ForeColor = Color.Black;
            AddCarButton.Location = new Point(270, 215);
            AddCarButton.Name = "AddCarButton";
            AddCarButton.Size = new Size(197, 34);
            AddCarButton.TabIndex = 24;
            AddCarButton.Text = "Добавить авто";
            AddCarButton.UseVisualStyleBackColor = false;
            AddCarButton.Click += AddCarButton_Click;
            // 
            // staticRedactLabel
            // 
            staticRedactLabel.AutoSize = true;
            staticRedactLabel.Font = new Font("Bahnschrift SemiCondensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            staticRedactLabel.Location = new Point(53, 25);
            staticRedactLabel.Name = "staticRedactLabel";
            staticRedactLabel.Size = new Size(425, 39);
            staticRedactLabel.TabIndex = 23;
            staticRedactLabel.Text = "Добавление нового автомобиля";
            // 
            // CarModelTextBox
            // 
            CarModelTextBox.BackColor = Color.Tan;
            CarModelTextBox.BorderStyle = BorderStyle.None;
            CarModelTextBox.Location = new Point(53, 112);
            CarModelTextBox.MaxLength = 20;
            CarModelTextBox.Name = "CarModelTextBox";
            CarModelTextBox.PlaceholderText = "Car model";
            CarModelTextBox.Size = new Size(414, 29);
            CarModelTextBox.TabIndex = 22;
            // 
            // NumplateTextBox
            // 
            NumplateTextBox.BackColor = Color.Tan;
            NumplateTextBox.BorderStyle = BorderStyle.None;
            NumplateTextBox.Location = new Point(53, 162);
            NumplateTextBox.MaxLength = 20;
            NumplateTextBox.Name = "NumplateTextBox";
            NumplateTextBox.PlaceholderText = "Numplate";
            NumplateTextBox.Size = new Size(414, 29);
            NumplateTextBox.TabIndex = 27;
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(11F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 45);
            ClientSize = new Size(544, 295);
            Controls.Add(NumplateTextBox);
            Controls.Add(StaticCloseLabel);
            Controls.Add(CancelButton);
            Controls.Add(AddCarButton);
            Controls.Add(staticRedactLabel);
            Controls.Add(CarModelTextBox);
            Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "AddCarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StaticCloseLabel;
        private Button CancelButton;
        private Button AddCarButton;
        private Label staticRedactLabel;
        private TextBox CarModelTextBox;
        private TextBox NumplateTextBox;
    }
}