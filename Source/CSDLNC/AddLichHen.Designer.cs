namespace CSDLNC
{
    partial class AddLichHen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLichHen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.patientCombox = new System.Windows.Forms.ComboBox();
            this.appointTimeBox = new System.Windows.Forms.DateTimePicker();
            this.addBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.calList = new System.Windows.Forms.DataGridView();
            this.filterBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.allBtn = new System.Windows.Forms.Button();
            this.dentistCombox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(255, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ thống đặt lịch hẹn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bệnh nhân";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(572, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lọc nha sĩ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.patientCombox);
            this.panel1.Controls.Add(this.appointTimeBox);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 201);
            this.panel1.TabIndex = 6;
            // 
            // patientCombox
            // 
            this.patientCombox.FormattingEnabled = true;
            this.patientCombox.Location = new System.Drawing.Point(156, 114);
            this.patientCombox.Name = "patientCombox";
            this.patientCombox.Size = new System.Drawing.Size(146, 28);
            this.patientCombox.TabIndex = 20;
            // 
            // appointTimeBox
            // 
            this.appointTimeBox.Location = new System.Drawing.Point(521, 112);
            this.appointTimeBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.appointTimeBox.Name = "appointTimeBox";
            this.appointTimeBox.Size = new System.Drawing.Size(224, 26);
            this.appointTimeBox.TabIndex = 19;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(760, 112);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(111, 29);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "Xác nhận";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Chọn ngày giờ khám";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // calList
            // 
            this.calList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calList.Location = new System.Drawing.Point(26, 266);
            this.calList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calList.Name = "calList";
            this.calList.RowHeadersWidth = 51;
            this.calList.Size = new System.Drawing.Size(536, 348);
            this.calList.TabIndex = 14;
            this.calList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(577, 392);
            this.filterBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(99, 29);
            this.filterBtn.TabIndex = 13;
            this.filterBtn.Text = "Lọc";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(151, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(326, 38);
            this.label9.TabIndex = 20;
            this.label9.Text = "Danh sách Lịch trống";
            // 
            // allBtn
            // 
            this.allBtn.Location = new System.Drawing.Point(755, 392);
            this.allBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allBtn.Name = "allBtn";
            this.allBtn.Size = new System.Drawing.Size(106, 29);
            this.allBtn.TabIndex = 21;
            this.allBtn.Text = "Tất cả";
            this.allBtn.UseVisualStyleBackColor = true;
            this.allBtn.Click += new System.EventHandler(this.allBtn_Click);
            // 
            // dentistCombox
            // 
            this.dentistCombox.FormattingEnabled = true;
            this.dentistCombox.Location = new System.Drawing.Point(699, 311);
            this.dentistCombox.Name = "dentistCombox";
            this.dentistCombox.Size = new System.Drawing.Size(162, 28);
            this.dentistCombox.TabIndex = 22;
            // 
            // AddLichHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 630);
            this.Controls.Add(this.dentistCombox);
            this.Controls.Add(this.allBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.calList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddLichHen";
            this.Text = "AddLichHen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView calList;
        private System.Windows.Forms.DateTimePicker appointTimeBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button allBtn;
        private System.Windows.Forms.ComboBox patientCombox;
        private System.Windows.Forms.ComboBox dentistCombox;
    }
}