using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLNC
{
    public partial class HSBA_V : Form
    {
        private string PatientID = "";
        
       
        public HSBA_V(string PatientID)
        {
            InitializeComponent();
            this.PatientID = PatientID;
            tpPatient.Text = PatientID;
            loadHoso(this.PatientID);
        }

        private void loadHoso(string patientID)
        {
            SqlCommand cmd;
            if (patientID == "")
            {
                return;
            }
            else
            {
                cmd = new SqlCommand("SELECT * FROM HOSO WHERE BNKham = @id", IntermediateFunctions.con);
                cmd.Parameters.AddWithValue("@id", patientID);
            }

            IntermediateFunctions.con.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            hosoList.DataSource = dt;

            IntermediateFunctions.con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

       
        

      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            hosoList.CurrentRow.Selected = true;
            tpDentistName.Text = hosoList.Rows[e.RowIndex].Cells["NSKham"].Value.ToString();
            tpDate.Text = hosoList.Rows[e.RowIndex].Cells["HSNgayKham"].Value.ToString();
            loadDonThuoc(hosoList.Rows[e.RowIndex].Cells["MaHS"].Value.ToString());
            loadDichvu(hosoList.Rows[e.RowIndex].Cells["MaHS"].Value.ToString());
        }


        private void loadDichvu(string idHoso)
        {
            IntermediateFunctions.con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOSO_DICHVU WHERE MaHSKham=@idHoso", IntermediateFunctions.con);
            cmd.Parameters.AddWithValue("@idHoso", idHoso);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dichvuList.DataSource = dt;

            IntermediateFunctions.con.Close();
        }

        private void loadDonThuoc(string idHoso)
        {
            IntermediateFunctions.con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOSO_THUOC WHERE MaHSKham=@idHoso", IntermediateFunctions.con);
            cmd.Parameters.AddWithValue("@idHoso", idHoso);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            donThuocList.DataSource = dt;

            IntermediateFunctions.con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        

        private void addBtn_Click(object sender, EventArgs e)
        {
           
        }

        

        private void delBtn_Click(object sender, EventArgs e)
        {
          
        }

        private void deleteRow(string tableName, string field, string key)
        {
           
        }

        private void adjustBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tpPatient_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
