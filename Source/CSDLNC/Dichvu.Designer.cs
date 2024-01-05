namespace CSDLNC
{
    partial class Dichvu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dichvu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.treatingList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.feeBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.delBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.usedTreatingList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treatingList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usedTreatingList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.usedTreatingList);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.treatingList);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 565);
            this.panel1.TabIndex = 29;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(135, 528);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(200, 26);
            this.textBox8.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 532);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 62;
            this.label9.Text = "Tổng phí";
            // 
            // treatingList
            // 
            this.treatingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.treatingList.Location = new System.Drawing.Point(15, 66);
            this.treatingList.Name = "treatingList";
            this.treatingList.RowHeadersWidth = 62;
            this.treatingList.RowTemplate.Height = 28;
            this.treatingList.Size = new System.Drawing.Size(538, 178);
            this.treatingList.TabIndex = 28;
            this.treatingList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.treatingList_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 38);
            this.label1.TabIndex = 27;
            this.label1.Text = "Danh sách dịch vụ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1104, 385);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 29);
            this.button4.TabIndex = 27;
            this.button4.Text = "Xem";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1104, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 29);
            this.button3.TabIndex = 26;
            this.button3.Text = "Xem";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // feeBox
            // 
            this.feeBox.Location = new System.Drawing.Point(632, 237);
            this.feeBox.Name = "feeBox";
            this.feeBox.Size = new System.Drawing.Size(240, 26);
            this.feeBox.TabIndex = 12;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(632, 197);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(240, 26);
            this.nameBox.TabIndex = 13;
            this.nameBox.TextChanged += new System.EventHandler(this.treatmentName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(582, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phí";
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(776, 293);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(96, 43);
            this.delBtn.TabIndex = 35;
            this.delBtn.Text = "Xóa";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(586, 293);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(96, 43);
            this.addBtn.TabIndex = 33;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // usedTreatingList
            // 
            this.usedTreatingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usedTreatingList.Location = new System.Drawing.Point(15, 331);
            this.usedTreatingList.Name = "usedTreatingList";
            this.usedTreatingList.RowHeadersWidth = 62;
            this.usedTreatingList.RowTemplate.Height = 28;
            this.usedTreatingList.Size = new System.Drawing.Size(538, 178);
            this.usedTreatingList.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(457, 38);
            this.label2.TabIndex = 65;
            this.label2.Text = "Danh sách dịch vụ đã sử dụng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "ID";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(632, 151);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(240, 26);
            this.idBox.TabIndex = 37;
            // 
            // Dichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.feeBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dichvu";
            this.Text = "DV";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treatingList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usedTreatingList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox feeBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView treatingList;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView usedTreatingList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idBox;
    }
}