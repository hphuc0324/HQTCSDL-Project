﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CSDLNC
{
    public partial class AddLichHen : Form
    {

        private string patientID;

        public AddLichHen(string patientID = "")
        {
            InitializeComponent();
            this.patientID = patientID;
            loadPatientCombox();
            loadDentistCombox();
            loadCalendar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("sp_addAppoint", IntermediateFunctions.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maLH", IntermediateFunctions.getNewID("LICHHEN", "MaLichHen"));
            cmd.Parameters.AddWithValue("@maBN", patientCombox.Text);
            cmd.Parameters.AddWithValue("@maNS", dentistCombox.Text);

            DateTime dateValue = DateTime.Parse(appointTimeBox.Text);
            cmd.Parameters.AddWithValue("@time", dateValue);
            IntermediateFunctions.con.Open();

            int rows = cmd.ExecuteNonQuery();

            if(rows <= 0)
            {
                MessageBox.Show("Lỗi: Không thể thêm lịch hẹn");
            }
            else
            {
                MessageBox.Show("Thêm lịch hẹn thành công");
            }

            IntermediateFunctions.con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           


        }

        private void loadCombobox(string table, string field, ComboBox combox)
        {
            IntermediateFunctions.con.Open();
            SqlCommand cmd = new SqlCommand($"SELECT * FROM {table}", IntermediateFunctions.con);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {

                while (reader.Read())
                {
                    combox.Items.Add(reader[field].ToString());

                }
            }

            IntermediateFunctions.con.Close();
        }

        private void loadPatientCombox()
        {
            if(this.patientID != "")
            {
                patientCombox.Text = this.patientID;
            }
            else
            {
                loadCombobox("BENHNHAN", "MaBN", patientCombox);
            }
        }

        private void loadDentistCombox()
        {
            loadCombobox("NHASI", "MaNS", dentistCombox);
        }

        private void roomCombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dentistID = dentistCombox.Text;
            loadCalendar(dentistID);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            calList.CurrentRow.Selected = true;

            dentistCombox.Text = calList.Rows[e.RowIndex].Cells["MaNSLich"].Value.ToString();
            appointTimeBox.Text = calList.Rows[e.RowIndex].Cells["LichTrong"].Value.ToString();
        }
        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void loadCalendar(string dentistID ="")
        {
            IntermediateFunctions.con.Open();
            SqlCommand cmd;

            if(dentistID == "")
            {
                cmd = new SqlCommand("SELECT * FROM LICHLAMVIEC", IntermediateFunctions.con);
            }
            else
            {
                cmd = new SqlCommand("SELECT * FROM LICHLAMVIEC WHERE MaNSLich=@dentistID", IntermediateFunctions.con);
                cmd.Parameters.AddWithValue("@dentistID", dentistID);
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            calList.DataSource = dt;

            IntermediateFunctions.con.Close();
            loadCalendar();
        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            loadCalendar();
        }
    }
}
