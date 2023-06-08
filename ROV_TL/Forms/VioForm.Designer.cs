﻿namespace ROV_TL.Forms
{
    partial class VioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VioForm));
            panel1 = new Panel();
            panel3 = new Panel();
            CarInfoLabel = new Label();
            panel2 = new Panel();
            ROVLabel = new Label();
            ProfileLabel = new Label();
            VioLabel = new Label();
            StaticCarLabel = new Label();
            StaticSumLabel = new Label();
            StaticVioLabel = new Label();
            StaticDateLabel = new Label();
            VioLabel_1 = new Label();
            ModelLabel_1 = new Label();
            SumLabel_1 = new Label();
            DateLabel_1 = new Label();
            DateLabel_2 = new Label();
            SumLabel_2 = new Label();
            ModelLabel_2 = new Label();
            VioLabel_2 = new Label();
            DateLabel_3 = new Label();
            SumLabel_3 = new Label();
            ModelLabel_3 = new Label();
            VioLabel_3 = new Label();
            DateLabel_4 = new Label();
            SumLabel_4 = new Label();
            ModelLabel_4 = new Label();
            VioLabel_4 = new Label();
            DateLabel_5 = new Label();
            SumLabel_5 = new Label();
            ModelLabel_5 = new Label();
            VioLabel_5 = new Label();
            CurrentPageLabel = new Label();
            PrevPageButton = new PictureBox();
            NextPageButton = new PictureBox();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            NoViosLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PrevPageButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NextPageButton).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(CarInfoLabel);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(ROVLabel);
            panel1.Controls.Add(ProfileLabel);
            panel1.Controls.Add(VioLabel);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(173, 460);
            panel1.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 35, 35);
            panel3.Location = new Point(-2, 163);
            panel3.Name = "panel3";
            panel3.Size = new Size(106, 5);
            panel3.TabIndex = 9;
            // 
            // CarInfoLabel
            // 
            CarInfoLabel.AutoSize = true;
            CarInfoLabel.Cursor = Cursors.Hand;
            CarInfoLabel.ForeColor = Color.Black;
            CarInfoLabel.Location = new Point(10, 170);
            CarInfoLabel.Margin = new Padding(5, 0, 5, 0);
            CarInfoLabel.Name = "CarInfoLabel";
            CarInfoLabel.Size = new Size(126, 29);
            CarInfoLabel.TabIndex = 8;
            CarInfoLabel.Text = "Автомобили";
            CarInfoLabel.Click += CarInfoLabel_Click;
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
            ROVLabel.Location = new Point(34, 10);
            ROVLabel.Name = "ROVLabel";
            ROVLabel.Size = new Size(99, 58);
            ROVLabel.TabIndex = 4;
            ROVLabel.Text = "ROV";
            // 
            // ProfileLabel
            // 
            ProfileLabel.AutoSize = true;
            ProfileLabel.Cursor = Cursors.Hand;
            ProfileLabel.ForeColor = Color.Black;
            ProfileLabel.Location = new Point(11, 98);
            ProfileLabel.Margin = new Padding(5, 0, 5, 0);
            ProfileLabel.Name = "ProfileLabel";
            ProfileLabel.Size = new Size(98, 29);
            ProfileLabel.TabIndex = 2;
            ProfileLabel.Text = "Профиль";
            ProfileLabel.Click += ProfileLabel_Click;
            // 
            // VioLabel
            // 
            VioLabel.AutoSize = true;
            VioLabel.ForeColor = Color.Black;
            VioLabel.Location = new Point(11, 134);
            VioLabel.Margin = new Padding(5, 0, 5, 0);
            VioLabel.Name = "VioLabel";
            VioLabel.Size = new Size(93, 29);
            VioLabel.TabIndex = 3;
            VioLabel.Text = "Штрафы";
            // 
            // StaticCarLabel
            // 
            StaticCarLabel.AutoSize = true;
            StaticCarLabel.Font = new Font("Bahnschrift SemiCondensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            StaticCarLabel.Location = new Point(446, 63);
            StaticCarLabel.Margin = new Padding(5, 0, 5, 0);
            StaticCarLabel.Name = "StaticCarLabel";
            StaticCarLabel.Size = new Size(67, 35);
            StaticCarLabel.TabIndex = 17;
            StaticCarLabel.Text = "Авто";
            // 
            // StaticSumLabel
            // 
            StaticSumLabel.AutoSize = true;
            StaticSumLabel.Font = new Font("Bahnschrift SemiCondensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            StaticSumLabel.Location = new Point(595, 63);
            StaticSumLabel.Margin = new Padding(5, 0, 5, 0);
            StaticSumLabel.Name = "StaticSumLabel";
            StaticSumLabel.Size = new Size(88, 35);
            StaticSumLabel.TabIndex = 19;
            StaticSumLabel.Text = "Сумма";
            // 
            // StaticVioLabel
            // 
            StaticVioLabel.AutoSize = true;
            StaticVioLabel.Font = new Font("Bahnschrift SemiCondensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            StaticVioLabel.Location = new Point(223, 63);
            StaticVioLabel.Margin = new Padding(5, 0, 5, 0);
            StaticVioLabel.Name = "StaticVioLabel";
            StaticVioLabel.Size = new Size(142, 35);
            StaticVioLabel.TabIndex = 20;
            StaticVioLabel.Text = "Нарушение";
            // 
            // StaticDateLabel
            // 
            StaticDateLabel.AutoSize = true;
            StaticDateLabel.Font = new Font("Bahnschrift SemiCondensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            StaticDateLabel.Location = new Point(756, 63);
            StaticDateLabel.Margin = new Padding(5, 0, 5, 0);
            StaticDateLabel.Name = "StaticDateLabel";
            StaticDateLabel.Size = new Size(72, 35);
            StaticDateLabel.TabIndex = 21;
            StaticDateLabel.Text = "Дата";
            // 
            // VioLabel_1
            // 
            VioLabel_1.AutoSize = true;
            VioLabel_1.Cursor = Cursors.Hand;
            VioLabel_1.Font = new Font("Bahnschrift SemiCondensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            VioLabel_1.Location = new Point(202, 113);
            VioLabel_1.Margin = new Padding(5, 0, 5, 0);
            VioLabel_1.MaximumSize = new Size(200, 0);
            VioLabel_1.MinimumSize = new Size(185, 46);
            VioLabel_1.Name = "VioLabel_1";
            VioLabel_1.Size = new Size(185, 46);
            VioLabel_1.TabIndex = 22;
            VioLabel_1.Text = "VIO TEXT VIO TEXT VIO TEXT VIO TEXT  VIO TEXT ";
            VioLabel_1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ModelLabel_1
            // 
            ModelLabel_1.AutoSize = true;
            ModelLabel_1.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ModelLabel_1.Location = new Point(441, 111);
            ModelLabel_1.MaximumSize = new Size(100, 0);
            ModelLabel_1.MinimumSize = new Size(70, 50);
            ModelLabel_1.Name = "ModelLabel_1";
            ModelLabel_1.Size = new Size(70, 50);
            ModelLabel_1.TabIndex = 23;
            ModelLabel_1.Text = "Model Model";
            ModelLabel_1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SumLabel_1
            // 
            SumLabel_1.AutoSize = true;
            SumLabel_1.Location = new Point(601, 121);
            SumLabel_1.MinimumSize = new Size(75, 0);
            SumLabel_1.Name = "SumLabel_1";
            SumLabel_1.Size = new Size(75, 29);
            SumLabel_1.TabIndex = 24;
            SumLabel_1.Text = "0";
            SumLabel_1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DateLabel_1
            // 
            DateLabel_1.AutoSize = true;
            DateLabel_1.Font = new Font("Bahnschrift SemiCondensed", 17.5F, FontStyle.Regular, GraphicsUnit.Point);
            DateLabel_1.Location = new Point(741, 108);
            DateLabel_1.MaximumSize = new Size(120, 0);
            DateLabel_1.Name = "DateLabel_1";
            DateLabel_1.Size = new Size(108, 29);
            DateLabel_1.TabIndex = 25;
            DateLabel_1.Text = "15.05.2023";
            DateLabel_1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DateLabel_2
            // 
            DateLabel_2.AutoSize = true;
            DateLabel_2.Font = new Font("Bahnschrift SemiCondensed", 17.5F, FontStyle.Regular, GraphicsUnit.Point);
            DateLabel_2.Location = new Point(741, 176);
            DateLabel_2.MaximumSize = new Size(120, 0);
            DateLabel_2.Name = "DateLabel_2";
            DateLabel_2.Size = new Size(108, 29);
            DateLabel_2.TabIndex = 29;
            DateLabel_2.Text = "15.05.2023";
            DateLabel_2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SumLabel_2
            // 
            SumLabel_2.AutoSize = true;
            SumLabel_2.Location = new Point(601, 191);
            SumLabel_2.MinimumSize = new Size(75, 0);
            SumLabel_2.Name = "SumLabel_2";
            SumLabel_2.Size = new Size(75, 29);
            SumLabel_2.TabIndex = 28;
            SumLabel_2.Text = "0";
            SumLabel_2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ModelLabel_2
            // 
            ModelLabel_2.AutoSize = true;
            ModelLabel_2.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ModelLabel_2.Location = new Point(441, 181);
            ModelLabel_2.MaximumSize = new Size(100, 0);
            ModelLabel_2.MinimumSize = new Size(70, 50);
            ModelLabel_2.Name = "ModelLabel_2";
            ModelLabel_2.Size = new Size(70, 50);
            ModelLabel_2.TabIndex = 27;
            ModelLabel_2.Text = "Model Model";
            ModelLabel_2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VioLabel_2
            // 
            VioLabel_2.AutoSize = true;
            VioLabel_2.Cursor = Cursors.Hand;
            VioLabel_2.Font = new Font("Bahnschrift SemiCondensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            VioLabel_2.Location = new Point(204, 182);
            VioLabel_2.Margin = new Padding(5, 0, 5, 0);
            VioLabel_2.MaximumSize = new Size(200, 0);
            VioLabel_2.MinimumSize = new Size(185, 46);
            VioLabel_2.Name = "VioLabel_2";
            VioLabel_2.Size = new Size(185, 46);
            VioLabel_2.TabIndex = 26;
            VioLabel_2.Text = "VIO TEXT VIO TEXT VIO TEXT VIO TEXT  VIO TEXT ";
            VioLabel_2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DateLabel_3
            // 
            DateLabel_3.AutoSize = true;
            DateLabel_3.Font = new Font("Bahnschrift SemiCondensed", 17.5F, FontStyle.Regular, GraphicsUnit.Point);
            DateLabel_3.Location = new Point(741, 248);
            DateLabel_3.MaximumSize = new Size(120, 0);
            DateLabel_3.Name = "DateLabel_3";
            DateLabel_3.Size = new Size(108, 29);
            DateLabel_3.TabIndex = 33;
            DateLabel_3.Text = "15.05.2023";
            DateLabel_3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SumLabel_3
            // 
            SumLabel_3.AutoSize = true;
            SumLabel_3.Location = new Point(601, 265);
            SumLabel_3.MinimumSize = new Size(75, 0);
            SumLabel_3.Name = "SumLabel_3";
            SumLabel_3.Size = new Size(75, 29);
            SumLabel_3.TabIndex = 32;
            SumLabel_3.Text = "0";
            SumLabel_3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ModelLabel_3
            // 
            ModelLabel_3.AutoSize = true;
            ModelLabel_3.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ModelLabel_3.Location = new Point(441, 254);
            ModelLabel_3.MaximumSize = new Size(100, 0);
            ModelLabel_3.MinimumSize = new Size(70, 50);
            ModelLabel_3.Name = "ModelLabel_3";
            ModelLabel_3.Size = new Size(70, 50);
            ModelLabel_3.TabIndex = 31;
            ModelLabel_3.Text = "Model Model";
            ModelLabel_3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VioLabel_3
            // 
            VioLabel_3.AutoSize = true;
            VioLabel_3.Cursor = Cursors.Hand;
            VioLabel_3.Font = new Font("Bahnschrift SemiCondensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            VioLabel_3.Location = new Point(204, 255);
            VioLabel_3.Margin = new Padding(5, 0, 5, 0);
            VioLabel_3.MaximumSize = new Size(200, 0);
            VioLabel_3.MinimumSize = new Size(185, 46);
            VioLabel_3.Name = "VioLabel_3";
            VioLabel_3.Size = new Size(185, 46);
            VioLabel_3.TabIndex = 30;
            VioLabel_3.Text = "VIO TEXT VIO TEXT VIO TEXT VIO TEXT  VIO TEXT ";
            VioLabel_3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DateLabel_4
            // 
            DateLabel_4.AutoSize = true;
            DateLabel_4.Font = new Font("Bahnschrift SemiCondensed", 17.5F, FontStyle.Regular, GraphicsUnit.Point);
            DateLabel_4.Location = new Point(741, 321);
            DateLabel_4.MaximumSize = new Size(120, 0);
            DateLabel_4.Name = "DateLabel_4";
            DateLabel_4.Size = new Size(108, 29);
            DateLabel_4.TabIndex = 37;
            DateLabel_4.Text = "15.05.2023";
            DateLabel_4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SumLabel_4
            // 
            SumLabel_4.AutoSize = true;
            SumLabel_4.Location = new Point(601, 334);
            SumLabel_4.MinimumSize = new Size(75, 0);
            SumLabel_4.Name = "SumLabel_4";
            SumLabel_4.Size = new Size(75, 29);
            SumLabel_4.TabIndex = 36;
            SumLabel_4.Text = "0";
            SumLabel_4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ModelLabel_4
            // 
            ModelLabel_4.AutoSize = true;
            ModelLabel_4.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ModelLabel_4.Location = new Point(441, 324);
            ModelLabel_4.MaximumSize = new Size(100, 0);
            ModelLabel_4.MinimumSize = new Size(70, 50);
            ModelLabel_4.Name = "ModelLabel_4";
            ModelLabel_4.Size = new Size(70, 50);
            ModelLabel_4.TabIndex = 35;
            ModelLabel_4.Text = "Model Model";
            ModelLabel_4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VioLabel_4
            // 
            VioLabel_4.AutoSize = true;
            VioLabel_4.Cursor = Cursors.Hand;
            VioLabel_4.Font = new Font("Bahnschrift SemiCondensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            VioLabel_4.Location = new Point(204, 326);
            VioLabel_4.Margin = new Padding(5, 0, 5, 0);
            VioLabel_4.MaximumSize = new Size(200, 0);
            VioLabel_4.MinimumSize = new Size(185, 46);
            VioLabel_4.Name = "VioLabel_4";
            VioLabel_4.Size = new Size(185, 46);
            VioLabel_4.TabIndex = 34;
            VioLabel_4.Text = "VIO TEXT VIO TEXT VIO TEXT VIO TEXT  VIO TEXT ";
            VioLabel_4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DateLabel_5
            // 
            DateLabel_5.AutoSize = true;
            DateLabel_5.Font = new Font("Bahnschrift SemiCondensed", 17.5F, FontStyle.Regular, GraphicsUnit.Point);
            DateLabel_5.Location = new Point(741, 390);
            DateLabel_5.MaximumSize = new Size(120, 0);
            DateLabel_5.Name = "DateLabel_5";
            DateLabel_5.Size = new Size(108, 29);
            DateLabel_5.TabIndex = 41;
            DateLabel_5.Text = "15.05.2023";
            DateLabel_5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SumLabel_5
            // 
            SumLabel_5.AutoSize = true;
            SumLabel_5.Location = new Point(601, 405);
            SumLabel_5.MinimumSize = new Size(75, 0);
            SumLabel_5.Name = "SumLabel_5";
            SumLabel_5.Size = new Size(75, 29);
            SumLabel_5.TabIndex = 40;
            SumLabel_5.Text = "0";
            SumLabel_5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ModelLabel_5
            // 
            ModelLabel_5.AutoSize = true;
            ModelLabel_5.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ModelLabel_5.Location = new Point(441, 395);
            ModelLabel_5.MaximumSize = new Size(100, 0);
            ModelLabel_5.MinimumSize = new Size(70, 50);
            ModelLabel_5.Name = "ModelLabel_5";
            ModelLabel_5.Size = new Size(70, 50);
            ModelLabel_5.TabIndex = 39;
            ModelLabel_5.Text = "Model Model";
            ModelLabel_5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VioLabel_5
            // 
            VioLabel_5.AutoSize = true;
            VioLabel_5.Cursor = Cursors.Hand;
            VioLabel_5.Font = new Font("Bahnschrift SemiCondensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            VioLabel_5.Location = new Point(204, 396);
            VioLabel_5.Margin = new Padding(5, 0, 5, 0);
            VioLabel_5.MaximumSize = new Size(200, 0);
            VioLabel_5.MinimumSize = new Size(185, 46);
            VioLabel_5.Name = "VioLabel_5";
            VioLabel_5.Size = new Size(185, 46);
            VioLabel_5.TabIndex = 38;
            VioLabel_5.Text = "VIO TEXT VIO TEXT VIO TEXT VIO TEXT  VIO TEXT ";
            VioLabel_5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CurrentPageLabel
            // 
            CurrentPageLabel.AutoSize = true;
            CurrentPageLabel.Font = new Font("Bahnschrift SemiBold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            CurrentPageLabel.Location = new Point(391, 13);
            CurrentPageLabel.Name = "CurrentPageLabel";
            CurrentPageLabel.Size = new Size(286, 35);
            CurrentPageLabel.TabIndex = 42;
            CurrentPageLabel.Text = "Текущая страница: 1";
            // 
            // PrevPageButton
            // 
            PrevPageButton.Cursor = Cursors.Hand;
            PrevPageButton.Image = Properties.Resources.PrevPageIcon;
            PrevPageButton.Location = new Point(355, 16);
            PrevPageButton.Name = "PrevPageButton";
            PrevPageButton.Size = new Size(30, 30);
            PrevPageButton.SizeMode = PictureBoxSizeMode.StretchImage;
            PrevPageButton.TabIndex = 43;
            PrevPageButton.TabStop = false;
            PrevPageButton.Click += PrevPageButton_Click;
            // 
            // NextPageButton
            // 
            NextPageButton.Cursor = Cursors.Hand;
            NextPageButton.Image = Properties.Resources.NextPageIcon;
            NextPageButton.Location = new Point(683, 16);
            NextPageButton.Name = "NextPageButton";
            NextPageButton.Size = new Size(30, 30);
            NextPageButton.SizeMode = PictureBoxSizeMode.StretchImage;
            NextPageButton.TabIndex = 44;
            NextPageButton.TabStop = false;
            NextPageButton.Click += NextPageButton_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(55, 55, 55);
            panel4.Location = new Point(206, 166);
            panel4.Name = "panel4";
            panel4.Size = new Size(643, 10);
            panel4.TabIndex = 45;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(55, 55, 55);
            panel5.Location = new Point(206, 238);
            panel5.Name = "panel5";
            panel5.Size = new Size(643, 10);
            panel5.TabIndex = 46;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(55, 55, 55);
            panel6.Location = new Point(206, 311);
            panel6.Name = "panel6";
            panel6.Size = new Size(643, 10);
            panel6.TabIndex = 46;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(55, 55, 55);
            panel7.Location = new Point(206, 380);
            panel7.Name = "panel7";
            panel7.Size = new Size(643, 10);
            panel7.TabIndex = 46;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(55, 55, 55);
            panel8.Location = new Point(206, 98);
            panel8.Name = "panel8";
            panel8.Size = new Size(643, 10);
            panel8.TabIndex = 46;
            // 
            // NoViosLabel
            // 
            NoViosLabel.AutoSize = true;
            NoViosLabel.Font = new Font("Bahnschrift SemiCondensed", 36F, FontStyle.Regular, GraphicsUnit.Point);
            NoViosLabel.Location = new Point(312, 173);
            NoViosLabel.MaximumSize = new Size(450, 0);
            NoViosLabel.Name = "NoViosLabel";
            NoViosLabel.Size = new Size(440, 116);
            NoViosLabel.TabIndex = 47;
            NoViosLabel.Text = "Штрафов не найдено! Нарушайте больше...";
            NoViosLabel.TextAlign = ContentAlignment.MiddleCenter;
            NoViosLabel.Visible = false;
            // 
            // VioForm
            // 
            AutoScaleDimensions = new SizeF(11F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(867, 455);
            Controls.Add(NoViosLabel);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(NextPageButton);
            Controls.Add(PrevPageButton);
            Controls.Add(CurrentPageLabel);
            Controls.Add(DateLabel_5);
            Controls.Add(SumLabel_5);
            Controls.Add(ModelLabel_5);
            Controls.Add(VioLabel_5);
            Controls.Add(DateLabel_4);
            Controls.Add(SumLabel_4);
            Controls.Add(ModelLabel_4);
            Controls.Add(VioLabel_4);
            Controls.Add(DateLabel_3);
            Controls.Add(SumLabel_3);
            Controls.Add(ModelLabel_3);
            Controls.Add(VioLabel_3);
            Controls.Add(DateLabel_2);
            Controls.Add(SumLabel_2);
            Controls.Add(ModelLabel_2);
            Controls.Add(VioLabel_2);
            Controls.Add(DateLabel_1);
            Controls.Add(SumLabel_1);
            Controls.Add(ModelLabel_1);
            Controls.Add(VioLabel_1);
            Controls.Add(StaticDateLabel);
            Controls.Add(StaticVioLabel);
            Controls.Add(StaticSumLabel);
            Controls.Add(StaticCarLabel);
            Controls.Add(panel1);
            Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "VioForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VioForm";
            Load += VioForm_Load;
            KeyDown += VioForm_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PrevPageButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)NextPageButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label CarInfoLabel;
        private Panel panel2;
        private Label ROVLabel;
        private Label ProfileLabel;
        private Label VioLabel;
        private Label StaticCarLabel;
        private Label StaticSumLabel;
        private Label StaticVioLabel;
        private Label StaticDateLabel;
        private Label VioLabel_1;
        private Label ModelLabel_1;
        private Label SumLabel_1;
        private Label DateLabel_1;
        private Label DateLabel_2;
        private Label SumLabel_2;
        private Label ModelLabel_2;
        private Label VioLabel_2;
        private Label DateLabel_3;
        private Label SumLabel_3;
        private Label ModelLabel_3;
        private Label VioLabel_3;
        private Label DateLabel_4;
        private Label SumLabel_4;
        private Label ModelLabel_4;
        private Label VioLabel_4;
        private Label DateLabel_5;
        private Label SumLabel_5;
        private Label ModelLabel_5;
        private Label VioLabel_5;
        private Label CurrentPageLabel;
        private PictureBox PrevPageButton;
        private PictureBox NextPageButton;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Label NoViosLabel;
    }
}