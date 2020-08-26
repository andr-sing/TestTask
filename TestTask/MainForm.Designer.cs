using System.Drawing;

namespace TestTask
{
    partial class MainForm
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
            this.StartBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rec2yNum = new System.Windows.Forms.NumericUpDown();
            this.rec1yNum = new System.Windows.Forms.NumericUpDown();
            this.rec2xNum = new System.Windows.Forms.NumericUpDown();
            this.rec1xNum = new System.Windows.Forms.NumericUpDown();
            this.rec0yNum = new System.Windows.Forms.NumericUpDown();
            this.rec0xNum = new System.Windows.Forms.NumericUpDown();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SimulateCB = new System.Windows.Forms.CheckBox();
            this.fileTB = new System.Windows.Forms.TextBox();
            this.FileBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rec2yNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rec1yNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rec2xNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rec1xNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rec0yNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rec0xNum)).BeginInit();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(717, 38);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(126, 38);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Восстановить траекторию";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(559, 490);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rec2yNum);
            this.groupBox1.Controls.Add(this.rec1yNum);
            this.groupBox1.Controls.Add(this.rec2xNum);
            this.groupBox1.Controls.Add(this.rec1xNum);
            this.groupBox1.Controls.Add(this.rec0yNum);
            this.groupBox1.Controls.Add(this.rec0xNum);
            this.groupBox1.Location = new System.Drawing.Point(577, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 116);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Координаты радиоприемников";
            // 
            // rec2yNum
            // 
            this.rec2yNum.DecimalPlaces = 8;
            this.rec2yNum.Enabled = false;
            this.rec2yNum.Location = new System.Drawing.Point(136, 86);
            this.rec2yNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.rec2yNum.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.rec2yNum.Name = "rec2yNum";
            this.rec2yNum.Size = new System.Drawing.Size(120, 20);
            this.rec2yNum.TabIndex = 3;
            this.rec2yNum.ValueChanged += new System.EventHandler(this.Coords_changed);
            // 
            // rec1yNum
            // 
            this.rec1yNum.DecimalPlaces = 8;
            this.rec1yNum.Enabled = false;
            this.rec1yNum.Location = new System.Drawing.Point(136, 60);
            this.rec1yNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.rec1yNum.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.rec1yNum.Name = "rec1yNum";
            this.rec1yNum.Size = new System.Drawing.Size(120, 20);
            this.rec1yNum.TabIndex = 3;
            this.rec1yNum.ValueChanged += new System.EventHandler(this.Coords_changed);
            // 
            // rec2xNum
            // 
            this.rec2xNum.DecimalPlaces = 8;
            this.rec2xNum.Enabled = false;
            this.rec2xNum.Location = new System.Drawing.Point(9, 87);
            this.rec2xNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.rec2xNum.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.rec2xNum.Name = "rec2xNum";
            this.rec2xNum.Size = new System.Drawing.Size(120, 20);
            this.rec2xNum.TabIndex = 2;
            this.rec2xNum.ValueChanged += new System.EventHandler(this.Coords_changed);
            // 
            // rec1xNum
            // 
            this.rec1xNum.DecimalPlaces = 8;
            this.rec1xNum.Enabled = false;
            this.rec1xNum.Location = new System.Drawing.Point(9, 61);
            this.rec1xNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.rec1xNum.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.rec1xNum.Name = "rec1xNum";
            this.rec1xNum.Size = new System.Drawing.Size(120, 20);
            this.rec1xNum.TabIndex = 2;
            this.rec1xNum.ValueChanged += new System.EventHandler(this.Coords_changed);
            // 
            // rec0yNum
            // 
            this.rec0yNum.DecimalPlaces = 8;
            this.rec0yNum.Enabled = false;
            this.rec0yNum.Location = new System.Drawing.Point(135, 34);
            this.rec0yNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.rec0yNum.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.rec0yNum.Name = "rec0yNum";
            this.rec0yNum.Size = new System.Drawing.Size(120, 20);
            this.rec0yNum.TabIndex = 1;
            this.rec0yNum.ValueChanged += new System.EventHandler(this.Coords_changed);
            // 
            // rec0xNum
            // 
            this.rec0xNum.DecimalPlaces = 8;
            this.rec0xNum.Enabled = false;
            this.rec0xNum.Location = new System.Drawing.Point(9, 34);
            this.rec0xNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.rec0xNum.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.rec0xNum.Name = "rec0xNum";
            this.rec0xNum.Size = new System.Drawing.Size(120, 20);
            this.rec0xNum.TabIndex = 0;
            this.rec0xNum.ValueChanged += new System.EventHandler(this.Coords_changed);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(709, 462);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(126, 38);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Сохранить в файл";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // SimulateCB
            // 
            this.SimulateCB.Appearance = System.Windows.Forms.Appearance.Button;
            this.SimulateCB.AutoSize = true;
            this.SimulateCB.Location = new System.Drawing.Point(762, 309);
            this.SimulateCB.Name = "SimulateCB";
            this.SimulateCB.Size = new System.Drawing.Size(81, 25);
            this.SimulateCB.TabIndex = 5;
            this.SimulateCB.Text = "Симуляция";
            this.SimulateCB.UseVisualStyleBackColor = true;
            this.SimulateCB.CheckedChanged += new System.EventHandler(this.SimulateCB_CheckedChanged);
            // 
            // fileTB
            // 
            this.fileTB.Enabled = false;
            this.fileTB.Location = new System.Drawing.Point(586, 12);
            this.fileTB.Name = "fileTB";
            this.fileTB.Size = new System.Drawing.Size(257, 20);
            this.fileTB.TabIndex = 6;
            this.fileTB.Text = "input.txt";
            // 
            // FileBtn
            // 
            this.FileBtn.Location = new System.Drawing.Point(586, 38);
            this.FileBtn.Name = "FileBtn";
            this.FileBtn.Size = new System.Drawing.Size(126, 38);
            this.FileBtn.TabIndex = 7;
            this.FileBtn.Text = "Открыть файл";
            this.FileBtn.UseVisualStyleBackColor = true;
            this.FileBtn.Click += new System.EventHandler(this.FileBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 514);
            this.Controls.Add(this.FileBtn);
            this.Controls.Add(this.fileTB);
            this.Controls.Add(this.SimulateCB);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StartBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Тестовое задание";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rec2yNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rec1yNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rec2xNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rec1xNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rec0yNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rec0xNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown rec1yNum;
        private System.Windows.Forms.NumericUpDown rec1xNum;
        private System.Windows.Forms.NumericUpDown rec0yNum;
        private System.Windows.Forms.NumericUpDown rec0xNum;
        private System.Windows.Forms.NumericUpDown rec2yNum;
        private System.Windows.Forms.NumericUpDown rec2xNum;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.CheckBox SimulateCB;
        private System.Windows.Forms.TextBox fileTB;
        private System.Windows.Forms.Button FileBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

