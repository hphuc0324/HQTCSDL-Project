﻿namespace CSDLNC
{
    partial class HSBA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HSBA));
            this.panel1 = new System.Windows.Forms.Panel();
            this.donThuocList = new System.Windows.Forms.DataGridView();
            this.dichvuList = new System.Windows.Forms.DataGridView();
            this.tpDate = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tpDentistName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hosoList = new System.Windows.Forms.DataGridView();
            this.patientCombox = new System.Windows.Forms.ComboBox();
            this.filterBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donThuocList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichvuList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hosoList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.donThuocList);
            this.panel1.Controls.Add(this.dichvuList);
            this.panel1.Controls.Add(this.tpDate);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tpDentistName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(471, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 585);
            this.panel1.TabIndex = 21;
            // 
            // donThuocList
            // 
            this.donThuocList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.donThuocList.Location = new System.Drawing.Point(150, 383);
            this.donThuocList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.donThuocList.Name = "donThuocList";
            this.donThuocList.RowHeadersWidth = 62;
            this.donThuocList.Size = new System.Drawing.Size(243, 142);
            this.donThuocList.TabIndex = 50;
            // 
            // dichvuList
            // 
            this.dichvuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dichvuList.Location = new System.Drawing.Point(150, 197);
            this.dichvuList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dichvuList.Name = "dichvuList";
            this.dichvuList.RowHeadersWidth = 62;
            this.dichvuList.Size = new System.Drawing.Size(243, 142);
            this.dichvuList.TabIndex = 49;
            // 
            // tpDate
            // 
            this.tpDate.CustomFormat = "MM-dd-yyyy";
            this.tpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpDate.Location = new System.Drawing.Point(150, 151);
            this.tpDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpDate.Name = "tpDate";
            this.tpDate.Size = new System.Drawing.Size(241, 26);
            this.tpDate.TabIndex = 48;
            this.tpDate.Value = new System.DateTime(2025, 12, 25, 0, 0, 0, 0);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 532);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 29);
            this.button2.TabIndex = 47;
            this.button2.Text = "Chỉnh sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 46;
            this.button1.Text = "Chỉnh sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "DS thuốc";
            // 
            // tpDentistName
            // 
            this.tpDentistName.Location = new System.Drawing.Point(150, 100);
            this.tpDentistName.Name = "tpDentistName";
            this.tpDentistName.Size = new System.Drawing.Size(241, 26);
            this.tpDentistName.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Ngày khám";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Dịch vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nha sĩ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Bệnh nhân";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(114, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 38);
            this.label1.TabIndex = 18;
            this.label1.Text = "Hồ sơ bệnh án";
            // 
            // hosoList
            // 
            this.hosoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hosoList.Location = new System.Drawing.Point(3, 126);
            this.hosoList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hosoList.Name = "hosoList";
            this.hosoList.RowHeadersWidth = 62;
            this.hosoList.Size = new System.Drawing.Size(460, 435);
            this.hosoList.TabIndex = 22;
            this.hosoList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // patientCombox
            // 
            this.patientCombox.FormattingEnabled = true;
            this.patientCombox.Location = new System.Drawing.Point(121, 85);
            this.patientCombox.Name = "patientCombox";
            this.patientCombox.Size = new System.Drawing.Size(222, 28);
            this.patientCombox.TabIndex = 23;
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(370, 87);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(93, 31);
            this.filterBtn.TabIndex = 24;
            this.filterBtn.Text = "Lọc";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // HSBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 578);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.patientCombox);
            this.Controls.Add(this.hosoList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HSBA";
            this.Text = "HSBA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donThuocList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichvuList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hosoList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView hosoList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tpDentistName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker tpDate;
        private System.Windows.Forms.DataGridView donThuocList;
        private System.Windows.Forms.DataGridView dichvuList;
        private System.Windows.Forms.ComboBox patientCombox;
        private System.Windows.Forms.Button filterBtn;
    }
}