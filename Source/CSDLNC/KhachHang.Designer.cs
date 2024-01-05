namespace CSDLNC
{
    partial class KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.appointmentList = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.dentistBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.dobBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.patientBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.currDobBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.currAddressBox = new System.Windows.Forms.TextBox();
            this.currPasswordBox = new System.Windows.Forms.TextBox();
            this.currNameBox = new System.Windows.Forms.TextBox();
            this.currUsernameBox = new System.Windows.Forms.TextBox();
            this.currIDBox = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentList)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1014, 600);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reloadBtn);
            this.tabPage1.Controls.Add(this.appointmentList);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1006, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DatLichHen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reloadBtn
            // 
            this.reloadBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.reloadBtn.Location = new System.Drawing.Point(386, 494);
            this.reloadBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(171, 46);
            this.reloadBtn.TabIndex = 5;
            this.reloadBtn.Text = "Tải lại";
            this.reloadBtn.UseVisualStyleBackColor = false;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // appointmentList
            // 
            this.appointmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentList.Location = new System.Drawing.Point(19, 72);
            this.appointmentList.Name = "appointmentList";
            this.appointmentList.RowHeadersWidth = 62;
            this.appointmentList.RowTemplate.Height = 28;
            this.appointmentList.Size = new System.Drawing.Size(538, 415);
            this.appointmentList.TabIndex = 4;
            this.appointmentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentList_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Location = new System.Drawing.Point(19, 494);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Đặt lịch hẹn";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.timeBox);
            this.panel1.Controls.Add(this.dentistBox);
            this.panel1.Controls.Add(this.addressBox);
            this.panel1.Controls.Add(this.dobBox);
            this.panel1.Controls.Add(this.phoneBox);
            this.panel1.Controls.Add(this.patientBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(583, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 569);
            this.panel1.TabIndex = 2;
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(204, 402);
            this.timeBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(165, 26);
            this.timeBox.TabIndex = 12;
            // 
            // dentistBox
            // 
            this.dentistBox.Location = new System.Drawing.Point(204, 351);
            this.dentistBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dentistBox.Name = "dentistBox";
            this.dentistBox.Size = new System.Drawing.Size(165, 26);
            this.dentistBox.TabIndex = 11;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(204, 302);
            this.addressBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(165, 26);
            this.addressBox.TabIndex = 10;
            // 
            // dobBox
            // 
            this.dobBox.Location = new System.Drawing.Point(204, 252);
            this.dobBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dobBox.Name = "dobBox";
            this.dobBox.Size = new System.Drawing.Size(165, 26);
            this.dobBox.TabIndex = 9;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(204, 198);
            this.phoneBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(165, 26);
            this.phoneBox.TabIndex = 8;
            // 
            // patientBox
            // 
            this.patientBox.Location = new System.Drawing.Point(204, 148);
            this.patientBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.patientBox.Name = "patientBox";
            this.patientBox.Size = new System.Drawing.Size(165, 26);
            this.patientBox.TabIndex = 7;
            this.patientBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Thời gian hẹn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Bác sĩ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bệnh nhân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chi tiết lịch hẹn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(206, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lịch hẹn";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.currDobBox);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.currAddressBox);
            this.tabPage2.Controls.Add(this.currPasswordBox);
            this.tabPage2.Controls.Add(this.currNameBox);
            this.tabPage2.Controls.Add(this.currUsernameBox);
            this.tabPage2.Controls.Add(this.currIDBox);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.label26);
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Controls.Add(this.label28);
            this.tabPage2.Controls.Add(this.label29);
            this.tabPage2.Controls.Add(this.label30);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1006, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thong tin";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.Location = new System.Drawing.Point(571, 472);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 49);
            this.button2.TabIndex = 90;
            this.button2.Text = "Xem HSBA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // currDobBox
            // 
            this.currDobBox.BackColor = System.Drawing.Color.PaleGreen;
            this.currDobBox.Location = new System.Drawing.Point(439, 320);
            this.currDobBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currDobBox.Name = "currDobBox";
            this.currDobBox.Size = new System.Drawing.Size(252, 26);
            this.currDobBox.TabIndex = 89;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleGreen;
            this.panel3.Location = new System.Drawing.Point(744, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 569);
            this.panel3.TabIndex = 88;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGreen;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 569);
            this.panel2.TabIndex = 87;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LimeGreen;
            this.button9.Location = new System.Drawing.Point(439, 472);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 49);
            this.button9.TabIndex = 84;
            this.button9.Text = "Cập nhật";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // currAddressBox
            // 
            this.currAddressBox.BackColor = System.Drawing.SystemColors.Window;
            this.currAddressBox.Location = new System.Drawing.Point(439, 375);
            this.currAddressBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currAddressBox.Name = "currAddressBox";
            this.currAddressBox.Size = new System.Drawing.Size(252, 26);
            this.currAddressBox.TabIndex = 83;
            // 
            // currPasswordBox
            // 
            this.currPasswordBox.BackColor = System.Drawing.Color.PaleGreen;
            this.currPasswordBox.Location = new System.Drawing.Point(439, 221);
            this.currPasswordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currPasswordBox.Name = "currPasswordBox";
            this.currPasswordBox.Size = new System.Drawing.Size(252, 26);
            this.currPasswordBox.TabIndex = 82;
            // 
            // currNameBox
            // 
            this.currNameBox.Location = new System.Drawing.Point(439, 264);
            this.currNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currNameBox.Name = "currNameBox";
            this.currNameBox.Size = new System.Drawing.Size(252, 26);
            this.currNameBox.TabIndex = 81;
            // 
            // currUsernameBox
            // 
            this.currUsernameBox.Location = new System.Drawing.Point(439, 176);
            this.currUsernameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currUsernameBox.Name = "currUsernameBox";
            this.currUsernameBox.Size = new System.Drawing.Size(252, 26);
            this.currUsernameBox.TabIndex = 80;
            // 
            // currIDBox
            // 
            this.currIDBox.BackColor = System.Drawing.Color.PaleGreen;
            this.currIDBox.Location = new System.Drawing.Point(439, 134);
            this.currIDBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currIDBox.Name = "currIDBox";
            this.currIDBox.ReadOnly = true;
            this.currIDBox.Size = new System.Drawing.Size(252, 26);
            this.currIDBox.TabIndex = 79;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(291, 380);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 22);
            this.label24.TabIndex = 78;
            this.label24.Text = "Địa chỉ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(291, 320);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(90, 22);
            this.label26.TabIndex = 77;
            this.label26.Text = "Ngày sinh";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(291, 269);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(42, 22);
            this.label27.TabIndex = 76;
            this.label27.Text = "Tên";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(291, 221);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(83, 22);
            this.label28.TabIndex = 75;
            this.label28.Text = "Mật khẩu";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(291, 178);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(115, 22);
            this.label29.TabIndex = 74;
            this.label29.Text = "Số điện thoại";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(291, 139);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(27, 22);
            this.label30.TabIndex = 73;
            this.label30.Text = "ID";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.LightGreen;
            this.label17.Location = new System.Drawing.Point(320, 54);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(403, 46);
            this.label17.TabIndex = 72;
            this.label17.Text = "Thông tin khách hàng";
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 604);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.TextBox dentistBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox dobBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox patientBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox currAddressBox;
        private System.Windows.Forms.TextBox currPasswordBox;
        private System.Windows.Forms.TextBox currNameBox;
        private System.Windows.Forms.TextBox currUsernameBox;
        private System.Windows.Forms.TextBox currIDBox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox currDobBox;
        private System.Windows.Forms.DataGridView appointmentList;
        private System.Windows.Forms.Button reloadBtn;
    }
}