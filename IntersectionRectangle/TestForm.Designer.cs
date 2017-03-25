using System;
using System.Drawing;
using System.Windows.Forms;

namespace IntersectionLineRectangle
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
      //  private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ContoursGrid = new System.Windows.Forms.DataGridView();
            this.buttonUpdPicBox = new System.Windows.Forms.Button();
            this.txtBottom = new System.Windows.Forms.NumericUpDown();
            this.txtTop = new System.Windows.Forms.NumericUpDown();
            this.txtRight = new System.Windows.Forms.NumericUpDown();
            this.txtLeft = new System.Windows.Forms.NumericUpDown();
            this.flagTrimLine = new System.Windows.Forms.CheckBox();
            this.qText = new System.Windows.Forms.NumericUpDown();
            this.pictBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ContoursGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContoursGrid
            // 
            this.ContoursGrid.AllowUserToOrderColumns = true;
            this.ContoursGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContoursGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContoursGrid.Location = new System.Drawing.Point(3, 3);
            this.ContoursGrid.Name = "ContoursGrid";
            this.ContoursGrid.Size = new System.Drawing.Size(571, 375);
            this.ContoursGrid.TabIndex = 0;
            this.ContoursGrid.Resize += new System.EventHandler(this.buttonLoadPointList_Click);
            // 
            // buttonUpdPicBox
            // 
            this.buttonUpdPicBox.Location = new System.Drawing.Point(0, 0);
            this.buttonUpdPicBox.Name = "buttonUpdPicBox";
            this.buttonUpdPicBox.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdPicBox.TabIndex = 0;
            // 
            // txtBottom
            // 
            this.txtBottom.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtBottom.Location = new System.Drawing.Point(109, 48);
            this.txtBottom.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.txtBottom.Name = "txtBottom";
            this.txtBottom.Size = new System.Drawing.Size(56, 22);
            this.txtBottom.TabIndex = 18;
            this.txtBottom.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // txtTop
            // 
            this.txtTop.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtTop.Location = new System.Drawing.Point(34, 48);
            this.txtTop.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(46, 22);
            this.txtTop.TabIndex = 17;
            this.txtTop.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // txtRight
            // 
            this.txtRight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtRight.Location = new System.Drawing.Point(109, 21);
            this.txtRight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(56, 22);
            this.txtRight.TabIndex = 16;
            this.txtRight.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // txtLeft
            // 
            this.txtLeft.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtLeft.Location = new System.Drawing.Point(34, 21);
            this.txtLeft.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(46, 22);
            this.txtLeft.TabIndex = 15;
            this.txtLeft.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // flagTrimLine
            // 
            this.flagTrimLine.AutoSize = true;
            this.flagTrimLine.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flagTrimLine.Location = new System.Drawing.Point(228, 47);
            this.flagTrimLine.Name = "flagTrimLine";
            this.flagTrimLine.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flagTrimLine.Size = new System.Drawing.Size(218, 20);
            this.flagTrimLine.TabIndex = 19;
            this.flagTrimLine.Text = "Контуры только в прямоугольнике";
            this.flagTrimLine.UseVisualStyleBackColor = true;
            this.flagTrimLine.Click += new System.EventHandler(this.buttonLoadPointList_Click);
            // 
            // qText
            // 
            this.qText.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.qText.Location = new System.Drawing.Point(383, 21);
            this.qText.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.qText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qText.Name = "qText";
            this.qText.Size = new System.Drawing.Size(63, 22);
            this.qText.TabIndex = 20;
            this.qText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictBox
            // 
            this.pictBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictBox.Location = new System.Drawing.Point(580, 3);
            this.pictBox.Name = "pictBox";
            this.pictBox.Size = new System.Drawing.Size(571, 375);
            this.pictBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictBox.TabIndex = 22;
            this.pictBox.TabStop = false;
            this.pictBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictBox_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.qText);
            this.groupBox1.Controls.Add(this.flagTrimLine);
            this.groupBox1.Controls.Add(this.txtRight);
            this.groupBox1.Controls.Add(this.txtBottom);
            this.groupBox1.Controls.Add(this.txtLeft);
            this.groupBox1.Controls.Add(this.txtTop);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(3, 384);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 85);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Y1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Y1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "X1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(210, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = " Коэфф. масшт. изображения";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.linkLabel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ContoursGrid, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1154, 472);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(580, 381);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(376, 13);
            this.linkLabel1.TabIndex = 25;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Пример работы алгоритма Коэна—Сазерленда  (англ. Cohen–Sutherland) ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 472);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Form";
            this.Resize += new System.EventHandler(this.TestForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ContoursGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private DataGridView ContoursGrid;
        private Button buttonUpdPicBox;
        private NumericUpDown txtBottom;
        private NumericUpDown txtTop;
        private NumericUpDown txtRight;
        private NumericUpDown txtLeft;
        private CheckBox flagTrimLine;
        private NumericUpDown qText;
        public PictureBox pictBox;
        private GroupBox groupBox1;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private Label label5;
        private Label label2;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}