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
            this.pictBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoadPointList = new System.Windows.Forms.Button();
            this.buttonUpdPicBox = new System.Windows.Forms.Button();
            this.txtBottom = new System.Windows.Forms.NumericUpDown();
            this.txtTop = new System.Windows.Forms.NumericUpDown();
            this.txtRight = new System.Windows.Forms.NumericUpDown();
            this.txtLeft = new System.Windows.Forms.NumericUpDown();
            this.flagTrimLine = new System.Windows.Forms.CheckBox();
            this.qText = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ContoursGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qText)).BeginInit();
            this.SuspendLayout();
            // 
            // ContoursGrid
            // 
            this.ContoursGrid.AllowUserToOrderColumns = true;
            this.ContoursGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContoursGrid.Location = new System.Drawing.Point(11, 11);
            this.ContoursGrid.Name = "ContoursGrid";
            this.ContoursGrid.Size = new System.Drawing.Size(334, 334);
            this.ContoursGrid.TabIndex = 0;
            // 
            // pictBox
            // 
            this.pictBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictBox.Location = new System.Drawing.Point(351, 11);
            this.pictBox.Name = "pictBox";
            this.pictBox.Size = new System.Drawing.Size(402, 334);
            this.pictBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictBox.TabIndex = 1;
            this.pictBox.TabStop = false;
            this.pictBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictBox_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(466, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Прямоугольник: X1 - Y1";
            // 
            // buttonLoadPointList
            // 
            this.buttonLoadPointList.Location = new System.Drawing.Point(15, 360);
            this.buttonLoadPointList.Name = "buttonLoadPointList";
            this.buttonLoadPointList.Size = new System.Drawing.Size(130, 23);
            this.buttonLoadPointList.TabIndex = 8;
            this.buttonLoadPointList.Text = "Загрузить данные";
            this.buttonLoadPointList.UseVisualStyleBackColor = true;
            this.buttonLoadPointList.Click += new System.EventHandler(this.buttonLoadPointList_Click);
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
            this.txtBottom.Location = new System.Drawing.Point(661, 393);
            this.txtBottom.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.txtBottom.Name = "txtBottom";
            this.txtBottom.Size = new System.Drawing.Size(44, 20);
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
            this.txtTop.Location = new System.Drawing.Point(608, 393);
            this.txtTop.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(47, 20);
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
            this.txtRight.Location = new System.Drawing.Point(661, 367);
            this.txtRight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(44, 20);
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
            this.txtLeft.Location = new System.Drawing.Point(608, 367);
            this.txtLeft.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(47, 20);
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
            this.flagTrimLine.Location = new System.Drawing.Point(163, 364);
            this.flagTrimLine.Name = "flagTrimLine";
            this.flagTrimLine.Size = new System.Drawing.Size(203, 17);
            this.flagTrimLine.TabIndex = 19;
            this.flagTrimLine.Text = "Контуры только в прямоугольнике";
            this.flagTrimLine.UseVisualStyleBackColor = true;
            // 
            // qText
            // 
            this.qText.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.qText.Location = new System.Drawing.Point(661, 420);
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
            this.qText.Size = new System.Drawing.Size(43, 20);
            this.qText.TabIndex = 20;
            this.qText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(466, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Прямоугольник: X2 - Y2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(466, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Коэффициент масштабирования";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 472);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.qText);
            this.Controls.Add(this.flagTrimLine);
            this.Controls.Add(this.txtBottom);
            this.Controls.Add(this.txtTop);
            this.Controls.Add(this.txtRight);
            this.Controls.Add(this.txtLeft);
            this.Controls.Add(this.ContoursGrid);
            this.Controls.Add(this.pictBox);
            this.Controls.Add(this.buttonLoadPointList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Form";
            ((System.ComponentModel.ISupportInitialize)(this.ContoursGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private DataGridView ContoursGrid;
        private Label label1;
        private Button buttonLoadPointList;
        public PictureBox pictBox;
        private Button buttonUpdPicBox;
        private NumericUpDown txtBottom;
        private NumericUpDown txtTop;
        private NumericUpDown txtRight;
        private NumericUpDown txtLeft;
        private CheckBox flagTrimLine;
        private NumericUpDown qText;
        private Label label2;
        private Label label3;
    }
}