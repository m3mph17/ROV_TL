namespace ROV_TL.Forms.Additional
{
    partial class PayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayForm));
            PayButton = new Button();
            StaticVioLabel = new Label();
            ViolationLabel = new Label();
            ModelLabel = new Label();
            label2 = new Label();
            PlateLabel = new Label();
            label4 = new Label();
            SumLabel = new Label();
            StaticSumLabel = new Label();
            CancelButton = new Button();
            CurrentBalanceLabel = new Label();
            CloseButton = new Label();
            panel8 = new Panel();
            SuspendLayout();
            // 
            // PayButton
            // 
            PayButton.BackColor = Color.Tan;
            PayButton.FlatStyle = FlatStyle.Flat;
            PayButton.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PayButton.ForeColor = Color.Black;
            PayButton.Location = new Point(310, 387);
            PayButton.Name = "PayButton";
            PayButton.Size = new Size(214, 64);
            PayButton.TabIndex = 1;
            PayButton.Text = "Оплатить";
            PayButton.UseVisualStyleBackColor = false;
            PayButton.Click += PayButton_Click;
            // 
            // StaticVioLabel
            // 
            StaticVioLabel.AutoSize = true;
            StaticVioLabel.Font = new Font("Bahnschrift SemiCondensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            StaticVioLabel.ForeColor = Color.White;
            StaticVioLabel.Location = new Point(60, 91);
            StaticVioLabel.Name = "StaticVioLabel";
            StaticVioLabel.Size = new Size(160, 39);
            StaticVioLabel.TabIndex = 2;
            StaticVioLabel.Text = "Нарушение";
            // 
            // ViolationLabel
            // 
            ViolationLabel.AutoSize = true;
            ViolationLabel.Cursor = Cursors.Hand;
            ViolationLabel.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ViolationLabel.Location = new Point(48, 147);
            ViolationLabel.Margin = new Padding(5, 0, 5, 0);
            ViolationLabel.MaximumSize = new Size(200, 0);
            ViolationLabel.MinimumSize = new Size(185, 46);
            ViolationLabel.Name = "ViolationLabel";
            ViolationLabel.Size = new Size(191, 75);
            ViolationLabel.TabIndex = 23;
            ViolationLabel.Text = "VIO TEXT VIO TEXT VIO TEXT VIO TEXT  VIO TEXT ";
            ViolationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ModelLabel
            // 
            ModelLabel.AutoSize = true;
            ModelLabel.Cursor = Cursors.Hand;
            ModelLabel.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ModelLabel.Location = new Point(48, 308);
            ModelLabel.Margin = new Padding(5, 0, 5, 0);
            ModelLabel.MaximumSize = new Size(200, 0);
            ModelLabel.MinimumSize = new Size(185, 46);
            ModelLabel.Name = "ModelLabel";
            ModelLabel.Size = new Size(185, 46);
            ModelLabel.TabIndex = 25;
            ModelLabel.Text = "Car model";
            ModelLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(60, 252);
            label2.Name = "label2";
            label2.Size = new Size(168, 39);
            label2.TabIndex = 24;
            label2.Text = "Автомобиль";
            // 
            // PlateLabel
            // 
            PlateLabel.AutoSize = true;
            PlateLabel.Cursor = Cursors.Hand;
            PlateLabel.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PlateLabel.Location = new Point(323, 308);
            PlateLabel.Margin = new Padding(5, 0, 5, 0);
            PlateLabel.MaximumSize = new Size(200, 0);
            PlateLabel.MinimumSize = new Size(185, 46);
            PlateLabel.Name = "PlateLabel";
            PlateLabel.Size = new Size(185, 46);
            PlateLabel.TabIndex = 27;
            PlateLabel.Text = "NUMPLATE";
            PlateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiCondensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(310, 252);
            label4.Name = "label4";
            label4.Size = new Size(210, 39);
            label4.TabIndex = 26;
            label4.Text = "Номерной знак";
            // 
            // SumLabel
            // 
            SumLabel.AutoSize = true;
            SumLabel.Cursor = Cursors.Hand;
            SumLabel.Font = new Font("Bahnschrift SemiCondensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            SumLabel.Location = new Point(323, 158);
            SumLabel.Margin = new Padding(5, 0, 5, 0);
            SumLabel.MaximumSize = new Size(200, 0);
            SumLabel.MinimumSize = new Size(185, 46);
            SumLabel.Name = "SumLabel";
            SumLabel.Size = new Size(185, 46);
            SumLabel.TabIndex = 29;
            SumLabel.Text = "0";
            SumLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StaticSumLabel
            // 
            StaticSumLabel.AutoSize = true;
            StaticSumLabel.Font = new Font("Bahnschrift SemiCondensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            StaticSumLabel.ForeColor = Color.White;
            StaticSumLabel.Location = new Point(367, 91);
            StaticSumLabel.Name = "StaticSumLabel";
            StaticSumLabel.Size = new Size(97, 39);
            StaticSumLabel.TabIndex = 28;
            StaticSumLabel.Text = "Сумма";
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.Tan;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CancelButton.ForeColor = Color.Black;
            CancelButton.Location = new Point(41, 387);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(198, 64);
            CancelButton.TabIndex = 30;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // CurrentBalanceLabel
            // 
            CurrentBalanceLabel.AutoSize = true;
            CurrentBalanceLabel.Font = new Font("Bahnschrift SemiCondensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentBalanceLabel.Location = new Point(12, 18);
            CurrentBalanceLabel.Name = "CurrentBalanceLabel";
            CurrentBalanceLabel.Size = new Size(227, 39);
            CurrentBalanceLabel.TabIndex = 31;
            CurrentBalanceLabel.Text = "Текущий баланс:";
            // 
            // CloseButton
            // 
            CloseButton.AutoSize = true;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new Font("Bahnschrift SemiCondensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            CloseButton.Location = new Point(513, 18);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(32, 39);
            CloseButton.TabIndex = 32;
            CloseButton.Text = "X";
            CloseButton.Click += CloseButton_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(55, 55, 55);
            panel8.Location = new Point(-18, 63);
            panel8.Name = "panel8";
            panel8.Size = new Size(643, 10);
            panel8.TabIndex = 47;
            // 
            // PayForm
            // 
            AutoScaleDimensions = new SizeF(11F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(560, 487);
            Controls.Add(panel8);
            Controls.Add(CloseButton);
            Controls.Add(CurrentBalanceLabel);
            Controls.Add(CancelButton);
            Controls.Add(SumLabel);
            Controls.Add(StaticSumLabel);
            Controls.Add(PlateLabel);
            Controls.Add(label4);
            Controls.Add(ModelLabel);
            Controls.Add(label2);
            Controls.Add(ViolationLabel);
            Controls.Add(StaticVioLabel);
            Controls.Add(PayButton);
            Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "PayForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PayForm";
            Load += PayForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PayButton;
        private Label StaticVioLabel;
        private Label ViolationLabel;
        private Label ModelLabel;
        private Label label2;
        private Label PlateLabel;
        private Label label4;
        private Label SumLabel;
        private Label StaticSumLabel;
        private Button CancelButton;
        private Label CurrentBalanceLabel;
        private Label CloseButton;
        private Panel panel8;
    }
}