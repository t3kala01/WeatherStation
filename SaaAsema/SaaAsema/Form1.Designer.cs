﻿using System;

namespace SaaAsema
{
    partial class Form1
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
            this.lampotila = new System.Windows.Forms.Label();
            this.ilmankosteus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ilmankosteusAvg = new System.Windows.Forms.Label();
            this.lampotilaAvg = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ilmankosteusAvgFromDate = new System.Windows.Forms.Label();
            this.lampotilaAvgFromDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.weatherDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lampotila
            // 
            this.lampotila.AutoSize = true;
            this.lampotila.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lampotila.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lampotila.Location = new System.Drawing.Point(6, 36);
            this.lampotila.Name = "lampotila";
            this.lampotila.Size = new System.Drawing.Size(88, 33);
            this.lampotila.TabIndex = 2;
            this.lampotila.Text = "0.0°C";
            // 
            // ilmankosteus
            // 
            this.ilmankosteus.AutoSize = true;
            this.ilmankosteus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ilmankosteus.Location = new System.Drawing.Point(152, 36);
            this.ilmankosteus.Name = "ilmankosteus";
            this.ilmankosteus.Size = new System.Drawing.Size(81, 33);
            this.ilmankosteus.TabIndex = 3;
            this.ilmankosteus.Text = "0.0%";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ilmankosteusAvg);
            this.groupBox1.Controls.Add(this.lampotilaAvg);
            this.groupBox1.Controls.Add(this.ilmankosteus);
            this.groupBox1.Controls.Add(this.lampotila);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 143);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Todays Temperature and Humidity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Average Temperature";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Average Humidity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Current Humidity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Current Temperature";
            // 
            // ilmankosteusAvg
            // 
            this.ilmankosteusAvg.AutoSize = true;
            this.ilmankosteusAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ilmankosteusAvg.Location = new System.Drawing.Point(152, 99);
            this.ilmankosteusAvg.Name = "ilmankosteusAvg";
            this.ilmankosteusAvg.Size = new System.Drawing.Size(81, 33);
            this.ilmankosteusAvg.TabIndex = 6;
            this.ilmankosteusAvg.Text = "0.0%";
            // 
            // lampotilaAvg
            // 
            this.lampotilaAvg.AutoSize = true;
            this.lampotilaAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lampotilaAvg.Location = new System.Drawing.Point(6, 99);
            this.lampotilaAvg.Name = "lampotilaAvg";
            this.lampotilaAvg.Size = new System.Drawing.Size(88, 33);
            this.lampotilaAvg.TabIndex = 5;
            this.lampotilaAvg.Text = "0.0°C";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ilmankosteusAvgFromDate);
            this.groupBox2.Controls.Add(this.lampotilaAvgFromDate);
            this.groupBox2.Location = new System.Drawing.Point(290, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 96);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data from selected date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Average Humidity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Average Temperature";
            // 
            // ilmankosteusAvgFromDate
            // 
            this.ilmankosteusAvgFromDate.AutoSize = true;
            this.ilmankosteusAvgFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ilmankosteusAvgFromDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ilmankosteusAvgFromDate.Location = new System.Drawing.Point(170, 36);
            this.ilmankosteusAvgFromDate.Name = "ilmankosteusAvgFromDate";
            this.ilmankosteusAvgFromDate.Size = new System.Drawing.Size(81, 33);
            this.ilmankosteusAvgFromDate.TabIndex = 6;
            this.ilmankosteusAvgFromDate.Text = "0.0%";
            // 
            // lampotilaAvgFromDate
            // 
            this.lampotilaAvgFromDate.AutoSize = true;
            this.lampotilaAvgFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lampotilaAvgFromDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lampotilaAvgFromDate.Location = new System.Drawing.Point(6, 36);
            this.lampotilaAvgFromDate.Name = "lampotilaAvgFromDate";
            this.lampotilaAvgFromDate.Size = new System.Drawing.Size(88, 33);
            this.lampotilaAvgFromDate.TabIndex = 5;
            this.lampotilaAvgFromDate.Text = "0.0°C";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(290, 198);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(279, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // weatherDataGridView
            // 
            this.weatherDataGridView.AllowUserToAddRows = false;
            this.weatherDataGridView.AllowUserToDeleteRows = false;
            this.weatherDataGridView.AllowUserToResizeColumns = false;
            this.weatherDataGridView.AllowUserToResizeRows = false;
            this.weatherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weatherDataGridView.Location = new System.Drawing.Point(61, 297);
            this.weatherDataGridView.Name = "weatherDataGridView";
            this.weatherDataGridView.ReadOnly = true;
            this.weatherDataGridView.Size = new System.Drawing.Size(446, 300);
            this.weatherDataGridView.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 666);
            this.Controls.Add(this.weatherDataGridView);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label lampotila;
        private System.Windows.Forms.Label ilmankosteus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lampotilaAvg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lampotilaAvgFromDate;
        private System.Windows.Forms.Label ilmankosteusAvg;
        private System.Windows.Forms.Label ilmankosteusAvgFromDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView weatherDataGridView;
    }
}

