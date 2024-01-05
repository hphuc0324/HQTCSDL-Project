namespace CSDLNC
{
    partial class DSThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSThuoc));
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.donthuocList = new System.Windows.Forms.DataGridView();
            this.soluongBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.thuocList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.idThuocCombox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.donthuocList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 40);
            this.label1.TabIndex = 27;
            this.label1.Text = "Danh sách đơn thuốc";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(616, 314);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 43);
            this.button7.TabIndex = 55;
            this.button7.Text = "Xóa";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(498, 314);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(78, 43);
            this.button6.TabIndex = 54;
            this.button6.Text = "Sửa";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(372, 314);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 43);
            this.button5.TabIndex = 53;
            this.button5.Text = "Thêm";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 515);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 60;
            this.label9.Text = "Tổng phí";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(146, 511);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(200, 26);
            this.textBox8.TabIndex = 61;
            // 
            // donthuocList
            // 
            this.donthuocList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.donthuocList.Location = new System.Drawing.Point(18, 83);
            this.donthuocList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.donthuocList.Name = "donthuocList";
            this.donthuocList.RowHeadersWidth = 62;
            this.donthuocList.Size = new System.Drawing.Size(330, 146);
            this.donthuocList.TabIndex = 62;
            this.donthuocList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // soluongBox
            // 
            this.soluongBox.Location = new System.Drawing.Point(498, 203);
            this.soluongBox.Name = "soluongBox";
            this.soluongBox.Size = new System.Drawing.Size(193, 26);
            this.soluongBox.TabIndex = 68;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(378, 146);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 20);
            this.label20.TabIndex = 63;
            this.label20.Text = "Mã Thuốc";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(378, 209);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 20);
            this.label21.TabIndex = 64;
            this.label21.Text = "Số lượng";
            // 
            // thuocList
            // 
            this.thuocList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thuocList.Location = new System.Drawing.Point(13, 338);
            this.thuocList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thuocList.Name = "thuocList";
            this.thuocList.RowHeadersWidth = 62;
            this.thuocList.Size = new System.Drawing.Size(330, 146);
            this.thuocList.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(30, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 40);
            this.label2.TabIndex = 71;
            this.label2.Text = "Danh sách thuốc";
            // 
            // idThuocCombox
            // 
            this.idThuocCombox.FormattingEnabled = true;
            this.idThuocCombox.Location = new System.Drawing.Point(498, 146);
            this.idThuocCombox.Name = "idThuocCombox";
            this.idThuocCombox.Size = new System.Drawing.Size(193, 28);
            this.idThuocCombox.TabIndex = 72;
            // 
            // DSThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 563);
            this.Controls.Add(this.idThuocCombox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.thuocList);
            this.Controls.Add(this.soluongBox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.donthuocList);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DSThuoc";
            this.Text = "Thuoc";
            ((System.ComponentModel.ISupportInitialize)(this.donthuocList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.DataGridView donthuocList;
        private System.Windows.Forms.TextBox soluongBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView thuocList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox idThuocCombox;
    }
}