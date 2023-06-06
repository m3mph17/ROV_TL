namespace ROV_TL.Forms.Additional
{
    partial class BalanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BalanceForm));
            CurrentBalanceLabel = new Label();
            CloseButton = new Label();
            SumTextBox = new TextBox();
            CancelButton = new Button();
            PayButton = new Button();
            SuspendLayout();
            // 
            // CurrentBalanceLabel
            // 
            CurrentBalanceLabel.AutoSize = true;
            CurrentBalanceLabel.Font = new Font("Bahnschrift SemiCondensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentBalanceLabel.Location = new Point(30, 20);
            CurrentBalanceLabel.Name = "CurrentBalanceLabel";
            CurrentBalanceLabel.Size = new Size(227, 39);
            CurrentBalanceLabel.TabIndex = 32;
            CurrentBalanceLabel.Text = "Текущий баланс:";
            // 
            // CloseButton
            // 
            CloseButton.AutoSize = true;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new Font("Bahnschrift SemiCondensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            CloseButton.Location = new Point(458, 9);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(32, 39);
            CloseButton.TabIndex = 33;
            CloseButton.Text = "X";
            CloseButton.Click += CloseButton_Click;
            // 
            // SumTextBox
            // 
            SumTextBox.BackColor = Color.Tan;
            SumTextBox.BorderStyle = BorderStyle.None;
            SumTextBox.Font = new Font("Bahnschrift SemiCondensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            SumTextBox.Location = new Point(30, 92);
            SumTextBox.MaxLength = 20;
            SumTextBox.Name = "SumTextBox";
            SumTextBox.PlaceholderText = "Сумма";
            SumTextBox.Size = new Size(447, 35);
            SumTextBox.TabIndex = 34;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.Tan;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CancelButton.ForeColor = Color.Black;
            CancelButton.Location = new Point(30, 155);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(159, 54);
            CancelButton.TabIndex = 36;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // PayButton
            // 
            PayButton.BackColor = Color.Tan;
            PayButton.FlatStyle = FlatStyle.Flat;
            PayButton.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PayButton.ForeColor = Color.Black;
            PayButton.Location = new Point(307, 155);
            PayButton.Name = "PayButton";
            PayButton.Size = new Size(170, 54);
            PayButton.TabIndex = 35;
            PayButton.Text = "Пополнить";
            PayButton.UseVisualStyleBackColor = false;
            PayButton.Click += PayButton_Click;
            // 
            // BalanceForm
            // 
            AutoScaleDimensions = new SizeF(11F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 45);
            ClientSize = new Size(502, 242);
            Controls.Add(CancelButton);
            Controls.Add(PayButton);
            Controls.Add(SumTextBox);
            Controls.Add(CloseButton);
            Controls.Add(CurrentBalanceLabel);
            Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "BalanceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BalanceForm";
            Load += BalanceForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CurrentBalanceLabel;
        private Label CloseButton;
        private TextBox SumTextBox;
        private Button CancelButton;
        private Button PayButton;
    }
}