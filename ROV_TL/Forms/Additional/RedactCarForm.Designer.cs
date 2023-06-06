namespace ROV_TL.Forms.Additional
{
    partial class RedactCarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedactCarForm));
            CarModelTextBox = new TextBox();
            staticRedactLabel = new Label();
            ConfirmDataButton = new Button();
            CancelButton = new Button();
            StaticCloseLabel = new Label();
            SuspendLayout();
            // 
            // CarModelTextBox
            // 
            CarModelTextBox.BackColor = Color.Tan;
            CarModelTextBox.BorderStyle = BorderStyle.None;
            CarModelTextBox.Location = new Point(66, 92);
            CarModelTextBox.MaxLength = 20;
            CarModelTextBox.Name = "CarModelTextBox";
            CarModelTextBox.PlaceholderText = "Car model";
            CarModelTextBox.Size = new Size(414, 29);
            CarModelTextBox.TabIndex = 0;
            // 
            // staticRedactLabel
            // 
            staticRedactLabel.AutoSize = true;
            staticRedactLabel.Font = new Font("Bahnschrift SemiCondensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            staticRedactLabel.Location = new Point(59, 28);
            staticRedactLabel.Name = "staticRedactLabel";
            staticRedactLabel.Size = new Size(432, 39);
            staticRedactLabel.TabIndex = 1;
            staticRedactLabel.Text = "Изменение информации об авто";
            // 
            // ConfirmDataButton
            // 
            ConfirmDataButton.BackColor = Color.Tan;
            ConfirmDataButton.FlatStyle = FlatStyle.Flat;
            ConfirmDataButton.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmDataButton.ForeColor = Color.Black;
            ConfirmDataButton.Location = new Point(283, 155);
            ConfirmDataButton.Name = "ConfirmDataButton";
            ConfirmDataButton.Size = new Size(197, 34);
            ConfirmDataButton.TabIndex = 19;
            ConfirmDataButton.Text = "Подтвердить данные";
            ConfirmDataButton.UseVisualStyleBackColor = false;
            ConfirmDataButton.Click += ConfirmDataButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.Tan;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CancelButton.ForeColor = Color.Black;
            CancelButton.Location = new Point(66, 155);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(197, 34);
            CancelButton.TabIndex = 20;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // StaticCloseLabel
            // 
            StaticCloseLabel.AutoSize = true;
            StaticCloseLabel.Cursor = Cursors.Hand;
            StaticCloseLabel.Location = new Point(510, 9);
            StaticCloseLabel.Name = "StaticCloseLabel";
            StaticCloseLabel.Size = new Size(25, 29);
            StaticCloseLabel.TabIndex = 21;
            StaticCloseLabel.Text = "X";
            StaticCloseLabel.Click += StaticCloseLabel_Click;
            // 
            // RedactCarForm
            // 
            AutoScaleDimensions = new SizeF(11F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 45);
            ClientSize = new Size(553, 221);
            Controls.Add(StaticCloseLabel);
            Controls.Add(CancelButton);
            Controls.Add(ConfirmDataButton);
            Controls.Add(staticRedactLabel);
            Controls.Add(CarModelTextBox);
            Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "RedactCarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RedactCarForm";
            Load += RedactCarForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CarModelTextBox;
        private Label staticRedactLabel;
        private Button ConfirmDataButton;
        private Button CancelButton;
        private Label StaticCloseLabel;
    }
}